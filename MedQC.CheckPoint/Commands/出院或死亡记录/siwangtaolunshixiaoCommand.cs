﻿using EMRDBLib;
using EMRDBLib.DbAccess;
using MedDocSys.QCEngine.TimeCheck;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Xml;

using Heren.MedQC.Core;

namespace Heren.MedQC.CheckPoint.Commands
{
    /// <summary>
    /// 缺陷内容：缺死亡病例讨论记录
    /// 核查方法：下达死亡医嘱后七天内（包含当天），无死亡病例讨论记录，以病历文档医生审签时间为准。
    /// </summary>
    public class siwangtaolunshixiaoCommand : AbstractCommand
    {
        public siwangtaolunshixiaoCommand()
        {
            this.m_name = "新军卫-缺死亡病例讨论记录";
        }
        public override bool Execute(object param, object data, out object result)
        {
            QcCheckPoint qcCheckPoint = param as QcCheckPoint;
            PatVisitInfo patVisitLog = data as PatVisitInfo;
            result = CheckPointHelper.Instance.InitQcCheckResult(qcCheckPoint, patVisitLog);

            QcCheckResult qcCheckResult = result as QcCheckResult;
            string szPeriodDesc = string.Empty;
            //通过时效帮助类，创建一张病历正常书写的用于比对的时效检查时间表
            List<TimeCheckResult> lstTimeCheckResults = TimeCheckHelper.Instance.CreateTimeCheckTable(qcCheckPoint, patVisitLog);
            if (lstTimeCheckResults == null || lstTimeCheckResults.Count <= 0)
            {
                qcCheckResult.QC_EXPLAIN = "规则通过";
                qcCheckResult.QC_RESULT = 1;
                return true;
            }
            DateTime dtEndTime = lstTimeCheckResults[0].EndTime;
            DateTime dtStartTime = lstTimeCheckResults[0].StartTime;
            //查询患者指定文书类型ID号
            List<MedDocInfo> documentlist = TimeCheckHelper.Instance.GetDocumentList(qcCheckPoint.DocTypeID, patVisitLog.MedDocInfos);
            if (documentlist == null || documentlist.Count == 0)
            {
                if (dtEndTime > DateTime.Now)
                {
                    qcCheckResult.QC_EXPLAIN = "死亡病例讨论记录期限未到";
                    qcCheckResult.QC_RESULT = 1;
                    return true;
                }
                qcCheckResult.QC_EXPLAIN = "期限已到,未写死亡病例讨论记录";
                qcCheckResult.QC_RESULT = 0;
                qcCheckResult.ERROR_COUNT = 1;
                return true;
            }
            qcCheckResult.DOC_SETID = documentlist[0].DOC_SETID;
            qcCheckResult.DOC_TITLE = documentlist[0].DOC_TITLE;
            qcCheckResult.DOCTYPE_ID = documentlist[0].DOC_TYPE;
            qcCheckResult.DOC_TIME = documentlist[0].DOC_TIME;
            qcCheckResult.DOC_SETID = documentlist[0].DOC_SETID;
            qcCheckResult.MODIFY_TIME = documentlist[0].MODIFY_TIME;
            qcCheckResult.CREATE_ID = documentlist[0].CREATOR_ID;
            qcCheckResult.CREATE_NAME = documentlist[0].CREATOR_NAME;

            if (documentlist[0].DOC_TIME > dtEndTime)
            {
                qcCheckResult.QC_RESULT = 0;
                qcCheckResult.QC_EXPLAIN = string.Format("患者{0}下达死亡医嘱，书写{1}时间{2},截止时间{3},结果超时"
                    , dtStartTime.ToString("yyyy-MM-dd HH:mm")
                    , documentlist[0].DOC_TITLE
                    , documentlist[0].DOC_TIME.ToString()
                    , dtEndTime.ToString("yyyy-MM-dd HH:mm")
                    );
                qcCheckResult.ERROR_COUNT = 1;
                return true;
            }
            qcCheckResult.QC_RESULT = 1;
            qcCheckResult.QC_EXPLAIN = string.Format("患者{0}下达死亡医嘱，书写{1}时间{2},截止时间{3},结果正常"
               , dtStartTime.ToString("yyyy-MM-dd HH:mm")
                    , documentlist[0].DOC_TITLE
                    , documentlist[0].DOC_TIME.ToString()
                    , dtEndTime.ToString("yyyy-MM-dd HH:mm")
                );

            qcCheckResult.QC_EXPLAIN = "规则通过";
            qcCheckResult.QC_RESULT = 1;
            return true;
        }
    }
}
