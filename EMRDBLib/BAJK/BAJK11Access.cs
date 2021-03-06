// ***********************************************************
// 数据库访问层通用操作有关的数据访问接口.
// Creator:YangMingkun  Date:2010-11-18
// Copyright:supconhealth
// ***********************************************************
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Heren.Common.Libraries;
using Heren.Common.Libraries.DbAccess;
using EMRDBLib.DbAccess;
using EMRDBLib.BAJK;
using System.Reflection;

namespace EMRDBLib
{
    /// <summary>
    /// 手术情况
    /// </summary>
    public class BAJK11Access : DBAccessBase
    {
        public const string TableName = SystemData.DataTable_BAJK.BAJK11;
        private static BAJK11Access m_Instance = null;

        /// <summary>
        /// 获取系统运行上下文实例
        /// </summary>
        public static BAJK11Access Instance
        {
            get
            {
                if (m_Instance == null)
                    m_Instance = new BAJK11Access();
                return m_Instance;
            }
        }

        public short GetBAJK11s(decimal brxh, ref List<BAJK11> lstBAJK11s)
        {
            if (base.BAJKDataAccess == null)
                return SystemData.ReturnValue.PARAM_ERROR;
            StringBuilder sbField = new StringBuilder();
            sbField.AppendFormat("*");
            string szCondition = string.Format("1=1");
            szCondition = string.Format("{0} AND {1} = {2} "
                , szCondition
                , SystemData.BAJK11Table.KEY1101
                , brxh);
            string szSQL = string.Format(SystemData.SQL.SELECT_WHERE
                    , sbField.ToString(), TableName, szCondition);
            IDataReader dataReader = null;
            try
            {
                dataReader = base.BAJKDataAccess.ExecuteReader(szSQL, CommandType.Text);
                if (dataReader == null || dataReader.IsClosed || !dataReader.Read())
                {
                    return SystemData.ReturnValue.RES_NO_FOUND;
                }
                if (lstBAJK11s == null)
                    lstBAJK11s = new List<BAJK11>();
                do
                {
                    BAJK11 BAJK11 = new BAJK11();
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        if (dataReader.IsDBNull(i))
                            continue;
                        PropertyInfo property = Reflect.GetPropertyInfo(typeof(BAJK11), dataReader.GetName(i));
                        bool result = Reflect.SetPropertyValue(BAJK11, property, dataReader.GetValue(i));
                    }
                    lstBAJK11s.Add(BAJK11);
                } while (dataReader.Read());
                return SystemData.ReturnValue.OK;
            }
            catch (Exception ex)
            {
                LogManager.Instance.WriteLog("", new string[] { "szSQL" }, new object[] { szSQL
}, ex);
                return SystemData.ReturnValue.EXCEPTION;
            }
            finally { base.BAJKDataAccess.CloseConnnection(false); }
        }

        public short Insert(BAJK11 model)
        {
            if (model == null)
            {
                LogManager.Instance.WriteLog("", new string[] { "" }
                    , new object[] { model }, "参数不能为空");
                return SystemData.ReturnValue.PARAM_ERROR;
            }
            if (model.KEY1101 == 0 || model.KEY1102 == 0)
            {
                return SystemData.ReturnValue.EXCEPTION;
            }
            StringBuilder sbField = new StringBuilder();
            StringBuilder sbValue = new StringBuilder();
            PropertyInfo[] PropertyList = Reflect.GetProperties<BAJK11>(model);
            foreach (var item in PropertyList)
            {
                string name = item.Name;
                object value = item.GetValue(model, null);

                switch (item.PropertyType.Name)
                {
                    case "Decimal":
                        sbField.AppendFormat("{0},", name);
                        sbValue.AppendFormat("{0},", value);
                        break;
                    case "DateTime":
                        DateTime dt = DateTime.Parse(value.ToString());
                        if (dt == model.DefaultTime || dt == model.DefaultTime2
                            || dt == model.DefaultTime3)
                            break;
                        sbField.AppendFormat("{0},", name);
                        sbValue.AppendFormat("{0},", base.BAJKDataAccess.GetSqlTimeFormat(dt));
                        break;
                    default:
                        sbField.AppendFormat("{0},", name);
                        sbValue.AppendFormat("'{0}',", value);
                        break;
                }
            }
            string szField = sbField.ToString().Substring(0, sbField.Length - 1);
            string szValue = sbValue.ToString().Substring(0, sbValue.Length - 1);
            string szSQL = string.Format(SystemData.SQL.INSERT
                , SystemData.DataTable_BAJK.BAJK11
                , szField
                , szValue);
            int nCount = 0;
            try
            {
                nCount = base.BAJKDataAccess.ExecuteNonQuery(szSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                LogManager.Instance.WriteLog("", new string[] { "szSQL" }, new object[] { szSQL }, ex);
                return SystemData.ReturnValue.EXCEPTION;
            }
            if (nCount <= 0)
            {
                LogManager.Instance.WriteLog("", new string[] { "szSQL" }, new object[] { szSQL }, "SQL语句执行后返回0!");
                return SystemData.ReturnValue.EXCEPTION;
            }
            return SystemData.ReturnValue.OK;
        }
        /// <summary>
        /// 清除患者所有已上传的手术情况
        /// </summary>
        /// <param name="brxh"></param>
        /// <returns></returns>
        public short Delete(decimal brxh)
        {
            if (base.BAJKDataAccess == null)
                return SystemData.ReturnValue.PARAM_ERROR;

            if (GlobalMethods.Misc.IsEmptyString(brxh))
            {
                LogManager.Instance.WriteLog("", new string[] { "" }
                    , new object[] { brxh }, "参数不能为空");
                return SystemData.ReturnValue.PARAM_ERROR;
            }

            string szCondition = string.Format("{0}={1}", SystemData.BAJK11Table.KEY1101, brxh);
            string szSQL = string.Format(SystemData.SQL.DELETE, TableName, szCondition);
            int nCount = 0;
            try
            {
                nCount = base.BAJKDataAccess.ExecuteNonQuery(szSQL, CommandType.Text);
            }
            catch (Exception ex)
            {
                LogManager.Instance.WriteLog("", new string[] { "szSQL" }, new object[] { szSQL }, ex);
                return SystemData.ReturnValue.EXCEPTION;
            }
            if (nCount <= 0)
            {
                LogManager.Instance.WriteLog("", new string[] { "szSQL" }, new object[] { szSQL }, "SQL语句执行后返回0!");
                return SystemData.ReturnValue.EXCEPTION;
            }
            return SystemData.ReturnValue.OK;
        }
    }
}
