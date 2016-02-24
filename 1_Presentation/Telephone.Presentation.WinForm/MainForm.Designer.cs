namespace Telephone.Presentation.WinForm
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStripSys = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmSysStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCleanup = new System.Windows.Forms.ToolStripMenuItem();
            this.实时数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRealTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTimeShare = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKLine = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKLineDay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKLineWeek = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKLineMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKLineQuarter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKLineYear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKLineMin1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKLineMin5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKLineMin15 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKLineMin30 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKLineMin60 = new System.Windows.Forms.ToolStripMenuItem();
            this.基本面数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAllSecurity = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmBasicInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStockStructure = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDividendDistribution = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmParticipation = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripSys = new System.Windows.Forms.StatusStrip();
            this.tsslSrvStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCurrent = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSysTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerSys = new System.Windows.Forms.Timer(this.components);
            this.图表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.蜡炬图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStripSys.SuspendLayout();
            this.statusStripSys.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 25);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(774, 397);
            this.dataGridView.TabIndex = 1;
            // 
            // menuStripSys
            // 
            this.menuStripSys.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.实时数据ToolStripMenuItem,
            this.基本面数据ToolStripMenuItem,
            this.图表ToolStripMenuItem});
            this.menuStripSys.Location = new System.Drawing.Point(0, 0);
            this.menuStripSys.Name = "menuStripSys";
            this.menuStripSys.Size = new System.Drawing.Size(774, 25);
            this.menuStripSys.TabIndex = 3;
            this.menuStripSys.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSetup,
            this.toolStripSeparator1,
            this.tsmSysStatus,
            this.tsmCleanup});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // tsmSetup
            // 
            this.tsmSetup.Name = "tsmSetup";
            this.tsmSetup.Size = new System.Drawing.Size(100, 22);
            this.tsmSetup.Text = "设置";
            this.tsmSetup.Click += new System.EventHandler(this.tsmSetup_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
            // 
            // tsmSysStatus
            // 
            this.tsmSysStatus.Name = "tsmSysStatus";
            this.tsmSysStatus.Size = new System.Drawing.Size(100, 22);
            this.tsmSysStatus.Text = "状态";
            this.tsmSysStatus.Click += new System.EventHandler(this.tsmSysStatus_Click);
            // 
            // tsmCleanup
            // 
            this.tsmCleanup.Name = "tsmCleanup";
            this.tsmCleanup.Size = new System.Drawing.Size(100, 22);
            this.tsmCleanup.Text = "清空";
            this.tsmCleanup.Click += new System.EventHandler(this.tsmCleanup_Click);
            // 
            // 实时数据ToolStripMenuItem
            // 
            this.实时数据ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRealTime,
            this.tsmTimeShare,
            this.tsmKLine});
            this.实时数据ToolStripMenuItem.Name = "实时数据ToolStripMenuItem";
            this.实时数据ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.实时数据ToolStripMenuItem.Text = "实时数据";
            // 
            // tsmRealTime
            // 
            this.tsmRealTime.Name = "tsmRealTime";
            this.tsmRealTime.Size = new System.Drawing.Size(152, 22);
            this.tsmRealTime.Text = "实时";
            this.tsmRealTime.Click += new System.EventHandler(this.tsmRealTime_Click);
            // 
            // tsmTimeShare
            // 
            this.tsmTimeShare.Name = "tsmTimeShare";
            this.tsmTimeShare.Size = new System.Drawing.Size(152, 22);
            this.tsmTimeShare.Text = "分时";
            this.tsmTimeShare.Click += new System.EventHandler(this.tsmTimeShare_Click);
            // 
            // tsmKLine
            // 
            this.tsmKLine.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmKLineDay,
            this.tsmKLineWeek,
            this.tsmKLineMonth,
            this.tsmKLineQuarter,
            this.tsmKLineYear,
            this.tsmKLineMin1,
            this.tsmKLineMin5,
            this.tsmKLineMin15,
            this.tsmKLineMin30,
            this.tsmKLineMin60});
            this.tsmKLine.Name = "tsmKLine";
            this.tsmKLine.Size = new System.Drawing.Size(152, 22);
            this.tsmKLine.Text = "K线";
            // 
            // tsmKLineDay
            // 
            this.tsmKLineDay.Name = "tsmKLineDay";
            this.tsmKLineDay.Size = new System.Drawing.Size(126, 22);
            this.tsmKLineDay.Text = "日线";
            this.tsmKLineDay.Click += new System.EventHandler(this.tsmKLineDay_Click);
            // 
            // tsmKLineWeek
            // 
            this.tsmKLineWeek.Name = "tsmKLineWeek";
            this.tsmKLineWeek.Size = new System.Drawing.Size(126, 22);
            this.tsmKLineWeek.Text = "周线";
            this.tsmKLineWeek.Click += new System.EventHandler(this.tsmKLineWeek_Click);
            // 
            // tsmKLineMonth
            // 
            this.tsmKLineMonth.Name = "tsmKLineMonth";
            this.tsmKLineMonth.Size = new System.Drawing.Size(126, 22);
            this.tsmKLineMonth.Text = "月线";
            this.tsmKLineMonth.Click += new System.EventHandler(this.tsmKLineMonth_Click);
            // 
            // tsmKLineQuarter
            // 
            this.tsmKLineQuarter.Name = "tsmKLineQuarter";
            this.tsmKLineQuarter.Size = new System.Drawing.Size(126, 22);
            this.tsmKLineQuarter.Text = "季线";
            this.tsmKLineQuarter.Click += new System.EventHandler(this.tsmKLineQuarter_Click);
            // 
            // tsmKLineYear
            // 
            this.tsmKLineYear.Name = "tsmKLineYear";
            this.tsmKLineYear.Size = new System.Drawing.Size(126, 22);
            this.tsmKLineYear.Text = "年线";
            this.tsmKLineYear.Click += new System.EventHandler(this.tsmKLineYear_Click);
            // 
            // tsmKLineMin1
            // 
            this.tsmKLineMin1.Name = "tsmKLineMin1";
            this.tsmKLineMin1.Size = new System.Drawing.Size(126, 22);
            this.tsmKLineMin1.Text = "1分钟线";
            this.tsmKLineMin1.Click += new System.EventHandler(this.tsmKLineMin1_Click);
            // 
            // tsmKLineMin5
            // 
            this.tsmKLineMin5.Name = "tsmKLineMin5";
            this.tsmKLineMin5.Size = new System.Drawing.Size(126, 22);
            this.tsmKLineMin5.Text = "5分钟线";
            this.tsmKLineMin5.Click += new System.EventHandler(this.tsmKLineMin5_Click);
            // 
            // tsmKLineMin15
            // 
            this.tsmKLineMin15.Name = "tsmKLineMin15";
            this.tsmKLineMin15.Size = new System.Drawing.Size(126, 22);
            this.tsmKLineMin15.Text = "15分钟线";
            this.tsmKLineMin15.Click += new System.EventHandler(this.tsmKLineMin15_Click);
            // 
            // tsmKLineMin30
            // 
            this.tsmKLineMin30.Name = "tsmKLineMin30";
            this.tsmKLineMin30.Size = new System.Drawing.Size(126, 22);
            this.tsmKLineMin30.Text = "30分钟线";
            this.tsmKLineMin30.Click += new System.EventHandler(this.tsmKLineMin30_Click);
            // 
            // tsmKLineMin60
            // 
            this.tsmKLineMin60.Name = "tsmKLineMin60";
            this.tsmKLineMin60.Size = new System.Drawing.Size(126, 22);
            this.tsmKLineMin60.Text = "60分钟线";
            this.tsmKLineMin60.Click += new System.EventHandler(this.tsmKLineMin60_Click);
            // 
            // 基本面数据ToolStripMenuItem
            // 
            this.基本面数据ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAllSecurity,
            this.toolStripSeparator2,
            this.tsmBasicInfo,
            this.tsmStockStructure,
            this.tsmDividendDistribution,
            this.tsmParticipation});
            this.基本面数据ToolStripMenuItem.Name = "基本面数据ToolStripMenuItem";
            this.基本面数据ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.基本面数据ToolStripMenuItem.Text = "基本面数据";
            // 
            // tsmAllSecurity
            // 
            this.tsmAllSecurity.Name = "tsmAllSecurity";
            this.tsmAllSecurity.Size = new System.Drawing.Size(152, 22);
            this.tsmAllSecurity.Text = "所有证券";
            this.tsmAllSecurity.Click += new System.EventHandler(this.tsmAllSecurity_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmBasicInfo
            // 
            this.tsmBasicInfo.Name = "tsmBasicInfo";
            this.tsmBasicInfo.Size = new System.Drawing.Size(152, 22);
            this.tsmBasicInfo.Text = "基本信息";
            this.tsmBasicInfo.Click += new System.EventHandler(this.tsmBasicInfo_Click);
            // 
            // tsmStockStructure
            // 
            this.tsmStockStructure.Name = "tsmStockStructure";
            this.tsmStockStructure.Size = new System.Drawing.Size(152, 22);
            this.tsmStockStructure.Text = "股本结构";
            this.tsmStockStructure.Click += new System.EventHandler(this.tsmStockStructure_Click);
            // 
            // tsmDividendDistribution
            // 
            this.tsmDividendDistribution.Name = "tsmDividendDistribution";
            this.tsmDividendDistribution.Size = new System.Drawing.Size(152, 22);
            this.tsmDividendDistribution.Text = "分红分配";
            this.tsmDividendDistribution.Click += new System.EventHandler(this.tsmDividendDistribution_Click);
            // 
            // tsmParticipation
            // 
            this.tsmParticipation.Name = "tsmParticipation";
            this.tsmParticipation.Size = new System.Drawing.Size(152, 22);
            this.tsmParticipation.Text = "机构参与度";
            this.tsmParticipation.Click += new System.EventHandler(this.tsmParticipation_Click);
            // 
            // statusStripSys
            // 
            this.statusStripSys.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslSrvStatus,
            this.tsslCurrent,
            this.toolStripStatusLabel3,
            this.tsslSysTime});
            this.statusStripSys.Location = new System.Drawing.Point(0, 422);
            this.statusStripSys.Name = "statusStripSys";
            this.statusStripSys.Size = new System.Drawing.Size(774, 22);
            this.statusStripSys.TabIndex = 4;
            this.statusStripSys.Text = "statusStrip1";
            // 
            // tsslSrvStatus
            // 
            this.tsslSrvStatus.Name = "tsslSrvStatus";
            this.tsslSrvStatus.Size = new System.Drawing.Size(68, 17);
            this.tsslSrvStatus.Text = "服务状态：";
            // 
            // tsslCurrent
            // 
            this.tsslCurrent.Name = "tsslCurrent";
            this.tsslCurrent.Size = new System.Drawing.Size(68, 17);
            this.tsslCurrent.Text = "当前数据：";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(555, 17);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // tsslSysTime
            // 
            this.tsslSysTime.Name = "tsslSysTime";
            this.tsslSysTime.Size = new System.Drawing.Size(68, 17);
            this.tsslSysTime.Text = "系统时间：";
            // 
            // timerSys
            // 
            this.timerSys.Enabled = true;
            this.timerSys.Interval = 1000;
            this.timerSys.Tick += new System.EventHandler(this.timerSys_Tick);
            // 
            // 图表ToolStripMenuItem
            // 
            this.图表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.蜡炬图ToolStripMenuItem});
            this.图表ToolStripMenuItem.Name = "图表ToolStripMenuItem";
            this.图表ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.图表ToolStripMenuItem.Text = "图表";
            // 
            // 蜡炬图ToolStripMenuItem
            // 
            this.蜡炬图ToolStripMenuItem.Name = "蜡炬图ToolStripMenuItem";
            this.蜡炬图ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.蜡炬图ToolStripMenuItem.Text = "蜡炬图";
            this.蜡炬图ToolStripMenuItem.Click += new System.EventHandler(this.蜡炬图ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 444);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.statusStripSys);
            this.Controls.Add(this.menuStripSys);
            this.MainMenuStrip = this.menuStripSys;
            this.Name = "MainForm";
            this.Text = "Telephone";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStripSys.ResumeLayout(false);
            this.menuStripSys.PerformLayout();
            this.statusStripSys.ResumeLayout(false);
            this.statusStripSys.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MenuStrip menuStripSys;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSetup;
        private System.Windows.Forms.ToolStripMenuItem 实时数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmRealTime;
        private System.Windows.Forms.ToolStripMenuItem tsmTimeShare;
        private System.Windows.Forms.ToolStripMenuItem tsmKLine;
        private System.Windows.Forms.ToolStripMenuItem 基本面数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmBasicInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmStockStructure;
        private System.Windows.Forms.ToolStripMenuItem tsmDividendDistribution;
        private System.Windows.Forms.StatusStrip statusStripSys;
        private System.Windows.Forms.ToolStripStatusLabel tsslSrvStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslCurrent;
        private System.Windows.Forms.ToolStripMenuItem tsmCleanup;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tsslSysTime;
        private System.Windows.Forms.Timer timerSys;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmSysStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmAllSecurity;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmParticipation;
        private System.Windows.Forms.ToolStripMenuItem tsmKLineDay;
        private System.Windows.Forms.ToolStripMenuItem tsmKLineWeek;
        private System.Windows.Forms.ToolStripMenuItem tsmKLineMonth;
        private System.Windows.Forms.ToolStripMenuItem tsmKLineQuarter;
        private System.Windows.Forms.ToolStripMenuItem tsmKLineYear;
        private System.Windows.Forms.ToolStripMenuItem tsmKLineMin1;
        private System.Windows.Forms.ToolStripMenuItem tsmKLineMin5;
        private System.Windows.Forms.ToolStripMenuItem tsmKLineMin15;
        private System.Windows.Forms.ToolStripMenuItem tsmKLineMin30;
        private System.Windows.Forms.ToolStripMenuItem tsmKLineMin60;
        private System.Windows.Forms.ToolStripMenuItem 图表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 蜡炬图ToolStripMenuItem;
    }
}

