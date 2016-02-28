namespace Telephone.Presentation.WinForm
{
    partial class FormAccount
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTotalAssets = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbPrincipal = new System.Windows.Forms.Label();
            this.lbMarketValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmBuy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSell = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHoldings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTradingRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHoldingsRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHoldingsAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHoldingsSpecified = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslMessages = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsmTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTransferIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTransferOut = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(16, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbTotalAssets, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbBalance, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbPrincipal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbMarketValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(582, 64);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lbTotalAssets
            // 
            this.lbTotalAssets.AutoSize = true;
            this.lbTotalAssets.Location = new System.Drawing.Point(3, 32);
            this.lbTotalAssets.Name = "lbTotalAssets";
            this.lbTotalAssets.Size = new System.Drawing.Size(53, 12);
            this.lbTotalAssets.TabIndex = 0;
            this.lbTotalAssets.Text = "总资产：";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Location = new System.Drawing.Point(235, 0);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(41, 12);
            this.lbBalance.TabIndex = 0;
            this.lbBalance.Text = "余额：";
            // 
            // lbPrincipal
            // 
            this.lbPrincipal.AutoSize = true;
            this.lbPrincipal.Location = new System.Drawing.Point(3, 0);
            this.lbPrincipal.Name = "lbPrincipal";
            this.lbPrincipal.Size = new System.Drawing.Size(41, 12);
            this.lbPrincipal.TabIndex = 0;
            this.lbPrincipal.Text = "本金：";
            // 
            // lbMarketValue
            // 
            this.lbMarketValue.AutoSize = true;
            this.lbMarketValue.Location = new System.Drawing.Point(235, 32);
            this.lbMarketValue.Name = "lbMarketValue";
            this.lbMarketValue.Size = new System.Drawing.Size(53, 12);
            this.lbMarketValue.TabIndex = 0;
            this.lbMarketValue.Text = "总市值：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "浮动盈亏：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(16, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 214);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(588, 214);
            this.dataGridView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBuy,
            this.tsmSell,
            this.tsmHoldings,
            this.tsmQuery});
            this.menuStrip1.Location = new System.Drawing.Point(16, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmBuy
            // 
            this.tsmBuy.Name = "tsmBuy";
            this.tsmBuy.Size = new System.Drawing.Size(44, 21);
            this.tsmBuy.Text = "买入";
            this.tsmBuy.Click += new System.EventHandler(this.tsmBuy_Click);
            // 
            // tsmSell
            // 
            this.tsmSell.Name = "tsmSell";
            this.tsmSell.Size = new System.Drawing.Size(44, 21);
            this.tsmSell.Text = "卖出";
            this.tsmSell.Click += new System.EventHandler(this.tsmSell_Click);
            // 
            // tsmHoldings
            // 
            this.tsmHoldings.Name = "tsmHoldings";
            this.tsmHoldings.Size = new System.Drawing.Size(44, 21);
            this.tsmHoldings.Text = "持仓";
            this.tsmHoldings.Click += new System.EventHandler(this.tsmHoldings_Click);
            // 
            // tsmQuery
            // 
            this.tsmQuery.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTransfer,
            this.tsmTradingRecord,
            this.tsmHoldingsRecord});
            this.tsmQuery.Name = "tsmQuery";
            this.tsmQuery.Size = new System.Drawing.Size(44, 21);
            this.tsmQuery.Text = "查询";
            // 
            // tsmTradingRecord
            // 
            this.tsmTradingRecord.Name = "tsmTradingRecord";
            this.tsmTradingRecord.Size = new System.Drawing.Size(152, 22);
            this.tsmTradingRecord.Text = "交易记录";
            this.tsmTradingRecord.Click += new System.EventHandler(this.tsmTradingRecord_Click);
            // 
            // tsmHoldingsRecord
            // 
            this.tsmHoldingsRecord.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmHoldingsAll,
            this.tsmHoldingsSpecified});
            this.tsmHoldingsRecord.Name = "tsmHoldingsRecord";
            this.tsmHoldingsRecord.Size = new System.Drawing.Size(152, 22);
            this.tsmHoldingsRecord.Text = "持仓记录";
            // 
            // tsmHoldingsAll
            // 
            this.tsmHoldingsAll.Name = "tsmHoldingsAll";
            this.tsmHoldingsAll.Size = new System.Drawing.Size(100, 22);
            this.tsmHoldingsAll.Text = "所有";
            this.tsmHoldingsAll.Click += new System.EventHandler(this.tsmHoldingsAll_Click);
            // 
            // tsmHoldingsSpecified
            // 
            this.tsmHoldingsSpecified.Name = "tsmHoldingsSpecified";
            this.tsmHoldingsSpecified.Size = new System.Drawing.Size(100, 22);
            this.tsmHoldingsSpecified.Text = "指定";
            this.tsmHoldingsSpecified.Click += new System.EventHandler(this.tsmHoldingsSpecified_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMessages});
            this.statusStrip1.Location = new System.Drawing.Point(16, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(588, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslMessages
            // 
            this.tsslMessages.Name = "tsslMessages";
            this.tsslMessages.Size = new System.Drawing.Size(86, 17);
            this.tsslMessages.Text = "tsslMessages";
            // 
            // tsmTransfer
            // 
            this.tsmTransfer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTransferIn,
            this.tsmTransferOut});
            this.tsmTransfer.Name = "tsmTransfer";
            this.tsmTransfer.Size = new System.Drawing.Size(152, 22);
            this.tsmTransfer.Text = "转账";
            // 
            // tsmTransferIn
            // 
            this.tsmTransferIn.Name = "tsmTransferIn";
            this.tsmTransferIn.Size = new System.Drawing.Size(152, 22);
            this.tsmTransferIn.Text = "银行转券商";
            this.tsmTransferIn.Click += new System.EventHandler(this.tsmTransferIn_Click);
            // 
            // tsmTransferOut
            // 
            this.tsmTransferOut.Name = "tsmTransferOut";
            this.tsmTransferOut.Size = new System.Drawing.Size(152, 22);
            this.tsmTransferOut.Text = "券商转银行";
            this.tsmTransferOut.Click += new System.EventHandler(this.tsmTransferOut_Click);
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 377);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAccount";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAccount";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAccount_FormClosed);
            this.Load += new System.EventHandler(this.FormAccount_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbPrincipal;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbMarketValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotalAssets;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmBuy;
        private System.Windows.Forms.ToolStripMenuItem tsmSell;
        private System.Windows.Forms.ToolStripMenuItem tsmHoldings;
        private System.Windows.Forms.ToolStripMenuItem tsmQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmTradingRecord;
        private System.Windows.Forms.ToolStripMenuItem tsmHoldingsRecord;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem tsmHoldingsAll;
        private System.Windows.Forms.ToolStripMenuItem tsmHoldingsSpecified;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslMessages;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem tsmTransferOut;
        private System.Windows.Forms.ToolStripMenuItem tsmTransferIn;
        private System.Windows.Forms.ToolStripMenuItem tsmTransfer;
    }
}