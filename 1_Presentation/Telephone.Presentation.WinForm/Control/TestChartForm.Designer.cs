namespace Telephone.Presentation.WinForm
{
    partial class TestChartForm
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
            this.btnCapitalChart = new System.Windows.Forms.Button();
            this.pbChart = new System.Windows.Forms.PictureBox();
            this.btnDayChart = new System.Windows.Forms.Button();
            this.txtTicker = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pbChart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapitalChart
            // 
            this.btnCapitalChart.Location = new System.Drawing.Point(536, 412);
            this.btnCapitalChart.Name = "btnCapitalChart";
            this.btnCapitalChart.Size = new System.Drawing.Size(75, 23);
            this.btnCapitalChart.TabIndex = 0;
            this.btnCapitalChart.Text = "资金流向图";
            this.btnCapitalChart.UseVisualStyleBackColor = true;
            this.btnCapitalChart.Click += new System.EventHandler(this.btnCapitalChart_Click);
            // 
            // pbChart
            // 
            this.pbChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbChart.Location = new System.Drawing.Point(12, 12);
            this.pbChart.Name = "pbChart";
            this.pbChart.Size = new System.Drawing.Size(599, 390);
            this.pbChart.TabIndex = 1;
            this.pbChart.TabStop = false;
            // 
            // btnDayChart
            // 
            this.btnDayChart.Location = new System.Drawing.Point(455, 412);
            this.btnDayChart.Name = "btnDayChart";
            this.btnDayChart.Size = new System.Drawing.Size(75, 23);
            this.btnDayChart.TabIndex = 2;
            this.btnDayChart.Text = "日线图";
            this.btnDayChart.UseVisualStyleBackColor = true;
            this.btnDayChart.Click += new System.EventHandler(this.btnDayChart_Click);
            // 
            // txtTicker
            // 
            this.txtTicker.Location = new System.Drawing.Point(77, 413);
            this.txtTicker.Name = "txtTicker";
            this.txtTicker.Size = new System.Drawing.Size(93, 21);
            this.txtTicker.TabIndex = 3;
            this.txtTicker.Text = "600036";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "股票代码:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "开始日期:";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(271, 412);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(126, 21);
            this.dtpStart.TabIndex = 6;
            // 
            // TestChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 443);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTicker);
            this.Controls.Add(this.btnDayChart);
            this.Controls.Add(this.pbChart);
            this.Controls.Add(this.btnCapitalChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestChartForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TestChartForm";
            this.Load += new System.EventHandler(this.TestChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapitalChart;
        private System.Windows.Forms.PictureBox pbChart;
        private System.Windows.Forms.Button btnDayChart;
        private System.Windows.Forms.TextBox txtTicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStart;
    }
}