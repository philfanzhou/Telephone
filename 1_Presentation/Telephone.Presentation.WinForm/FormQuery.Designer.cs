namespace Telephone.Presentation.WinForm
{
    partial class FormQuery
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtStockCode = new System.Windows.Forms.TextBox();
            this.dtpBgnDate = new System.Windows.Forms.DateTimePicker();
            this.lbBgnDate = new System.Windows.Forms.Label();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbAlarm = new System.Windows.Forms.Label();
            this.dtpBgnTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "股票代码：";
            // 
            // txtStockCode
            // 
            this.txtStockCode.Location = new System.Drawing.Point(127, 49);
            this.txtStockCode.Name = "txtStockCode";
            this.txtStockCode.Size = new System.Drawing.Size(244, 21);
            this.txtStockCode.TabIndex = 1;
            // 
            // dtpBgnDate
            // 
            this.dtpBgnDate.Location = new System.Drawing.Point(127, 86);
            this.dtpBgnDate.Name = "dtpBgnDate";
            this.dtpBgnDate.Size = new System.Drawing.Size(135, 21);
            this.dtpBgnDate.TabIndex = 2;
            // 
            // lbBgnDate
            // 
            this.lbBgnDate.AutoSize = true;
            this.lbBgnDate.Location = new System.Drawing.Point(62, 90);
            this.lbBgnDate.Name = "lbBgnDate";
            this.lbBgnDate.Size = new System.Drawing.Size(65, 12);
            this.lbBgnDate.TabIndex = 3;
            this.lbBgnDate.Text = "开始时间：";
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(62, 125);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(65, 12);
            this.lbEndDate.TabIndex = 4;
            this.lbEndDate.Text = "结束时间：";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(127, 121);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(135, 21);
            this.dtpEndDate.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(127, 169);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(255, 169);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbAlarm
            // 
            this.lbAlarm.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbAlarm.Location = new System.Drawing.Point(10, 10);
            this.lbAlarm.Name = "lbAlarm";
            this.lbAlarm.Size = new System.Drawing.Size(435, 12);
            this.lbAlarm.TabIndex = 8;
            this.lbAlarm.Text = "Alarm Message";
            this.lbAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAlarm.Visible = false;
            // 
            // dtpBgnTime
            // 
            this.dtpBgnTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpBgnTime.Location = new System.Drawing.Point(268, 86);
            this.dtpBgnTime.Name = "dtpBgnTime";
            this.dtpBgnTime.ShowUpDown = true;
            this.dtpBgnTime.Size = new System.Drawing.Size(103, 21);
            this.dtpBgnTime.TabIndex = 9;
            this.dtpBgnTime.Value = new System.DateTime(2016, 2, 22, 9, 0, 0, 0);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(268, 121);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(103, 21);
            this.dtpEndTime.TabIndex = 9;
            this.dtpEndTime.Value = new System.DateTime(2016, 2, 22, 15, 0, 0, 0);
            // 
            // FormQuery
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(455, 214);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpBgnTime);
            this.Controls.Add(this.lbAlarm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lbEndDate);
            this.Controls.Add(this.lbBgnDate);
            this.Controls.Add(this.dtpBgnDate);
            this.Controls.Add(this.txtStockCode);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQuery";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "查询条件";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormQuery_FormClosed);
            this.Load += new System.EventHandler(this.FormQuery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStockCode;
        private System.Windows.Forms.DateTimePicker dtpBgnDate;
        private System.Windows.Forms.Label lbBgnDate;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbAlarm;
        private System.Windows.Forms.DateTimePicker dtpBgnTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
    }
}