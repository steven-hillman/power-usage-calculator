// Application is used to calculate price for power usage depending on the type of customer
// created December 2019
// Author: Steven Hillman

namespace StevenHillman_CPRG_200_Lab1
{
    partial class Form1
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
            this.lblOverall = new System.Windows.Forms.Label();
            this.txtkWh = new System.Windows.Forms.TextBox();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCommercial = new System.Windows.Forms.RadioButton();
            this.radioResidential = new System.Windows.Forms.RadioButton();
            this.radioIndustrial = new System.Windows.Forms.RadioButton();
            this.lblOffPeak = new System.Windows.Forms.Label();
            this.txtOffkWh = new System.Windows.Forms.TextBox();
            this.lblPeak = new System.Windows.Forms.Label();
            this.txtPeakkWh = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalCustomers = new System.Windows.Forms.TextBox();
            this.txtIndustrial = new System.Windows.Forms.TextBox();
            this.txtResidential = new System.Windows.Forms.TextBox();
            this.txtCommercial = new System.Windows.Forms.TextBox();
            this.txtAllCharges = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOverall
            // 
            this.lblOverall.AutoSize = true;
            this.lblOverall.Location = new System.Drawing.Point(23, 280);
            this.lblOverall.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOverall.Name = "lblOverall";
            this.lblOverall.Size = new System.Drawing.Size(69, 13);
            this.lblOverall.TabIndex = 0;
            this.lblOverall.Text = "Overall kWh:";
            // 
            // txtkWh
            // 
            this.txtkWh.Location = new System.Drawing.Point(104, 277);
            this.txtkWh.Margin = new System.Windows.Forms.Padding(2);
            this.txtkWh.Name = "txtkWh";
            this.txtkWh.Size = new System.Drawing.Size(104, 20);
            this.txtkWh.TabIndex = 1;
            // 
            // txtCharge
            // 
            this.txtCharge.BackColor = System.Drawing.Color.FloralWhite;
            this.txtCharge.Enabled = false;
            this.txtCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharge.ForeColor = System.Drawing.Color.SpringGreen;
            this.txtCharge.Location = new System.Drawing.Point(640, 388);
            this.txtCharge.Margin = new System.Windows.Forms.Padding(2);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(104, 26);
            this.txtCharge.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(104, 365);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(104, 32);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Add Customer";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(675, 518);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(69, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(557, 518);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(69, 32);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCommercial);
            this.groupBox1.Controls.Add(this.radioResidential);
            this.groupBox1.Controls.Add(this.radioIndustrial);
            this.groupBox1.Location = new System.Drawing.Point(18, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(152, 139);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Type";
            // 
            // radioCommercial
            // 
            this.radioCommercial.AutoSize = true;
            this.radioCommercial.Location = new System.Drawing.Point(17, 106);
            this.radioCommercial.Margin = new System.Windows.Forms.Padding(2);
            this.radioCommercial.Name = "radioCommercial";
            this.radioCommercial.Size = new System.Drawing.Size(79, 17);
            this.radioCommercial.TabIndex = 2;
            this.radioCommercial.TabStop = true;
            this.radioCommercial.Text = "Commercial";
            this.radioCommercial.UseVisualStyleBackColor = true;
            this.radioCommercial.CheckedChanged += new System.EventHandler(this.radioCommercial_CheckedChanged);
            // 
            // radioResidential
            // 
            this.radioResidential.AutoSize = true;
            this.radioResidential.Checked = true;
            this.radioResidential.Location = new System.Drawing.Point(17, 67);
            this.radioResidential.Margin = new System.Windows.Forms.Padding(2);
            this.radioResidential.Name = "radioResidential";
            this.radioResidential.Size = new System.Drawing.Size(77, 17);
            this.radioResidential.TabIndex = 1;
            this.radioResidential.TabStop = true;
            this.radioResidential.Text = "Residential";
            this.radioResidential.UseVisualStyleBackColor = true;
            this.radioResidential.CheckedChanged += new System.EventHandler(this.radioResidential_CheckedChanged);
            // 
            // radioIndustrial
            // 
            this.radioIndustrial.AutoSize = true;
            this.radioIndustrial.Location = new System.Drawing.Point(17, 28);
            this.radioIndustrial.Margin = new System.Windows.Forms.Padding(2);
            this.radioIndustrial.Name = "radioIndustrial";
            this.radioIndustrial.Size = new System.Drawing.Size(67, 17);
            this.radioIndustrial.TabIndex = 0;
            this.radioIndustrial.Text = "Industrial";
            this.radioIndustrial.UseVisualStyleBackColor = true;
            this.radioIndustrial.CheckedChanged += new System.EventHandler(this.radioIndustrial_CheckedChanged);
            // 
            // lblOffPeak
            // 
            this.lblOffPeak.AutoSize = true;
            this.lblOffPeak.Location = new System.Drawing.Point(22, 325);
            this.lblOffPeak.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOffPeak.Name = "lblOffPeak";
            this.lblOffPeak.Size = new System.Drawing.Size(78, 13);
            this.lblOffPeak.TabIndex = 7;
            this.lblOffPeak.Text = "Off Peak kWh:";
            this.lblOffPeak.Visible = false;
            // 
            // txtOffkWh
            // 
            this.txtOffkWh.Location = new System.Drawing.Point(105, 322);
            this.txtOffkWh.Margin = new System.Windows.Forms.Padding(2);
            this.txtOffkWh.Name = "txtOffkWh";
            this.txtOffkWh.Size = new System.Drawing.Size(104, 20);
            this.txtOffkWh.TabIndex = 8;
            this.txtOffkWh.Visible = false;
            // 
            // lblPeak
            // 
            this.lblPeak.AutoSize = true;
            this.lblPeak.Location = new System.Drawing.Point(39, 280);
            this.lblPeak.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeak.Name = "lblPeak";
            this.lblPeak.Size = new System.Drawing.Size(61, 13);
            this.lblPeak.TabIndex = 9;
            this.lblPeak.Text = "Peak kWh:";
            this.lblPeak.Visible = false;
            // 
            // txtPeakkWh
            // 
            this.txtPeakkWh.Location = new System.Drawing.Point(104, 277);
            this.txtPeakkWh.Margin = new System.Windows.Forms.Padding(2);
            this.txtPeakkWh.Name = "txtPeakkWh";
            this.txtPeakkWh.Size = new System.Drawing.Size(104, 20);
            this.txtPeakkWh.TabIndex = 10;
            this.txtPeakkWh.Visible = false;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(104, 191);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(104, 20);
            this.txtCustomerName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Customer Name:";
            // 
            // txtTotalCustomers
            // 
            this.txtTotalCustomers.BackColor = System.Drawing.Color.FloralWhite;
            this.txtTotalCustomers.Enabled = false;
            this.txtTotalCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCustomers.ForeColor = System.Drawing.Color.SpringGreen;
            this.txtTotalCustomers.Location = new System.Drawing.Point(640, 90);
            this.txtTotalCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalCustomers.Name = "txtTotalCustomers";
            this.txtTotalCustomers.Size = new System.Drawing.Size(104, 26);
            this.txtTotalCustomers.TabIndex = 16;
            // 
            // txtIndustrial
            // 
            this.txtIndustrial.BackColor = System.Drawing.Color.FloralWhite;
            this.txtIndustrial.Enabled = false;
            this.txtIndustrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndustrial.ForeColor = System.Drawing.Color.SpringGreen;
            this.txtIndustrial.Location = new System.Drawing.Point(640, 131);
            this.txtIndustrial.Margin = new System.Windows.Forms.Padding(2);
            this.txtIndustrial.Name = "txtIndustrial";
            this.txtIndustrial.Size = new System.Drawing.Size(104, 26);
            this.txtIndustrial.TabIndex = 17;
            // 
            // txtResidential
            // 
            this.txtResidential.BackColor = System.Drawing.Color.FloralWhite;
            this.txtResidential.Enabled = false;
            this.txtResidential.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResidential.ForeColor = System.Drawing.Color.SpringGreen;
            this.txtResidential.Location = new System.Drawing.Point(640, 170);
            this.txtResidential.Margin = new System.Windows.Forms.Padding(2);
            this.txtResidential.Name = "txtResidential";
            this.txtResidential.Size = new System.Drawing.Size(104, 26);
            this.txtResidential.TabIndex = 18;
            // 
            // txtCommercial
            // 
            this.txtCommercial.BackColor = System.Drawing.Color.FloralWhite;
            this.txtCommercial.Enabled = false;
            this.txtCommercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommercial.ForeColor = System.Drawing.Color.SpringGreen;
            this.txtCommercial.Location = new System.Drawing.Point(640, 212);
            this.txtCommercial.Margin = new System.Windows.Forms.Padding(2);
            this.txtCommercial.Name = "txtCommercial";
            this.txtCommercial.Size = new System.Drawing.Size(104, 26);
            this.txtCommercial.TabIndex = 19;
            // 
            // txtAllCharges
            // 
            this.txtAllCharges.BackColor = System.Drawing.Color.FloralWhite;
            this.txtAllCharges.Enabled = false;
            this.txtAllCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllCharges.ForeColor = System.Drawing.Color.SpringGreen;
            this.txtAllCharges.Location = new System.Drawing.Point(640, 254);
            this.txtAllCharges.Margin = new System.Windows.Forms.Padding(2);
            this.txtAllCharges.Name = "txtAllCharges";
            this.txtAllCharges.Size = new System.Drawing.Size(104, 26);
            this.txtAllCharges.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Total # of Customers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Industrial Sum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Residential Sum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Commercial Sum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(528, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Sum of all Charges:";
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(244, 60);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(267, 459);
            this.lstCustomers.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 234);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Customer Id:";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(104, 231);
            this.txtCustomerId.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(104, 20);
            this.txtCustomerId.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(543, 396);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Charge Amount:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(345, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "All Customers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 589);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAllCharges);
            this.Controls.Add(this.txtCommercial);
            this.Controls.Add(this.txtResidential);
            this.Controls.Add(this.txtIndustrial);
            this.Controls.Add(this.txtTotalCustomers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtPeakkWh);
            this.Controls.Add(this.lblPeak);
            this.Controls.Add(this.txtOffkWh);
            this.Controls.Add(this.lblOffPeak);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtCharge);
            this.Controls.Add(this.txtkWh);
            this.Controls.Add(this.lblOverall);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOverall;
        private System.Windows.Forms.TextBox txtkWh;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioResidential;
        private System.Windows.Forms.RadioButton radioIndustrial;
        private System.Windows.Forms.Label lblOffPeak;
        private System.Windows.Forms.TextBox txtOffkWh;
        private System.Windows.Forms.Label lblPeak;
        private System.Windows.Forms.TextBox txtPeakkWh;
        private System.Windows.Forms.RadioButton radioCommercial;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalCustomers;
        private System.Windows.Forms.TextBox txtIndustrial;
        private System.Windows.Forms.TextBox txtResidential;
        private System.Windows.Forms.TextBox txtCommercial;
        private System.Windows.Forms.TextBox txtAllCharges;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

