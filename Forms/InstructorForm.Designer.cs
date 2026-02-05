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
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            showExam_pnl = new Panel();
            label17 = new Label();
            genExam_pnl = new Panel();
            genBack_btn = new Button();
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
            label3 = new Label();
            dashboardpanel = new Panel();
            label2 = new Label();
            phonelbl = new Label();
            genderlbl = new Label();
            salarylbl = new Label();
            deplbl = new Label();
            Emaillbl = new Label();
            Namelbl = new Label();
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
            menuStrip1.Size = new Size(1055, 24);
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
            menu.Size = new Size(1055, 28);
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(163, 101);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(708, 338);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(showExam_pnl);
            panel2.Controls.Add(genExam_pnl);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 52);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1055, 648);
            panel2.TabIndex = 12;
            panel2.Paint += panel2_Paint;
            // 
            // showExam_pnl
            // 
            showExam_pnl.BackColor = SystemColors.ActiveCaption;
            showExam_pnl.Controls.Add(label17);
            showExam_pnl.Location = new Point(887, 34);
            showExam_pnl.Name = "showExam_pnl";
            showExam_pnl.Size = new Size(137, 133);
            showExam_pnl.TabIndex = 13;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label17.Location = new Point(417, 18);
            label17.Name = "label17";
            label17.Size = new Size(228, 38);
            label17.TabIndex = 0;
            label17.Text = "Exam Questions";
            // 
            // genExam_pnl
            // 
            genExam_pnl.Controls.Add(genBack_btn);
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
            genExam_pnl.Location = new Point(876, 190);
            genExam_pnl.Name = "genExam_pnl";
            genExam_pnl.Size = new Size(135, 233);
            genExam_pnl.TabIndex = 12;
            // 
            // genBack_btn
            // 
            genBack_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            genBack_btn.Location = new Point(180, 334);
            genBack_btn.Name = "genBack_btn";
            genBack_btn.Size = new Size(119, 48);
            genBack_btn.TabIndex = 10;
            genBack_btn.Text = "back";
            genBack_btn.UseVisualStyleBackColor = true;
            genBack_btn.Click += genBack_btn_Click;
            // 
            // gcrsid_txt
            // 
            gcrsid_txt.Enabled = false;
            gcrsid_txt.Location = new Point(376, 89);
            gcrsid_txt.Name = "gcrsid_txt";
            gcrsid_txt.Size = new Size(204, 27);
            gcrsid_txt.TabIndex = 9;
            // 
            // gcrs_lbl
            // 
            gcrs_lbl.AutoSize = true;
            gcrs_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            gcrs_lbl.Location = new Point(159, 89);
            gcrs_lbl.Name = "gcrs_lbl";
            gcrs_lbl.Size = new Size(100, 28);
            gcrs_lbl.TabIndex = 8;
            gcrs_lbl.Text = "Course Id";
            // 
            // dur_nm
            // 
            dur_nm.Location = new Point(376, 257);
            dur_nm.Maximum = new decimal(new int[] { 240, 0, 0, 0 });
            dur_nm.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            dur_nm.Name = "dur_nm";
            dur_nm.Size = new Size(204, 27);
            dur_nm.TabIndex = 7;
            dur_nm.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label16.Location = new Point(159, 256);
            label16.Name = "label16";
            label16.Size = new Size(97, 28);
            label16.TabIndex = 6;
            label16.Text = "Duration";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(376, 334);
            button2.Name = "button2";
            button2.Size = new Size(125, 48);
            button2.TabIndex = 5;
            button2.Text = "Generate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // noTF_nm
            // 
            noTF_nm.Location = new Point(376, 199);
            noTF_nm.Name = "noTF_nm";
            noTF_nm.Size = new Size(204, 27);
            noTF_nm.TabIndex = 4;
            // 
            // noMCQ_nm
            // 
            noMCQ_nm.Location = new Point(376, 142);
            noMCQ_nm.Name = "noMCQ_nm";
            noMCQ_nm.Size = new Size(204, 27);
            noMCQ_nm.TabIndex = 3;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label15.Location = new Point(159, 199);
            label15.Name = "label15";
            label15.Size = new Size(108, 28);
            label15.TabIndex = 2;
            label15.Text = "No. of T/F";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.Location = new Point(159, 149);
            label14.Name = "label14";
            label14.Size = new Size(115, 28);
            label14.TabIndex = 1;
            label14.Text = "No. of Mcq";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(264, 28);
            label13.Name = "label13";
            label13.Size = new Size(178, 31);
            label13.TabIndex = 0;
            label13.Text = "Generate Exam";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(353, 34);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(310, 38);
            label3.TabIndex = 4;
            label3.Text = "ALL Instructor Courses";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dashboardpanel
            // 
            dashboardpanel.BackColor = SystemColors.ActiveCaption;
            dashboardpanel.Controls.Add(label2);
            dashboardpanel.Controls.Add(phonelbl);
            dashboardpanel.Controls.Add(genderlbl);
            dashboardpanel.Controls.Add(salarylbl);
            dashboardpanel.Controls.Add(deplbl);
            dashboardpanel.Controls.Add(Emaillbl);
            dashboardpanel.Controls.Add(Namelbl);
            dashboardpanel.Location = new Point(113, 82);
            dashboardpanel.Margin = new Padding(2);
            dashboardpanel.Name = "dashboardpanel";
            dashboardpanel.Size = new Size(451, 161);
            dashboardpanel.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(231, 55);
            label2.Name = "label2";
            label2.Size = new Size(139, 38);
            label2.TabIndex = 16;
            label2.Text = "Welcome";
            // 
            // phonelbl
            // 
            phonelbl.AutoSize = true;
            phonelbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            phonelbl.Location = new Point(176, 218);
            phonelbl.Margin = new Padding(2, 0, 2, 0);
            phonelbl.Name = "phonelbl";
            phonelbl.Size = new Size(76, 28);
            phonelbl.TabIndex = 15;
            phonelbl.Text = "Phone:";
            // 
            // genderlbl
            // 
            genderlbl.AutoSize = true;
            genderlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            genderlbl.Location = new Point(182, 374);
            genderlbl.Margin = new Padding(2, 0, 2, 0);
            genderlbl.Name = "genderlbl";
            genderlbl.Size = new Size(83, 28);
            genderlbl.TabIndex = 14;
            genderlbl.Text = "Gender:";
            // 
            // salarylbl
            // 
            salarylbl.AutoSize = true;
            salarylbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            salarylbl.Location = new Point(182, 441);
            salarylbl.Margin = new Padding(2, 0, 2, 0);
            salarylbl.Name = "salarylbl";
            salarylbl.Size = new Size(77, 28);
            salarylbl.TabIndex = 13;
            salarylbl.Text = "Salary:";
            // 
            // deplbl
            // 
            deplbl.AutoSize = true;
            deplbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            deplbl.Location = new Point(176, 294);
            deplbl.Margin = new Padding(2, 0, 2, 0);
            deplbl.Name = "deplbl";
            deplbl.Size = new Size(130, 28);
            deplbl.TabIndex = 12;
            deplbl.Text = "Department:";
            // 
            // Emaillbl
            // 
            Emaillbl.AutoSize = true;
            Emaillbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Emaillbl.Location = new Point(182, 139);
            Emaillbl.Margin = new Padding(2, 0, 2, 0);
            Emaillbl.Name = "Emaillbl";
            Emaillbl.Size = new Size(70, 28);
            Emaillbl.TabIndex = 11;
            Emaillbl.Text = "Email:";
            // 
            // Namelbl
            // 
            Namelbl.AutoSize = true;
            Namelbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Namelbl.Location = new Point(410, 59);
            Namelbl.Margin = new Padding(2, 0, 2, 0);
            Namelbl.Name = "Namelbl";
            Namelbl.Size = new Size(73, 28);
            Namelbl.TabIndex = 10;
            Namelbl.Text = "Name:";
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 700);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            Controls.Add(dashboardpanel);
            Controls.Add(menu);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "InstructorForm";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label3;
        private ToolStripMenuItem dashBoardToolStripMenuItem;
        private Panel dashboardpanel;
        private Label phonelbl;
        private Label genderlbl;
        private Label salarylbl;
        private Label deplbl;
        private Label Emaillbl;
        private Label Namelbl;
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
        private Button genBack_btn;
        private Label label2;
    }
}