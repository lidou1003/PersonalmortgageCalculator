namespace 個人房貸試算器
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtLoanTerm = new System.Windows.Forms.TextBox();
            this.txtGracePeriod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblResultLoanAmount = new System.Windows.Forms.Label();
            this.lblResultMonthlyPayment = new System.Windows.Forms.Label();
            this.lblResultFirstInterest = new System.Windows.Forms.Label();
            this.lblResultFirstPrincipal = new System.Windows.Forms.Label();
            this.lblResultTotalInterest = new System.Windows.Forms.Label();
            this.lblResultTotalPayment = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "房屋總價:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(22, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "自備款比例:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(22, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "貸款利率:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(22, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "貸款年限:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(22, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "寬限期:";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalPrice.Location = new System.Drawing.Point(109, 38);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(219, 28);
            this.txtTotalPrice.TabIndex = 5;
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Location = new System.Drawing.Point(128, 83);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(219, 28);
            this.txtDownPayment.TabIndex = 6;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(109, 124);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(219, 28);
            this.txtInterestRate.TabIndex = 7;
            // 
            // txtLoanTerm
            // 
            this.txtLoanTerm.Location = new System.Drawing.Point(109, 172);
            this.txtLoanTerm.Name = "txtLoanTerm";
            this.txtLoanTerm.Size = new System.Drawing.Size(219, 28);
            this.txtLoanTerm.TabIndex = 8;
            // 
            // txtGracePeriod
            // 
            this.txtGracePeriod.Location = new System.Drawing.Point(88, 218);
            this.txtGracePeriod.Name = "txtGracePeriod";
            this.txtGracePeriod.Size = new System.Drawing.Size(219, 28);
            this.txtGracePeriod.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(330, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "萬元";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(350, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(330, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(329, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "年";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(309, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "年";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.OldLace;
            this.btnCalculate.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCalculate.Location = new System.Drawing.Point(426, 51);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(155, 60);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "開始計算";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OldLace;
            this.button2.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(426, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 66);
            this.button2.TabIndex = 16;
            this.button2.Text = "清除重新輸入";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtGracePeriod);
            this.groupBox1.Controls.Add(this.txtLoanTerm);
            this.groupBox1.Controls.Add(this.txtInterestRate);
            this.groupBox1.Controls.Add(this.txtDownPayment);
            this.groupBox1.Controls.Add(this.txtTotalPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(38, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 282);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "輸入項目";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(21, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "貸款總金額:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(21, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "每月應繳金額(本+ 息):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(22, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "首期利息:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(21, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "首期本金:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(22, 198);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "總利息支出:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(22, 237);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 17);
            this.label16.TabIndex = 23;
            this.label16.Text = "總還款金額:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblResultTotalPayment);
            this.groupBox2.Controls.Add(this.lblResultTotalInterest);
            this.groupBox2.Controls.Add(this.lblResultFirstPrincipal);
            this.groupBox2.Controls.Add(this.lblResultFirstInterest);
            this.groupBox2.Controls.Add(this.lblResultMonthlyPayment);
            this.groupBox2.Controls.Add(this.lblResultLoanAmount);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(40, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 295);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "試算結果顯示";
            // 
            // lblResultLoanAmount
            // 
            this.lblResultLoanAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultLoanAmount.Location = new System.Drawing.Point(126, 38);
            this.lblResultLoanAmount.Name = "lblResultLoanAmount";
            this.lblResultLoanAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResultLoanAmount.Size = new System.Drawing.Size(191, 28);
            this.lblResultLoanAmount.TabIndex = 1;
            this.lblResultLoanAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultMonthlyPayment
            // 
            this.lblResultMonthlyPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultMonthlyPayment.Location = new System.Drawing.Point(214, 78);
            this.lblResultMonthlyPayment.Name = "lblResultMonthlyPayment";
            this.lblResultMonthlyPayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResultMonthlyPayment.Size = new System.Drawing.Size(191, 28);
            this.lblResultMonthlyPayment.TabIndex = 1;
            this.lblResultMonthlyPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultFirstInterest
            // 
            this.lblResultFirstInterest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultFirstInterest.Location = new System.Drawing.Point(107, 119);
            this.lblResultFirstInterest.Name = "lblResultFirstInterest";
            this.lblResultFirstInterest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResultFirstInterest.Size = new System.Drawing.Size(191, 28);
            this.lblResultFirstInterest.TabIndex = 1;
            this.lblResultFirstInterest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultFirstPrincipal
            // 
            this.lblResultFirstPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultFirstPrincipal.Location = new System.Drawing.Point(107, 155);
            this.lblResultFirstPrincipal.Name = "lblResultFirstPrincipal";
            this.lblResultFirstPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResultFirstPrincipal.Size = new System.Drawing.Size(191, 28);
            this.lblResultFirstPrincipal.TabIndex = 1;
            this.lblResultFirstPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultTotalInterest
            // 
            this.lblResultTotalInterest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultTotalInterest.Location = new System.Drawing.Point(126, 192);
            this.lblResultTotalInterest.Name = "lblResultTotalInterest";
            this.lblResultTotalInterest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResultTotalInterest.Size = new System.Drawing.Size(191, 28);
            this.lblResultTotalInterest.TabIndex = 1;
            this.lblResultTotalInterest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultTotalPayment
            // 
            this.lblResultTotalPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultTotalPayment.Location = new System.Drawing.Point(126, 231);
            this.lblResultTotalPayment.Name = "lblResultTotalPayment";
            this.lblResultTotalPayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResultTotalPayment.Size = new System.Drawing.Size(191, 28);
            this.lblResultTotalPayment.TabIndex = 1;
            this.lblResultTotalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(758, 631);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "房貸計算器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtLoanTerm;
        private System.Windows.Forms.TextBox txtGracePeriod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblResultLoanAmount;
        private System.Windows.Forms.Label lblResultTotalPayment;
        private System.Windows.Forms.Label lblResultTotalInterest;
        private System.Windows.Forms.Label lblResultFirstPrincipal;
        private System.Windows.Forms.Label lblResultFirstInterest;
        private System.Windows.Forms.Label lblResultMonthlyPayment;
    }
}

