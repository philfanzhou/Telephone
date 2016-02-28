namespace Telephone.Presentation.WinForm
{
    partial class FormTrading
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
            this.txtMaxQuantity = new System.Windows.Forms.TextBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.txtStockCode = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbMaxQuantity = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbStockCode = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTrade = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSell5 = new System.Windows.Forms.Label();
            this.lbBuy5 = new System.Windows.Forms.Label();
            this.lbSell4 = new System.Windows.Forms.Label();
            this.lbBuy4 = new System.Windows.Forms.Label();
            this.lbSell3 = new System.Windows.Forms.Label();
            this.lbSell2 = new System.Windows.Forms.Label();
            this.lbBuy3 = new System.Windows.Forms.Label();
            this.lbSell1 = new System.Windows.Forms.Label();
            this.lbBuy2 = new System.Windows.Forms.Label();
            this.lbBuy1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbWarning = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaxQuantity);
            this.groupBox1.Controls.Add(this.numQuantity);
            this.groupBox1.Controls.Add(this.numPrice);
            this.groupBox1.Controls.Add(this.txtStockCode);
            this.groupBox1.Controls.Add(this.lbQuantity);
            this.groupBox1.Controls.Add(this.lbMaxQuantity);
            this.groupBox1.Controls.Add(this.lbPrice);
            this.groupBox1.Controls.Add(this.lbStockCode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtMaxQuantity
            // 
            this.txtMaxQuantity.Enabled = false;
            this.txtMaxQuantity.Location = new System.Drawing.Point(120, 78);
            this.txtMaxQuantity.Name = "txtMaxQuantity";
            this.txtMaxQuantity.Size = new System.Drawing.Size(120, 21);
            this.txtMaxQuantity.TabIndex = 4;
            this.txtMaxQuantity.TextChanged += new System.EventHandler(this.txtMaxQuantity_TextChanged);
            // 
            // numQuantity
            // 
            this.numQuantity.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numQuantity.Location = new System.Drawing.Point(120, 108);
            this.numQuantity.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 21);
            this.numQuantity.TabIndex = 3;
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numPrice.Location = new System.Drawing.Point(120, 48);
            this.numPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(120, 21);
            this.numPrice.TabIndex = 2;
            this.numPrice.ValueChanged += new System.EventHandler(this.numPrice_ValueChanged);
            // 
            // txtStockCode
            // 
            this.txtStockCode.Location = new System.Drawing.Point(120, 18);
            this.txtStockCode.Name = "txtStockCode";
            this.txtStockCode.Size = new System.Drawing.Size(120, 21);
            this.txtStockCode.TabIndex = 1;
            this.txtStockCode.TextChanged += new System.EventHandler(this.txtStockCode_TextChanged);
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(36, 112);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(65, 12);
            this.lbQuantity.TabIndex = 0;
            this.lbQuantity.Text = "买入数量：";
            // 
            // lbMaxQuantity
            // 
            this.lbMaxQuantity.AutoSize = true;
            this.lbMaxQuantity.Location = new System.Drawing.Point(36, 82);
            this.lbMaxQuantity.Name = "lbMaxQuantity";
            this.lbMaxQuantity.Size = new System.Drawing.Size(65, 12);
            this.lbMaxQuantity.TabIndex = 0;
            this.lbMaxQuantity.Text = "最大可买：";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(36, 52);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(65, 12);
            this.lbPrice.TabIndex = 0;
            this.lbPrice.Text = "买入价格：";
            // 
            // lbStockCode
            // 
            this.lbStockCode.AutoSize = true;
            this.lbStockCode.Location = new System.Drawing.Point(36, 22);
            this.lbStockCode.Name = "lbStockCode";
            this.lbStockCode.Size = new System.Drawing.Size(65, 12);
            this.lbStockCode.TabIndex = 0;
            this.lbStockCode.Text = "证券代码：";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(38, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTrade
            // 
            this.btnTrade.Location = new System.Drawing.Point(165, 10);
            this.btnTrade.Name = "btnTrade";
            this.btnTrade.Size = new System.Drawing.Size(75, 23);
            this.btnTrade.TabIndex = 0;
            this.btnTrade.Text = "下单";
            this.btnTrade.UseVisualStyleBackColor = true;
            this.btnTrade.Click += new System.EventHandler(this.btnTrade_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbSell5);
            this.panel1.Controls.Add(this.lbBuy5);
            this.panel1.Controls.Add(this.lbSell4);
            this.panel1.Controls.Add(this.lbBuy4);
            this.panel1.Controls.Add(this.lbSell3);
            this.panel1.Controls.Add(this.lbSell2);
            this.panel1.Controls.Add(this.lbBuy3);
            this.panel1.Controls.Add(this.lbSell1);
            this.panel1.Controls.Add(this.lbBuy2);
            this.panel1.Controls.Add(this.lbBuy1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(16, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 126);
            this.panel1.TabIndex = 1;
            // 
            // lbSell5
            // 
            this.lbSell5.AutoSize = true;
            this.lbSell5.Location = new System.Drawing.Point(163, 102);
            this.lbSell5.Name = "lbSell5";
            this.lbSell5.Size = new System.Drawing.Size(41, 12);
            this.lbSell5.TabIndex = 0;
            this.lbSell5.Text = "卖五：";
            this.lbSell5.Click += new System.EventHandler(this.lbPrice_Click);
            // 
            // lbBuy5
            // 
            this.lbBuy5.AutoSize = true;
            this.lbBuy5.Location = new System.Drawing.Point(36, 102);
            this.lbBuy5.Name = "lbBuy5";
            this.lbBuy5.Size = new System.Drawing.Size(41, 12);
            this.lbBuy5.TabIndex = 0;
            this.lbBuy5.Text = "买五：";
            this.lbBuy5.Click += new System.EventHandler(this.lbPrice_Click);
            // 
            // lbSell4
            // 
            this.lbSell4.AutoSize = true;
            this.lbSell4.Location = new System.Drawing.Point(163, 80);
            this.lbSell4.Name = "lbSell4";
            this.lbSell4.Size = new System.Drawing.Size(41, 12);
            this.lbSell4.TabIndex = 0;
            this.lbSell4.Text = "卖四：";
            this.lbSell4.Click += new System.EventHandler(this.lbPrice_Click);
            // 
            // lbBuy4
            // 
            this.lbBuy4.AutoSize = true;
            this.lbBuy4.Location = new System.Drawing.Point(36, 80);
            this.lbBuy4.Name = "lbBuy4";
            this.lbBuy4.Size = new System.Drawing.Size(41, 12);
            this.lbBuy4.TabIndex = 0;
            this.lbBuy4.Text = "买四：";
            this.lbBuy4.Click += new System.EventHandler(this.lbPrice_Click);
            // 
            // lbSell3
            // 
            this.lbSell3.AutoSize = true;
            this.lbSell3.Location = new System.Drawing.Point(163, 58);
            this.lbSell3.Name = "lbSell3";
            this.lbSell3.Size = new System.Drawing.Size(41, 12);
            this.lbSell3.TabIndex = 0;
            this.lbSell3.Text = "卖三：";
            this.lbSell3.Click += new System.EventHandler(this.lbPrice_Click);
            // 
            // lbSell2
            // 
            this.lbSell2.AutoSize = true;
            this.lbSell2.Location = new System.Drawing.Point(163, 36);
            this.lbSell2.Name = "lbSell2";
            this.lbSell2.Size = new System.Drawing.Size(41, 12);
            this.lbSell2.TabIndex = 0;
            this.lbSell2.Text = "卖二：";
            this.lbSell2.Click += new System.EventHandler(this.lbPrice_Click);
            // 
            // lbBuy3
            // 
            this.lbBuy3.AutoSize = true;
            this.lbBuy3.Location = new System.Drawing.Point(36, 58);
            this.lbBuy3.Name = "lbBuy3";
            this.lbBuy3.Size = new System.Drawing.Size(41, 12);
            this.lbBuy3.TabIndex = 0;
            this.lbBuy3.Text = "买三：";
            this.lbBuy3.Click += new System.EventHandler(this.lbPrice_Click);
            // 
            // lbSell1
            // 
            this.lbSell1.AutoSize = true;
            this.lbSell1.Location = new System.Drawing.Point(163, 14);
            this.lbSell1.Name = "lbSell1";
            this.lbSell1.Size = new System.Drawing.Size(41, 12);
            this.lbSell1.TabIndex = 0;
            this.lbSell1.Text = "卖一：";
            this.lbSell1.Click += new System.EventHandler(this.lbPrice_Click);
            // 
            // lbBuy2
            // 
            this.lbBuy2.AutoSize = true;
            this.lbBuy2.Location = new System.Drawing.Point(36, 36);
            this.lbBuy2.Name = "lbBuy2";
            this.lbBuy2.Size = new System.Drawing.Size(41, 12);
            this.lbBuy2.TabIndex = 0;
            this.lbBuy2.Text = "买二：";
            this.lbBuy2.Click += new System.EventHandler(this.lbPrice_Click);
            // 
            // lbBuy1
            // 
            this.lbBuy1.AutoSize = true;
            this.lbBuy1.Location = new System.Drawing.Point(36, 14);
            this.lbBuy1.Name = "lbBuy1";
            this.lbBuy1.Size = new System.Drawing.Size(41, 12);
            this.lbBuy1.TabIndex = 0;
            this.lbBuy1.Text = "买一：";
            this.lbBuy1.Click += new System.EventHandler(this.lbPrice_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnTrade);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(16, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 44);
            this.panel2.TabIndex = 2;
            // 
            // lbWarning
            // 
            this.lbWarning.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbWarning.Location = new System.Drawing.Point(16, 156);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(288, 23);
            this.lbWarning.TabIndex = 7;
            this.lbWarning.Text = "Warning messages";
            this.lbWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTrading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 365);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTrading";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormTrading";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTrading_FormClosed);
            this.Load += new System.EventHandler(this.FormTrading_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbStockCode;
        private System.Windows.Forms.TextBox txtMaxQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.TextBox txtStockCode;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbMaxQuantity;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTrade;
        private System.Windows.Forms.Label lbSell5;
        private System.Windows.Forms.Label lbBuy5;
        private System.Windows.Forms.Label lbSell4;
        private System.Windows.Forms.Label lbBuy4;
        private System.Windows.Forms.Label lbSell3;
        private System.Windows.Forms.Label lbSell2;
        private System.Windows.Forms.Label lbBuy3;
        private System.Windows.Forms.Label lbSell1;
        private System.Windows.Forms.Label lbBuy2;
        private System.Windows.Forms.Label lbBuy1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbWarning;
    }
}