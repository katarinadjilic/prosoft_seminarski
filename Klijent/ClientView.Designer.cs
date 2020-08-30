namespace Klijent
{
    partial class ClientView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.rbCompany = new System.Windows.Forms.RadioButton();
            this.rbPerson = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "New client";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter:";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(61, 21);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(280, 20);
            this.txtFilter.TabIndex = 4;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // rbCompany
            // 
            this.rbCompany.AutoSize = true;
            this.rbCompany.Location = new System.Drawing.Point(481, 22);
            this.rbCompany.Name = "rbCompany";
            this.rbCompany.Size = new System.Drawing.Size(69, 17);
            this.rbCompany.TabIndex = 6;
            this.rbCompany.Text = "Company";
            this.rbCompany.UseVisualStyleBackColor = true;
            this.rbCompany.CheckedChanged += new System.EventHandler(this.rbCompany_CheckedChanged);
            // 
            // rbPerson
            // 
            this.rbPerson.AutoSize = true;
            this.rbPerson.Checked = true;
            this.rbPerson.Location = new System.Drawing.Point(402, 22);
            this.rbPerson.Name = "rbPerson";
            this.rbPerson.Size = new System.Drawing.Size(58, 17);
            this.rbPerson.TabIndex = 5;
            this.rbPerson.TabStop = true;
            this.rbPerson.Text = "Person";
            this.rbPerson.UseVisualStyleBackColor = true;
            this.rbPerson.CheckedChanged += new System.EventHandler(this.rbPerson_CheckedChanged);
            // 
            // ClientPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 399);
            this.Controls.Add(this.rbCompany);
            this.Controls.Add(this.rbPerson);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClientPregled";
            this.Text = "ClientPregled";
            this.Load += new System.EventHandler(this.ClientPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.RadioButton rbCompany;
        private System.Windows.Forms.RadioButton rbPerson;
    }
}