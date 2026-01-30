namespace ITIExaminationSystem.Forms
{
    partial class InstructorForm
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
            menuStrip1 = new MenuStrip();
            menu = new MenuStrip();
            dashBoardToolStripMenuItem = new ToolStripMenuItem();
            coursesToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            lblName = new Label();
            lblEmail = new Label();
            lblDepartment = new Label();
            lblSalary = new Label();
            lblGender = new Label();
            lblPhone = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            showExam_pnl = new Panel();
            label17 = new Label();
            genExam_pnl = new Panel();
            gcrsid_txt = new TextBox();
            gcrs_lbl = new Label();
            dur_nm = new NumericUpDown();
            label16 = new Label();
            button2 = new Button();
            noTF_nm = new NumericUpDown();
            noMCQ_nm = new NumericUpDown();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            dashboardpanel = new Panel();
            label1 = new Label();
            label6 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label3 = new Label();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            showExam_pnl.SuspendLayout();
            genExam_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dur_nm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noTF_nm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noMCQ_nm).BeginInit();
            dashboardpanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Location = new Point(0, 28);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(922, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(24, 24);
            menu.Items.AddRange(new ToolStripItem[] { dashBoardToolStripMenuItem, coursesToolStripMenuItem, logoutToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(5, 2, 0, 2);
            menu.Size = new Size(922, 28);
            menu.TabIndex = 1;
            menu.Text = "menuStrip2";
            // 
            // dashBoardToolStripMenuItem
            // 
            dashBoardToolStripMenuItem.Name = "dashBoardToolStripMenuItem";
            dashBoardToolStripMenuItem.Size = new Size(96, 24);
            dashBoardToolStripMenuItem.Text = "DashBoard";
            dashBoardToolStripMenuItem.Click += dashBoardToolStripMenuItem_Click;
            // 
            // coursesToolStripMenuItem
            // 
            coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            coursesToolStripMenuItem.Size = new Size(74, 24);
            coursesToolStripMenuItem.Text = "Courses";
            coursesToolStripMenuItem.Click += coursesToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(70, 24);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(47, 118);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(47, 185);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(47, 242);
            lblDepartment.Margin = new Padding(2, 0, 2, 0);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(92, 20);
            lblDepartment.TabIndex = 4;
            lblDepartment.Text = "Department:";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(440, 249);
            lblSalary.Margin = new Padding(2, 0, 2, 0);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(52, 20);
            lblSalary.TabIndex = 7;
            lblSalary.Text = "Salary:";
            lblSalary.Click += lblSalary_Click;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(448, 118);
            lblGender.Margin = new Padding(2, 0, 2, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(60, 20);
            lblGender.TabIndex = 8;
            lblGender.Text = "Gender:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(440, 185);
            lblPhone.Margin = new Padding(2, 0, 2, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(53, 20);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "Phone:";
            lblPhone.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 116);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(569, 246);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(showExam_pnl);
            panel2.Controls.Add(genExam_pnl);
            panel2.Controls.Add(dashboardpanel);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 52);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(922, 679);
            panel2.TabIndex = 12;
            panel2.Paint += panel2_Paint;
            // 
            // showExam_pnl
            // 
            showExam_pnl.Controls.Add(label17);
            showExam_pnl.Location = new Point(581, 3);
            showExam_pnl.Name = "showExam_pnl";
            showExam_pnl.Size = new Size(250, 51);
            showExam_pnl.TabIndex = 13;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(40, 5);
            label17.Name = "label17";
            label17.Size = new Size(163, 28);
            label17.TabIndex = 0;
            label17.Text = "Exam Questions";
            // 
            // genExam_pnl
            // 
            genExam_pnl.Controls.Add(gcrsid_txt);
            genExam_pnl.Controls.Add(gcrs_lbl);
            genExam_pnl.Controls.Add(dur_nm);
            genExam_pnl.Controls.Add(label16);
            genExam_pnl.Controls.Add(button2);
            genExam_pnl.Controls.Add(noTF_nm);
            genExam_pnl.Controls.Add(noMCQ_nm);
            genExam_pnl.Controls.Add(label15);
            genExam_pnl.Controls.Add(label14);
            genExam_pnl.Controls.Add(label13);
            genExam_pnl.Location = new Point(608, 84);
            genExam_pnl.Name = "genExam_pnl";
            genExam_pnl.Size = new Size(192, 233);
            genExam_pnl.TabIndex = 12;
            // 
            // gcrsid_txt
            // 
            gcrsid_txt.Enabled = false;
            gcrsid_txt.Location = new Point(89, 40);
            gcrsid_txt.Name = "gcrsid_txt";
            gcrsid_txt.Size = new Size(125, 27);
            gcrsid_txt.TabIndex = 9;
            // 
            // gcrs_lbl
            // 
            gcrs_lbl.AutoSize = true;
            gcrs_lbl.Location = new Point(3, 43);
            gcrs_lbl.Name = "gcrs_lbl";
            gcrs_lbl.Size = new Size(71, 20);
            gcrs_lbl.TabIndex = 8;
            gcrs_lbl.Text = "Course Id";
            // 
            // dur_nm
            // 
            dur_nm.Location = new Point(89, 162);
            dur_nm.Maximum = new decimal(new int[] { 240, 0, 0, 0 });
            dur_nm.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            dur_nm.Name = "dur_nm";
            dur_nm.Size = new Size(150, 27);
            dur_nm.TabIndex = 7;
            dur_nm.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 164);
            label16.Name = "label16";
            label16.Size = new Size(67, 20);
            label16.TabIndex = 6;
            label16.Text = "Duration";
            // 
            // button2
            // 
            button2.Location = new Point(37, 197);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Generate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // noTF_nm
            // 
            noTF_nm.Location = new Point(89, 116);
            noTF_nm.Name = "noTF_nm";
            noTF_nm.Size = new Size(150, 27);
            noTF_nm.TabIndex = 4;
            // 
            // noMCQ_nm
            // 
            noMCQ_nm.Location = new Point(89, 75);
            noMCQ_nm.Name = "noMCQ_nm";
            noMCQ_nm.Size = new Size(150, 27);
            noMCQ_nm.TabIndex = 3;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 118);
            label15.Name = "label15";
            label15.Size = new Size(75, 20);
            label15.TabIndex = 2;
            label15.Text = "No. of T/F";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 77);
            label14.Name = "label14";
            label14.Size = new Size(83, 20);
            label14.TabIndex = 1;
            label14.Text = "No. of Mcq";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(37, 0);
            label13.Name = "label13";
            label13.Size = new Size(109, 20);
            label13.TabIndex = 0;
            label13.Text = "Generate Exam";
            // 
            // dashboardpanel
            // 
            dashboardpanel.Controls.Add(label1);
            dashboardpanel.Controls.Add(label6);
            dashboardpanel.Controls.Add(label9);
            dashboardpanel.Controls.Add(label10);
            dashboardpanel.Controls.Add(label11);
            dashboardpanel.Controls.Add(label12);
            dashboardpanel.Location = new Point(290, 310);
            dashboardpanel.Margin = new Padding(2);
            dashboardpanel.Name = "dashboardpanel";
            dashboardpanel.Size = new Size(620, 338);
            dashboardpanel.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(439, 186);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 15;
            label1.Text = "Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(447, 119);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 14;
            label6.Text = "Gender:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(439, 250);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 13;
            label9.Text = "Salary:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(46, 243);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(92, 20);
            label10.TabIndex = 12;
            label10.Text = "Department:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(46, 186);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(49, 20);
            label11.TabIndex = 11;
            label11.Text = "Email:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(46, 119);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(52, 20);
            label12.TabIndex = 10;
            label12.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(70, 46);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(189, 23);
            label3.TabIndex = 4;
            label3.Text = "ALL Instructor Courses";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 731);
            Controls.Add(panel2);
            Controls.Add(lblPhone);
            Controls.Add(lblGender);
            Controls.Add(lblSalary);
            Controls.Add(lblDepartment);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(menuStrip1);
            Controls.Add(menu);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "InstructorForm";
            Text = "InstructorForm";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            showExam_pnl.ResumeLayout(false);
            showExam_pnl.PerformLayout();
            genExam_pnl.ResumeLayout(false);
            genExam_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dur_nm).EndInit();
            ((System.ComponentModel.ISupportInitialize)noTF_nm).EndInit();
            ((System.ComponentModel.ISupportInitialize)noMCQ_nm).EndInit();
            dashboardpanel.ResumeLayout(false);
            dashboardpanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menu;
        private ToolStripMenuItem coursesToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Label lblName;
        private Label lblEmail;
        private Label lblDepartment;
        private Label label4;
        private Label label5;
        private Label lblSalary;
        private Label lblGender;
        private Label lblPhone;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label3;
        private ToolStripMenuItem dashBoardToolStripMenuItem;
        private Panel dashboardpanel;
        private Label label1;
        private Label label6;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Panel genExam_pnl;
        private Button button2;
        private NumericUpDown noTF_nm;
        private NumericUpDown noMCQ_nm;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label16;
        private NumericUpDown dur_nm;
        private Label gcrs_lbl;
        private TextBox gcrsid_txt;
        private Panel showExam_pnl;
        private Label label17;
    }
}