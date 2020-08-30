﻿namespace Klijent
{
    partial class ClientInsert
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
            this.rbPerson = new System.Windows.Forms.RadioButton();
            this.rbCompany = new System.Windows.Forms.RadioButton();
            this.gbPerson = new System.Windows.Forms.GroupBox();
            this.txtAddP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCompany = new System.Windows.Forms.GroupBox();
            this.txtAdrC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPIB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbPerson.SuspendLayout();
            this.gbCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbPerson
            // 
            this.rbPerson.AutoSize = true;
            this.rbPerson.Checked = true;
            this.rbPerson.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPerson.Location = new System.Drawing.Point(12, 21);
            this.rbPerson.Name = "rbPerson";
            this.rbPerson.Size = new System.Drawing.Size(66, 20);
            this.rbPerson.TabIndex = 0;
            this.rbPerson.TabStop = true;
            this.rbPerson.Text = "Person";
            this.rbPerson.UseVisualStyleBackColor = true;
            this.rbPerson.CheckedChanged += new System.EventHandler(this.rbPerson_CheckedChanged);
            // 
            // rbCompany
            // 
            this.rbCompany.AutoSize = true;
            this.rbCompany.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCompany.Location = new System.Drawing.Point(91, 21);
            this.rbCompany.Name = "rbCompany";
            this.rbCompany.Size = new System.Drawing.Size(81, 20);
            this.rbCompany.TabIndex = 1;
            this.rbCompany.Text = "Company";
            this.rbCompany.UseVisualStyleBackColor = true;
            this.rbCompany.CheckedChanged += new System.EventHandler(this.rbCompany_CheckedChanged);
            // 
            // gbPerson
            // 
            this.gbPerson.Controls.Add(this.txtAddP);
            this.gbPerson.Controls.Add(this.label6);
            this.gbPerson.Controls.Add(this.txtPhone);
            this.gbPerson.Controls.Add(this.label5);
            this.gbPerson.Controls.Add(this.txtMail);
            this.gbPerson.Controls.Add(this.label4);
            this.gbPerson.Controls.Add(this.txtJMBG);
            this.gbPerson.Controls.Add(this.label3);
            this.gbPerson.Controls.Add(this.txtLN);
            this.gbPerson.Controls.Add(this.label2);
            this.gbPerson.Controls.Add(this.txtFN);
            this.gbPerson.Controls.Add(this.label1);
            this.gbPerson.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPerson.Location = new System.Drawing.Point(12, 56);
            this.gbPerson.Name = "gbPerson";
            this.gbPerson.Size = new System.Drawing.Size(376, 187);
            this.gbPerson.TabIndex = 2;
            this.gbPerson.TabStop = false;
            this.gbPerson.Text = "Person data";
            this.gbPerson.Visible = false;
            // 
            // txtAddP
            // 
            this.txtAddP.Location = new System.Drawing.Point(79, 155);
            this.txtAddP.Name = "txtAddP";
            this.txtAddP.Size = new System.Drawing.Size(291, 24);
            this.txtAddP.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(79, 129);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(291, 24);
            this.txtPhone.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(79, 103);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(291, 24);
            this.txtMail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "E - mail:";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(79, 77);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(291, 24);
            this.txtJMBG.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "JMBG:";
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(79, 51);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(291, 24);
            this.txtLN.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last name:";
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(79, 25);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(291, 24);
            this.txtFN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name:";
            // 
            // gbCompany
            // 
            this.gbCompany.Controls.Add(this.txtAdrC);
            this.gbCompany.Controls.Add(this.label10);
            this.gbCompany.Controls.Add(this.label7);
            this.gbCompany.Controls.Add(this.txtName);
            this.gbCompany.Controls.Add(this.txtRegNo);
            this.gbCompany.Controls.Add(this.label9);
            this.gbCompany.Controls.Add(this.label8);
            this.gbCompany.Controls.Add(this.txtPIB);
            this.gbCompany.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCompany.Location = new System.Drawing.Point(412, 56);
            this.gbCompany.Name = "gbCompany";
            this.gbCompany.Size = new System.Drawing.Size(376, 187);
            this.gbCompany.TabIndex = 3;
            this.gbCompany.TabStop = false;
            this.gbCompany.Text = "Company data";
            this.gbCompany.Visible = false;
            // 
            // txtAdrC
            // 
            this.txtAdrC.Location = new System.Drawing.Point(79, 103);
            this.txtAdrC.Name = "txtAdrC";
            this.txtAdrC.Size = new System.Drawing.Size(291, 24);
            this.txtAdrC.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Address:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(291, 24);
            this.txtName.TabIndex = 13;
            // 
            // txtRegNo
            // 
            this.txtRegNo.Location = new System.Drawing.Point(79, 77);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(291, 24);
            this.txtRegNo.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "PIB:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Reg No:";
            // 
            // txtPIB
            // 
            this.txtPIB.Location = new System.Drawing.Point(79, 51);
            this.txtPIB.Name = "txtPIB";
            this.txtPIB.Size = new System.Drawing.Size(291, 24);
            this.txtPIB.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save Client";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 324);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbCompany);
            this.Controls.Add(this.gbPerson);
            this.Controls.Add(this.rbCompany);
            this.Controls.Add(this.rbPerson);
            this.Name = "ClientInsert";
            this.Text = "Insert Client";
            this.Load += new System.EventHandler(this.ClientInsert_Load);
            this.gbPerson.ResumeLayout(false);
            this.gbPerson.PerformLayout();
            this.gbCompany.ResumeLayout(false);
            this.gbCompany.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPerson;
        private System.Windows.Forms.RadioButton rbCompany;
        private System.Windows.Forms.GroupBox gbPerson;
        private System.Windows.Forms.TextBox txtAddP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCompany;
        private System.Windows.Forms.TextBox txtAdrC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPIB;
        private System.Windows.Forms.Button button1;
    }
}