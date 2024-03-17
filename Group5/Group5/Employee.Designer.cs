namespace Group5
{
    partial class Employee
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.EmpGenCb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EmpPhoneTb = new System.Windows.Forms.TextBox();
            this.EmpEduCb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Empdob = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.EmpPosCb = new System.Windows.Forms.ComboBox();
            this.EmpAddTb = new System.Windows.Forms.TextBox();
            this.EmpNameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpIdTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.EmpDGV = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(169, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = " Manage Employee";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.Controls.Add(this.EmpDGV);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.EmpGenCb);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.EmpPhoneTb);
            this.panel1.Controls.Add(this.EmpEduCb);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Empdob);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.EmpPosCb);
            this.panel1.Controls.Add(this.EmpAddTb);
            this.panel1.Controls.Add(this.EmpNameTb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EmpIdTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1471, 533);
            this.panel1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(218, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 47);
            this.button4.TabIndex = 27;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(382, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 47);
            this.button3.TabIndex = 26;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(55, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 47);
            this.button2.TabIndex = 25;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(218, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 47);
            this.button1.TabIndex = 24;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmpGenCb
            // 
            this.EmpGenCb.FormattingEnabled = true;
            this.EmpGenCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EmpGenCb.Location = new System.Drawing.Point(308, 135);
            this.EmpGenCb.Name = "EmpGenCb";
            this.EmpGenCb.Size = new System.Drawing.Size(189, 24);
            this.EmpGenCb.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Firebrick;
            this.label9.Location = new System.Drawing.Point(304, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Employee Gender";
            // 
            // EmpPhoneTb
            // 
            this.EmpPhoneTb.Location = new System.Drawing.Point(47, 313);
            this.EmpPhoneTb.Name = "EmpPhoneTb";
            this.EmpPhoneTb.Size = new System.Drawing.Size(172, 22);
            this.EmpPhoneTb.TabIndex = 21;
            // 
            // EmpEduCb
            // 
            this.EmpEduCb.FormattingEnabled = true;
            this.EmpEduCb.Items.AddRange(new object[] {
            "BTech",
            "MTech",
            "BBA",
            "BCA",
            "MBA",
            "BCom",
            "MCom"});
            this.EmpEduCb.Location = new System.Drawing.Point(308, 311);
            this.EmpEduCb.Name = "EmpEduCb";
            this.EmpEduCb.Size = new System.Drawing.Size(189, 24);
            this.EmpEduCb.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(304, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Employee Education";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(43, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Employee Phone";
            // 
            // Empdob
            // 
            this.Empdob.Location = new System.Drawing.Point(308, 225);
            this.Empdob.Name = "Empdob";
            this.Empdob.Size = new System.Drawing.Size(189, 22);
            this.Empdob.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(304, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Employee DOB";
            // 
            // EmpPosCb
            // 
            this.EmpPosCb.FormattingEnabled = true;
            this.EmpPosCb.Items.AddRange(new object[] {
            "Manager",
            "Senior Developper",
            "Junior Developper",
            "Accountant",
            "Receptionist"});
            this.EmpPosCb.Location = new System.Drawing.Point(47, 225);
            this.EmpPosCb.Name = "EmpPosCb";
            this.EmpPosCb.Size = new System.Drawing.Size(172, 24);
            this.EmpPosCb.TabIndex = 15;
            // 
            // EmpAddTb
            // 
            this.EmpAddTb.Location = new System.Drawing.Point(47, 135);
            this.EmpAddTb.Name = "EmpAddTb";
            this.EmpAddTb.Size = new System.Drawing.Size(171, 22);
            this.EmpAddTb.TabIndex = 14;
            // 
            // EmpNameTb
            // 
            this.EmpNameTb.Location = new System.Drawing.Point(308, 58);
            this.EmpNameTb.Name = "EmpNameTb";
            this.EmpNameTb.Size = new System.Drawing.Size(189, 22);
            this.EmpNameTb.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(43, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Employee Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(304, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(43, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Employee Position";
            // 
            // EmpIdTb
            // 
            this.EmpIdTb.Location = new System.Drawing.Point(47, 58);
            this.EmpIdTb.Name = "EmpIdTb";
            this.EmpIdTb.Size = new System.Drawing.Size(172, 22);
            this.EmpIdTb.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(43, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Employee ID";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Group5.Properties.Resources._38993372;
            this.pictureBox3.Location = new System.Drawing.Point(48, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(104, 101);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // EmpDGV
            // 
            this.EmpDGV.BackgroundColor = System.Drawing.Color.LightYellow;
            this.EmpDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpDGV.GridColor = System.Drawing.Color.LightYellow;
            this.EmpDGV.Location = new System.Drawing.Point(548, 58);
            this.EmpDGV.Name = "EmpDGV";
            this.EmpDGV.RowHeadersWidth = 51;
            this.EmpDGV.RowTemplate.Height = 24;
            this.EmpDGV.Size = new System.Drawing.Size(910, 446);
            this.EmpDGV.TabIndex = 28;
            this.EmpDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpDGV_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Firebrick;
            this.label10.Location = new System.Drawing.Point(1425, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 34);
            this.label10.TabIndex = 12;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1471, 685);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox EmpPosCb;
        private System.Windows.Forms.TextBox EmpAddTb;
        private System.Windows.Forms.TextBox EmpNameTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmpIdTb;
        private System.Windows.Forms.TextBox EmpPhoneTb;
        private System.Windows.Forms.ComboBox EmpEduCb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Empdob;
        private System.Windows.Forms.ComboBox EmpGenCb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView EmpDGV;
        private System.Windows.Forms.Label label10;
    }
}