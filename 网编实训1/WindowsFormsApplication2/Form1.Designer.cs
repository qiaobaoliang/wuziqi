namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonScan = new System.Windows.Forms.Button();
            this.listBoxStatus = new System.Windows.Forms.ListBox();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.numericUpDownStart3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStart1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStart2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEnd4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEnd3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEnd2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEnd1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStart4 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(570, 138);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(75, 23);
            this.buttonScan.TabIndex = 0;
            this.buttonScan.Text = "扫描";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // listBoxStatus
            // 
            this.listBoxStatus.FormattingEnabled = true;
            this.listBoxStatus.ItemHeight = 12;
            this.listBoxStatus.Location = new System.Drawing.Point(71, 220);
            this.listBoxStatus.Name = "listBoxStatus";
            this.listBoxStatus.Size = new System.Drawing.Size(597, 160);
            this.listBoxStatus.TabIndex = 1;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Checked = true;
            this.radioButtonYes.Location = new System.Drawing.Point(52, 45);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(35, 16);
            this.radioButtonYes.TabIndex = 2;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "是";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            this.radioButtonYes.CheckedChanged += new System.EventHandler(this.radioButtonYes_CheckedChanged);
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(167, 45);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(35, 16);
            this.radioButtonNo.TabIndex = 3;
            this.radioButtonNo.Text = "否";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // numericUpDownStart3
            // 
            this.numericUpDownStart3.Location = new System.Drawing.Point(268, 53);
            this.numericUpDownStart3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownStart3.Name = "numericUpDownStart3";
            this.numericUpDownStart3.Size = new System.Drawing.Size(44, 21);
            this.numericUpDownStart3.TabIndex = 4;
            this.numericUpDownStart3.ValueChanged += new System.EventHandler(this.numericUpDownStart3_ValueChanged);
            // 
            // numericUpDownStart1
            // 
            this.numericUpDownStart1.Location = new System.Drawing.Point(88, 53);
            this.numericUpDownStart1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownStart1.Name = "numericUpDownStart1";
            this.numericUpDownStart1.Size = new System.Drawing.Size(49, 21);
            this.numericUpDownStart1.TabIndex = 5;
            this.numericUpDownStart1.Value = new decimal(new int[] {
            172,
            0,
            0,
            0});
            this.numericUpDownStart1.ValueChanged += new System.EventHandler(this.numericUpDownStart1_ValueChanged);
            // 
            // numericUpDownStart2
            // 
            this.numericUpDownStart2.Location = new System.Drawing.Point(168, 53);
            this.numericUpDownStart2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownStart2.Name = "numericUpDownStart2";
            this.numericUpDownStart2.Size = new System.Drawing.Size(49, 21);
            this.numericUpDownStart2.TabIndex = 6;
            this.numericUpDownStart2.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownStart2.ValueChanged += new System.EventHandler(this.numericUpDownStart2_ValueChanged);
            // 
            // numericUpDownEnd4
            // 
            this.numericUpDownEnd4.Location = new System.Drawing.Point(363, 97);
            this.numericUpDownEnd4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownEnd4.Name = "numericUpDownEnd4";
            this.numericUpDownEnd4.Size = new System.Drawing.Size(44, 21);
            this.numericUpDownEnd4.TabIndex = 7;
            this.numericUpDownEnd4.ValueChanged += new System.EventHandler(this.numericUpDownEnd4_ValueChanged);
            // 
            // numericUpDownEnd3
            // 
            this.numericUpDownEnd3.Enabled = false;
            this.numericUpDownEnd3.Location = new System.Drawing.Point(268, 97);
            this.numericUpDownEnd3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownEnd3.Name = "numericUpDownEnd3";
            this.numericUpDownEnd3.Size = new System.Drawing.Size(44, 21);
            this.numericUpDownEnd3.TabIndex = 8;
            // 
            // numericUpDownEnd2
            // 
            this.numericUpDownEnd2.Enabled = false;
            this.numericUpDownEnd2.Location = new System.Drawing.Point(168, 97);
            this.numericUpDownEnd2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownEnd2.Name = "numericUpDownEnd2";
            this.numericUpDownEnd2.Size = new System.Drawing.Size(49, 21);
            this.numericUpDownEnd2.TabIndex = 9;
            this.numericUpDownEnd2.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // numericUpDownEnd1
            // 
            this.numericUpDownEnd1.Enabled = false;
            this.numericUpDownEnd1.Location = new System.Drawing.Point(88, 97);
            this.numericUpDownEnd1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownEnd1.Name = "numericUpDownEnd1";
            this.numericUpDownEnd1.Size = new System.Drawing.Size(49, 21);
            this.numericUpDownEnd1.TabIndex = 10;
            this.numericUpDownEnd1.Value = new decimal(new int[] {
            172,
            0,
            0,
            0});
            // 
            // numericUpDownStart4
            // 
            this.numericUpDownStart4.Location = new System.Drawing.Point(364, 53);
            this.numericUpDownStart4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownStart4.Name = "numericUpDownStart4";
            this.numericUpDownStart4.Size = new System.Drawing.Size(43, 21);
            this.numericUpDownStart4.TabIndex = 11;
            this.numericUpDownStart4.ValueChanged += new System.EventHandler(this.numericUpDownStart4_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 134);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择IP地址范围";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "终止地址：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "起始地址：";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(20, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(702, 197);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "扫描结果";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonYes);
            this.groupBox3.Controls.Add(this.radioButtonNo);
            this.groupBox3.Location = new System.Drawing.Point(456, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 81);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "是否用多线程扫描";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 415);
            this.Controls.Add(this.numericUpDownStart4);
            this.Controls.Add(this.numericUpDownEnd1);
            this.Controls.Add(this.numericUpDownEnd2);
            this.Controls.Add(this.numericUpDownEnd3);
            this.Controls.Add(this.numericUpDownEnd4);
            this.Controls.Add(this.numericUpDownStart2);
            this.Controls.Add(this.numericUpDownStart1);
            this.Controls.Add(this.numericUpDownStart3);
            this.Controls.Add(this.listBoxStatus);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "扫描主机";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.ListBox listBoxStatus;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.NumericUpDown numericUpDownStart3;
        private System.Windows.Forms.NumericUpDown numericUpDownStart1;
        private System.Windows.Forms.NumericUpDown numericUpDownStart2;
        private System.Windows.Forms.NumericUpDown numericUpDownEnd4;
        private System.Windows.Forms.NumericUpDown numericUpDownEnd3;
        private System.Windows.Forms.NumericUpDown numericUpDownEnd2;
        private System.Windows.Forms.NumericUpDown numericUpDownEnd1;
        private System.Windows.Forms.NumericUpDown numericUpDownStart4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

