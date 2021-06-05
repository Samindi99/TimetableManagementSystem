﻿namespace TimeTableM
{
    partial class ManageLecturers
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
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label11;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageLecturers));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtEmpSearch = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgvMgLec = new System.Windows.Forms.DataGridView();
            this.cmbCenters = new System.Windows.Forms.ComboBox();
            this.cmbBuildings = new System.Windows.Forms.ComboBox();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtLecName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMgLec)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.ForeColor = System.Drawing.Color.Black;
            label10.Location = new System.Drawing.Point(795, 679);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(75, 31);
            label10.TabIndex = 25;
            label10.Text = "Rank";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.ForeColor = System.Drawing.Color.Black;
            label9.Location = new System.Drawing.Point(793, 614);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(76, 31);
            label9.TabIndex = 24;
            label9.Text = "Level";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.Color.Black;
            label8.Location = new System.Drawing.Point(793, 489);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(94, 31);
            label8.TabIndex = 14;
            label8.Text = "Center";
            label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Location = new System.Drawing.Point(793, 550);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(115, 31);
            label7.TabIndex = 13;
            label7.Text = "Building";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(56, 615);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(100, 31);
            label6.TabIndex = 12;
            label6.Text = "Faculty";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(56, 679);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(161, 31);
            label5.TabIndex = 11;
            label5.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(56, 554);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(167, 31);
            label4.TabIndex = 4;
            label4.Text = "Employee ID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.ForeColor = System.Drawing.Color.Black;
            label11.Location = new System.Drawing.Point(741, 178);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(167, 31);
            label11.TabIndex = 33;
            label11.Text = "Employee ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnView);
            this.panel2.Controls.Add(label11);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.txtEmpSearch);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.dgvMgLec);
            this.panel2.Controls.Add(this.cmbCenters);
            this.panel2.Controls.Add(this.cmbBuildings);
            this.panel2.Controls.Add(this.cmbLevel);
            this.panel2.Controls.Add(label10);
            this.panel2.Controls.Add(label9);
            this.panel2.Controls.Add(this.cmbFaculty);
            this.panel2.Controls.Add(this.cmbDepartment);
            this.panel2.Controls.Add(this.txtEmpID);
            this.panel2.Controls.Add(this.txtRank);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(label8);
            this.panel2.Controls.Add(label7);
            this.panel2.Controls.Add(label6);
            this.panel2.Controls.Add(label5);
            this.panel2.Controls.Add(this.txtLecName);
            this.panel2.Controls.Add(label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(-13, -34);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1363, 832);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(13, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1336, 74);
            this.panel1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(417, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 62);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Lecturer";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(40, 12);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 40);
            this.button5.TabIndex = 0;
            this.button5.Text = "BACK";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1167, 13);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 39);
            this.button4.TabIndex = 7;
            this.button4.Text = "HOME";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(69, 169);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(103, 53);
            this.btnView.TabIndex = 34;
            this.btnView.Text = "View";
            this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Honeydew;
            this.button6.Location = new System.Drawing.Point(1195, 169);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 44);
            this.button6.TabIndex = 32;
            this.button6.Text = "SEARCH";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtEmpSearch
            // 
            this.txtEmpSearch.Location = new System.Drawing.Point(939, 179);
            this.txtEmpSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpSearch.Name = "txtEmpSearch";
            this.txtEmpSearch.Size = new System.Drawing.Size(221, 34);
            this.txtEmpSearch.TabIndex = 31;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 34);
            this.textBox2.TabIndex = 30;
            // 
            // dgvMgLec
            // 
            this.dgvMgLec.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvMgLec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMgLec.Location = new System.Drawing.Point(61, 229);
            this.dgvMgLec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMgLec.Name = "dgvMgLec";
            this.dgvMgLec.RowTemplate.Height = 24;
            this.dgvMgLec.Size = new System.Drawing.Size(1082, 232);
            this.dgvMgLec.TabIndex = 29;
            // 
            // cmbCenters
            // 
            this.cmbCenters.FormattingEnabled = true;
            this.cmbCenters.Items.AddRange(new object[] {
            "Malabe",
            "Metro",
            "Matara",
            "Kandy",
            "Kurunagala",
            "Jaffna"});
            this.cmbCenters.Location = new System.Drawing.Point(996, 490);
            this.cmbCenters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCenters.Name = "cmbCenters";
            this.cmbCenters.Size = new System.Drawing.Size(316, 35);
            this.cmbCenters.TabIndex = 28;
            // 
            // cmbBuildings
            // 
            this.cmbBuildings.FormattingEnabled = true;
            this.cmbBuildings.Items.AddRange(new object[] {
            "Computing",
            "Engineering",
            "Business",
            "Humanities",
            "Sciences, "});
            this.cmbBuildings.Location = new System.Drawing.Point(995, 550);
            this.cmbBuildings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBuildings.Name = "cmbBuildings";
            this.cmbBuildings.Size = new System.Drawing.Size(316, 35);
            this.cmbBuildings.TabIndex = 27;
            // 
            // cmbLevel
            // 
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Items.AddRange(new object[] {
            "Professor",
            "Assistant Professor ",
            "Senior Lecturer(HG) ",
            "Senior Lecturer",
            "Lecturer",
            "Assistant Lecturer "});
            this.cmbLevel.Location = new System.Drawing.Point(995, 615);
            this.cmbLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(316, 35);
            this.cmbLevel.TabIndex = 26;
            this.cmbLevel.SelectedIndexChanged += new System.EventHandler(this.cmbLevel_SelectedIndexChanged);
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Items.AddRange(new object[] {
            "Computing",
            "Engineering",
            "Business",
            "Sciences"});
            this.cmbFaculty.Location = new System.Drawing.Point(283, 615);
            this.cmbFaculty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(316, 35);
            this.cmbFaculty.TabIndex = 23;
            this.cmbFaculty.SelectedIndexChanged += new System.EventHandler(this.cmbFaculty_SelectedIndexChanged);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(283, 679);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(315, 35);
            this.cmbDepartment.TabIndex = 22;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(281, 555);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(316, 34);
            this.txtEmpID.TabIndex = 21;
            // 
            // txtRank
            // 
            this.txtRank.Location = new System.Drawing.Point(995, 681);
            this.txtRank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(316, 34);
            this.txtRank.TabIndex = 20;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Green;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1163, 240);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 46);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Teal;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1163, 323);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 46);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1163, 404);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 46);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtLecName
            // 
            this.txtLecName.Location = new System.Drawing.Point(283, 495);
            this.txtLecName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLecName.Name = "txtLecName";
            this.txtLecName.Size = new System.Drawing.Size(316, 34);
            this.txtLecName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(56, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lecturer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(115, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 62);
            this.label1.TabIndex = 1;
            // 
            // ManageLecturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 795);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageLecturers";
            this.Text = "Manage Lecturer";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMgLec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbCenters;
        private System.Windows.Forms.ComboBox cmbBuildings;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtLecName;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dgvMgLec;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtEmpSearch;
        private System.Windows.Forms.TextBox textBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}