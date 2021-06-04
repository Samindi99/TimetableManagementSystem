namespace TimeTableM
{
    partial class AddStudent
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label Faculty;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtProgramme = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbDep = new System.Windows.Forms.ComboBox();
            this.cmbFac = new System.Windows.Forms.ComboBox();
            this.cmbSubGrpNum = new System.Windows.Forms.ComboBox();
            this.cmbGrpNo = new System.Windows.Forms.ComboBox();
            this.cmbAcademicSemYear = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSubGrpID = new System.Windows.Forms.TextBox();
            this.txtGrpID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            Faculty = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(56, 411);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(158, 31);
            label4.TabIndex = 4;
            label4.Text = "Programme";
            label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(56, 562);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(250, 31);
            label5.TabIndex = 11;
            label5.Text = "Sub Group Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(56, 486);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(197, 31);
            label6.TabIndex = 12;
            label6.Text = "Group Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Location = new System.Drawing.Point(857, 523);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(177, 31);
            label7.TabIndex = 13;
            label7.Text = "Sub Group ID";
            label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.Color.Black;
            label8.Location = new System.Drawing.Point(857, 467);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(124, 31);
            label8.TabIndex = 14;
            label8.Text = "Group ID";
            // 
            // Faculty
            // 
            Faculty.AutoSize = true;
            Faculty.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Faculty.ForeColor = System.Drawing.Color.Black;
            Faculty.Location = new System.Drawing.Point(56, 182);
            Faculty.Name = "Faculty";
            Faculty.Size = new System.Drawing.Size(100, 31);
            Faculty.TabIndex = 29;
            Faculty.Text = "Faculty";
            Faculty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.txtProgramme);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(Faculty);
            this.panel2.Controls.Add(this.cmbDep);
            this.panel2.Controls.Add(this.cmbFac);
            this.panel2.Controls.Add(this.cmbSubGrpNum);
            this.panel2.Controls.Add(this.cmbGrpNo);
            this.panel2.Controls.Add(this.cmbAcademicSemYear);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtSubGrpID);
            this.panel2.Controls.Add(this.txtGrpID);
            this.panel2.Controls.Add(label8);
            this.panel2.Controls.Add(label7);
            this.panel2.Controls.Add(label6);
            this.panel2.Controls.Add(label5);
            this.panel2.Controls.Add(label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.SpringGreen;
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1363, 772);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 84);
            this.panel1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(411, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(513, 62);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add Student Group";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1183, 13);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 40);
            this.button4.TabIndex = 7;
            this.button4.Text = "HOME";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(44, 13);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 42);
            this.button5.TabIndex = 0;
            this.button5.Text = "BACK";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtProgramme
            // 
            this.txtProgramme.Location = new System.Drawing.Point(397, 410);
            this.txtProgramme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProgramme.Name = "txtProgramme";
            this.txtProgramme.Size = new System.Drawing.Size(348, 34);
            this.txtProgramme.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(56, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 31);
            this.label9.TabIndex = 30;
            this.label9.Text = "Department";
            // 
            // cmbDep
            // 
            this.cmbDep.FormattingEnabled = true;
            this.cmbDep.Location = new System.Drawing.Point(397, 260);
            this.cmbDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDep.Name = "cmbDep";
            this.cmbDep.Size = new System.Drawing.Size(348, 35);
            this.cmbDep.TabIndex = 28;
            this.cmbDep.SelectedIndexChanged += new System.EventHandler(this.cmbDep_SelectedIndexChanged);
            this.cmbDep.Click += new System.EventHandler(this.cmbDep_Click);
            // 
            // cmbFac
            // 
            this.cmbFac.FormattingEnabled = true;
            this.cmbFac.Items.AddRange(new object[] {
            "Computing",
            "Engineering",
            "Business",
            "Sciences"});
            this.cmbFac.Location = new System.Drawing.Point(397, 181);
            this.cmbFac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFac.Name = "cmbFac";
            this.cmbFac.Size = new System.Drawing.Size(348, 35);
            this.cmbFac.TabIndex = 27;
            this.cmbFac.SelectedIndexChanged += new System.EventHandler(this.cmbFac_SelectedIndexChanged);
            // 
            // cmbSubGrpNum
            // 
            this.cmbSubGrpNum.FormattingEnabled = true;
            this.cmbSubGrpNum.Items.AddRange(new object[] {
            "S1",
            "S2"});
            this.cmbSubGrpNum.Location = new System.Drawing.Point(397, 561);
            this.cmbSubGrpNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSubGrpNum.Name = "cmbSubGrpNum";
            this.cmbSubGrpNum.Size = new System.Drawing.Size(348, 35);
            this.cmbSubGrpNum.TabIndex = 26;
            // 
            // cmbGrpNo
            // 
            this.cmbGrpNo.FormattingEnabled = true;
            this.cmbGrpNo.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08"});
            this.cmbGrpNo.Location = new System.Drawing.Point(397, 485);
            this.cmbGrpNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGrpNo.Name = "cmbGrpNo";
            this.cmbGrpNo.Size = new System.Drawing.Size(348, 35);
            this.cmbGrpNo.TabIndex = 25;
            // 
            // cmbAcademicSemYear
            // 
            this.cmbAcademicSemYear.FormattingEnabled = true;
            this.cmbAcademicSemYear.Items.AddRange(new object[] {
            "Y1 S1",
            "Y1 S2",
            "Y2 S1",
            "Y2 S2",
            "Y3 S1",
            "Y3 S2",
            "Y4 S1",
            "Y4 S2"});
            this.cmbAcademicSemYear.Location = new System.Drawing.Point(397, 336);
            this.cmbAcademicSemYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAcademicSemYear.Name = "cmbAcademicSemYear";
            this.cmbAcademicSemYear.Size = new System.Drawing.Size(348, 35);
            this.cmbAcademicSemYear.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(846, 650);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 50);
            this.button3.TabIndex = 19;
            this.button3.Text = "CLEAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(612, 650);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 50);
            this.button2.TabIndex = 18;
            this.button2.Text = "SAVE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(1140, 390);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "Generate IDs";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtSubGrpID
            // 
            this.txtSubGrpID.Location = new System.Drawing.Point(1051, 523);
            this.txtSubGrpID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubGrpID.Name = "txtSubGrpID";
            this.txtSubGrpID.Size = new System.Drawing.Size(281, 34);
            this.txtSubGrpID.TabIndex = 16;
            // 
            // txtGrpID
            // 
            this.txtGrpID.Location = new System.Drawing.Point(1053, 468);
            this.txtGrpID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGrpID.Name = "txtGrpID";
            this.txtGrpID.Size = new System.Drawing.Size(281, 34);
            this.txtGrpID.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(56, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Academic Year Semester";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 750);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddStudent";
            this.Text = "Add Student";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtSubGrpID;
        private System.Windows.Forms.TextBox txtGrpID;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbSubGrpNum;
        private System.Windows.Forms.ComboBox cmbGrpNo;
        private System.Windows.Forms.ComboBox cmbAcademicSemYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbDep;
        private System.Windows.Forms.ComboBox cmbFac;
        private System.Windows.Forms.TextBox txtProgramme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}