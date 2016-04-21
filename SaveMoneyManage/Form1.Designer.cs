namespace SaveMoneyManage {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label5 = new System.Windows.Forms.Label();
            this.oneNumeric = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.oneLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fiveLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fiveNumeric = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tenLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tenNumeric = new System.Windows.Forms.NumericUpDown();
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.oneNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiveNumeric)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tenNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(6, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "１円玉";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // oneNumeric
            // 
            this.oneNumeric.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.oneNumeric.Location = new System.Drawing.Point(117, 13);
            this.oneNumeric.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.oneNumeric.Name = "oneNumeric";
            this.oneNumeric.Size = new System.Drawing.Size(71, 31);
            this.oneNumeric.TabIndex = 1;
            this.oneNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.oneNumeric.Value = new decimal(new int[] {
            123,
            0,
            0,
            0});
            this.oneNumeric.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oneLabel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.oneNumeric);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 49);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // oneLabel
            // 
            this.oneLabel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.oneLabel.Location = new System.Drawing.Point(202, 15);
            this.oneLabel.Name = "oneLabel";
            this.oneLabel.Size = new System.Drawing.Size(76, 24);
            this.oneLabel.TabIndex = 3;
            this.oneLabel.Text = "12345";
            this.oneLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(284, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "円";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(18, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 23);
            this.label11.TabIndex = 6;
            this.label11.Text = "合計金額：";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.totalLabel.Location = new System.Drawing.Point(143, 193);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(147, 24);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "1234567890";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(296, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 24);
            this.label12.TabIndex = 7;
            this.label12.Text = "円";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fiveLabel);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.fiveNumeric);
            this.groupBox2.Location = new System.Drawing.Point(12, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 49);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // fiveLabel
            // 
            this.fiveLabel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fiveLabel.Location = new System.Drawing.Point(198, 15);
            this.fiveLabel.Name = "fiveLabel";
            this.fiveLabel.Size = new System.Drawing.Size(80, 24);
            this.fiveLabel.TabIndex = 3;
            this.fiveLabel.Text = "12345";
            this.fiveLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(284, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "円";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(6, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "５円玉";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fiveNumeric
            // 
            this.fiveNumeric.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fiveNumeric.Location = new System.Drawing.Point(117, 13);
            this.fiveNumeric.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.fiveNumeric.Name = "fiveNumeric";
            this.fiveNumeric.Size = new System.Drawing.Size(71, 31);
            this.fiveNumeric.TabIndex = 1;
            this.fiveNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fiveNumeric.Value = new decimal(new int[] {
            123,
            0,
            0,
            0});
            this.fiveNumeric.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tenLabel);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tenNumeric);
            this.groupBox3.Location = new System.Drawing.Point(12, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 49);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // tenLabel
            // 
            this.tenLabel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tenLabel.Location = new System.Drawing.Point(194, 15);
            this.tenLabel.Name = "tenLabel";
            this.tenLabel.Size = new System.Drawing.Size(84, 24);
            this.tenLabel.TabIndex = 3;
            this.tenLabel.Text = "12345";
            this.tenLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(284, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "円";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(6, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "１０円玉";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tenNumeric
            // 
            this.tenNumeric.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tenNumeric.Location = new System.Drawing.Point(117, 13);
            this.tenNumeric.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.tenNumeric.Name = "tenNumeric";
            this.tenNumeric.Size = new System.Drawing.Size(71, 31);
            this.tenNumeric.TabIndex = 1;
            this.tenNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tenNumeric.Value = new decimal(new int[] {
            123,
            0,
            0,
            0});
            this.tenNumeric.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(255, 237);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "保存";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 281);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "貯金管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oneNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiveNumeric)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tenNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown oneNumeric;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label oneLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label fiveLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown fiveNumeric;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label tenLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown tenNumeric;
        private System.Windows.Forms.Button saveBtn;
    }
}

