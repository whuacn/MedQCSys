namespace Heren.MedQC.MedRecord
{
    partial class OutPatientStatisticForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_ORDER_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BED_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChargeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MEDICAL_GROUP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DRUG_COST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVisitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDischargeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransferTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_INDAYS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ARCHIVE_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboDeptName = new Heren.Common.Controls.DictInput.FindComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStatTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.dtpStatTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.btnWarningArchive = new System.Windows.Forms.Button();
            this.btnArchiveTime = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPatientID = new Heren.Common.Forms.XTextBox();
            this.xLabel3 = new Heren.Common.Forms.XLabel();
            this.lblTransferCount = new System.Windows.Forms.Label();
            this.lblOutPatientCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ORDER_NO,
            this.col_BED_CODE,
            this.colPatientName,
            this.colPatientID,
            this.colPatSex,
            this.colAge,
            this.colChargeType,
            this.colRequestDoc,
            this.col_MEDICAL_GROUP,
            this.colDeptName,
            this.colCost,
            this.col_DRUG_COST,
            this.colVisitTime,
            this.colDischargeTime,
            this.colTransferTime,
            this.col_INDAYS,
            this.col_ARCHIVE_TIME});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 386);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // col_ORDER_NO
            // 
            this.col_ORDER_NO.HeaderText = "序";
            this.col_ORDER_NO.Name = "col_ORDER_NO";
            this.col_ORDER_NO.Width = 30;
            // 
            // col_BED_CODE
            // 
            this.col_BED_CODE.HeaderText = "床位";
            this.col_BED_CODE.Name = "col_BED_CODE";
            this.col_BED_CODE.Width = 60;
            // 
            // colPatientName
            // 
            this.colPatientName.HeaderText = "姓名";
            this.colPatientName.Name = "colPatientName";
            this.colPatientName.Width = 90;
            // 
            // colPatientID
            // 
            this.colPatientID.HeaderText = "患者ID号";
            this.colPatientID.Name = "colPatientID";
            // 
            // colPatSex
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colPatSex.DefaultCellStyle = dataGridViewCellStyle2;
            this.colPatSex.HeaderText = "性别";
            this.colPatSex.Name = "colPatSex";
            this.colPatSex.Width = 60;
            // 
            // colAge
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colAge.DefaultCellStyle = dataGridViewCellStyle3;
            this.colAge.HeaderText = "年龄";
            this.colAge.Name = "colAge";
            this.colAge.ReadOnly = true;
            this.colAge.Width = 60;
            // 
            // colChargeType
            // 
            this.colChargeType.HeaderText = "费用类别";
            this.colChargeType.Name = "colChargeType";
            this.colChargeType.Width = 90;
            // 
            // colRequestDoc
            // 
            this.colRequestDoc.HeaderText = "经治医生";
            this.colRequestDoc.Name = "colRequestDoc";
            this.colRequestDoc.Width = 90;
            // 
            // col_MEDICAL_GROUP
            // 
            this.col_MEDICAL_GROUP.HeaderText = "医疗组";
            this.col_MEDICAL_GROUP.Name = "col_MEDICAL_GROUP";
            // 
            // colDeptName
            // 
            this.colDeptName.HeaderText = "出院科室";
            this.colDeptName.Name = "colDeptName";
            this.colDeptName.Width = 140;
            // 
            // colCost
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colCost.DefaultCellStyle = dataGridViewCellStyle4;
            this.colCost.HeaderText = "总费用";
            this.colCost.Name = "colCost";
            this.colCost.ReadOnly = true;
            this.colCost.Width = 90;
            // 
            // col_DRUG_COST
            // 
            this.col_DRUG_COST.HeaderText = "药品费用";
            this.col_DRUG_COST.Name = "col_DRUG_COST";
            // 
            // colVisitTime
            // 
            this.colVisitTime.HeaderText = "入院日期";
            this.colVisitTime.Name = "colVisitTime";
            this.colVisitTime.Width = 90;
            // 
            // colDischargeTime
            // 
            this.colDischargeTime.HeaderText = "出院日期";
            this.colDischargeTime.Name = "colDischargeTime";
            this.colDischargeTime.Width = 90;
            // 
            // colTransferTime
            // 
            this.colTransferTime.HeaderText = "转科日期";
            this.colTransferTime.Name = "colTransferTime";
            this.colTransferTime.Width = 120;
            // 
            // col_INDAYS
            // 
            this.col_INDAYS.HeaderText = "在科天数";
            this.col_INDAYS.Name = "col_INDAYS";
            this.col_INDAYS.Width = 90;
            // 
            // col_ARCHIVE_TIME
            // 
            this.col_ARCHIVE_TIME.HeaderText = "取消日期";
            this.col_ARCHIVE_TIME.Name = "col_ARCHIVE_TIME";
            this.col_ARCHIVE_TIME.Width = 120;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboDeptName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnExportExcel);
            this.panel1.Controls.Add(this.dtpStatTimeBegin);
            this.panel1.Controls.Add(this.dtpStatTimeEnd);
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 38);
            this.panel1.TabIndex = 10;
            // 
            // cboDeptName
            // 
            this.cboDeptName.CandidateWidth = 200;
            this.cboDeptName.Font = new System.Drawing.Font("宋体", 10.5F);
            this.cboDeptName.Location = new System.Drawing.Point(435, 7);
            this.cboDeptName.Name = "cboDeptName";
            this.cboDeptName.Size = new System.Drawing.Size(129, 23);
            this.cboDeptName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label3.Location = new System.Drawing.Point(208, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "至";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label1.Location = new System.Drawing.Point(368, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "出院科室";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "出院日期";
            // 
            // dtpStatTimeBegin
            // 
            this.dtpStatTimeBegin.Font = new System.Drawing.Font("宋体", 10.5F);
            this.dtpStatTimeBegin.Location = new System.Drawing.Point(81, 5);
            this.dtpStatTimeBegin.Name = "dtpStatTimeBegin";
            this.dtpStatTimeBegin.Size = new System.Drawing.Size(121, 23);
            this.dtpStatTimeBegin.TabIndex = 4;
            // 
            // dtpStatTimeEnd
            // 
            this.dtpStatTimeEnd.Font = new System.Drawing.Font("宋体", 10.5F);
            this.dtpStatTimeEnd.Location = new System.Drawing.Point(235, 6);
            this.dtpStatTimeEnd.Name = "dtpStatTimeEnd";
            this.dtpStatTimeEnd.Size = new System.Drawing.Size(121, 23);
            this.dtpStatTimeEnd.TabIndex = 6;
            // 
            // btnWarningArchive
            // 
            this.btnWarningArchive.Font = new System.Drawing.Font("宋体", 10.5F);
            this.btnWarningArchive.Location = new System.Drawing.Point(570, 1);
            this.btnWarningArchive.Name = "btnWarningArchive";
            this.btnWarningArchive.Size = new System.Drawing.Size(65, 28);
            this.btnWarningArchive.TabIndex = 7;
            this.btnWarningArchive.Text = "催送(&C)";
            this.btnWarningArchive.UseVisualStyleBackColor = true;
            this.btnWarningArchive.Click += new System.EventHandler(this.btnWarningArchive_Click);
            // 
            // btnArchiveTime
            // 
            this.btnArchiveTime.Font = new System.Drawing.Font("宋体", 10.5F);
            this.btnArchiveTime.Location = new System.Drawing.Point(641, 2);
            this.btnArchiveTime.Name = "btnArchiveTime";
            this.btnArchiveTime.Size = new System.Drawing.Size(96, 28);
            this.btnArchiveTime.TabIndex = 7;
            this.btnArchiveTime.Text = "取消催送(&X)";
            this.btnArchiveTime.UseVisualStyleBackColor = true;
            this.btnArchiveTime.Click += new System.EventHandler(this.btnArchiveTime_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("宋体", 10.5F);
            this.btnPrint.Location = new System.Drawing.Point(743, 1);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(65, 28);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(641, 7);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(78, 28);
            this.btnExportExcel.TabIndex = 8;
            this.btnExportExcel.Text = "Excel导出";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("宋体", 10.5F);
            this.btnQuery.Location = new System.Drawing.Point(570, 6);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(65, 28);
            this.btnQuery.TabIndex = 7;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPatientID);
            this.panel2.Controls.Add(this.xLabel3);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.lblTransferCount);
            this.panel2.Controls.Add(this.lblOutPatientCount);
            this.panel2.Controls.Add(this.btnWarningArchive);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnArchiveTime);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 30);
            this.panel2.TabIndex = 11;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPatientID.Location = new System.Drawing.Point(435, 4);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(127, 23);
            this.txtPatientID.TabIndex = 9;
            // 
            // xLabel3
            // 
            this.xLabel3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xLabel3.Location = new System.Drawing.Point(365, 9);
            this.xLabel3.Name = "xLabel3";
            this.xLabel3.Size = new System.Drawing.Size(77, 14);
            this.xLabel3.TabIndex = 8;
            this.xLabel3.Text = "患者ID号：";
            // 
            // lblTransferCount
            // 
            this.lblTransferCount.AutoSize = true;
            this.lblTransferCount.Font = new System.Drawing.Font("宋体", 10.5F);
            this.lblTransferCount.Location = new System.Drawing.Point(231, 6);
            this.lblTransferCount.Name = "lblTransferCount";
            this.lblTransferCount.Size = new System.Drawing.Size(14, 14);
            this.lblTransferCount.TabIndex = 3;
            this.lblTransferCount.Text = "0";
            // 
            // lblOutPatientCount
            // 
            this.lblOutPatientCount.AutoSize = true;
            this.lblOutPatientCount.Font = new System.Drawing.Font("宋体", 10.5F);
            this.lblOutPatientCount.Location = new System.Drawing.Point(95, 6);
            this.lblOutPatientCount.Name = "lblOutPatientCount";
            this.lblOutPatientCount.Size = new System.Drawing.Size(14, 14);
            this.lblOutPatientCount.TabIndex = 3;
            this.lblOutPatientCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label5.Location = new System.Drawing.Point(148, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 3;
            this.label5.Text = "转科人次：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label4.Location = new System.Drawing.Point(12, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "出院人次：";
            // 
            // OutPatientStatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 454);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "OutPatientStatisticForm";
            this.Text = "出院人数统计";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private Heren.Common.Controls.DictInput.FindComboBox cboDeptName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStatTimeBegin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStatTimeEnd;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOutPatientCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTransferCount;
        private System.Windows.Forms.Button btnWarningArchive;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ORDER_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BED_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChargeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MEDICAL_GROUP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DRUG_COST;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVisitTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDischargeTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransferTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_INDAYS;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ARCHIVE_TIME;
        private System.Windows.Forms.Button btnArchiveTime;
        private Common.Forms.XTextBox txtPatientID;
        private Common.Forms.XLabel xLabel3;
    }
}