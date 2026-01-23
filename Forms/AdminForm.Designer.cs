namespace ITIExaminationSystem.Forms
{
    partial class AdminForm
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
            components = new System.ComponentModel.Container();
            userToolStripMenuItem = new ToolStripMenuItem();
            showUserToolStripMenuItem = new ToolStripMenuItem();
            addUserToolStripMenuItem = new ToolStripMenuItem();
            updateUserToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem3 = new ToolStripMenuItem();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem2 = new ToolStripMenuItem();
            updateToolStripMenuItem1 = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            deleteToolStripMenuItem6 = new ToolStripMenuItem();
            delStud_btn = new Button();
            studid_del_nm = new NumericUpDown();
            studid_del_lbl = new Label();
            menu = new MenuStrip();
            coursesToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem4 = new ToolStripMenuItem();
            traToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem1 = new ToolStripMenuItem();
            updateToolStripMenuItem2 = new ToolStripMenuItem();
            deleteToolStripMenuItem2 = new ToolStripMenuItem();
            deleteToolStripMenuItem5 = new ToolStripMenuItem();
            logOutToolStripMenuItem1 = new ToolStripMenuItem();
            deleteStud_pnl = new Panel();
            welcome_lbl = new Label();
            stat_lbl = new Label();
            stat_pnl = new Panel();
            noTracks_lbl = new Label();
            noCrs_lbl = new Label();
            noIns_lbl = new Label();
            noStud_lbl = new Label();
            tracks_lbl = new Label();
            course_lbl = new Label();
            instructor_lbl = new Label();
            students_lbl = new Label();
            addStud_pnl = new Panel();
            stud_head_lbl = new Label();
            addStud_btn = new Button();
            genderStud_box = new GroupBox();
            male_rdo = new RadioButton();
            female_rdo = new RadioButton();
            trackidStud_nm = new NumericUpDown();
            ageStud_nm = new NumericUpDown();
            zipStud_txt = new TextBox();
            streetStud_txt = new TextBox();
            cityStud_txt = new TextBox();
            phoneStud_txt = new TextBox();
            emailStud_txt = new TextBox();
            lnameStud_txt = new TextBox();
            fnameStud_txt = new TextBox();
            passStud_txt = new TextBox();
            usernameStud_txt = new TextBox();
            trackidStud_lbl = new Label();
            ageStud_lbl = new Label();
            zipStud_lbl = new Label();
            streetStud_lbl = new Label();
            cityStud_lbl = new Label();
            phoneStud_lbl = new Label();
            emailStud_lbl = new Label();
            lnameStud_lbl = new Label();
            fnameStud_lbl = new Label();
            usernameStud_lbl = new Label();
            passStud_lbl = new Label();
            message_lbl = new Label();
            updateStud_pnl = new Panel();
            label1 = new Label();
            updateStu_btn = new Button();
            genderUpd_txt = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            trackidUpd_txt = new NumericUpDown();
            ageUpd_txt = new NumericUpDown();
            zipUpd_txt = new TextBox();
            streetUpd_txt = new TextBox();
            fnameUpd_txt = new TextBox();
            cityUpd_txt = new TextBox();
            emailUpd_txt = new TextBox();
            phoneUpd_txt = new TextBox();
            lnameUpd_txt = new TextBox();
            studidUpdate_txt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            usernameUpdate_lbl = new Label();
            label13 = new Label();
            addStudentDtoBindingSource = new BindingSource(components);
            showStud_grd = new DataGridView();
            delStudMsg_lbl = new Label();
            addStudMsg_lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)studid_del_nm).BeginInit();
            menu.SuspendLayout();
            deleteStud_pnl.SuspendLayout();
            stat_pnl.SuspendLayout();
            addStud_pnl.SuspendLayout();
            genderStud_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackidStud_nm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ageStud_nm).BeginInit();
            updateStud_pnl.SuspendLayout();
            genderUpd_txt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackidUpd_txt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ageUpd_txt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addStudentDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showStud_grd).BeginInit();
            SuspendLayout();
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showUserToolStripMenuItem, addUserToolStripMenuItem, updateUserToolStripMenuItem, deleteToolStripMenuItem3 });
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(80, 24);
            userToolStripMenuItem.Text = "Students";
            // 
            // showUserToolStripMenuItem
            // 
            showUserToolStripMenuItem.Name = "showUserToolStripMenuItem";
            showUserToolStripMenuItem.Size = new Size(141, 26);
            showUserToolStripMenuItem.Text = "Show";
            showUserToolStripMenuItem.Click += showUserToolStripMenuItem_Click;
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(141, 26);
            addUserToolStripMenuItem.Text = "Add";
            addUserToolStripMenuItem.Click += addUserToolStripMenuItem_Click;
            // 
            // updateUserToolStripMenuItem
            // 
            updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            updateUserToolStripMenuItem.Size = new Size(141, 26);
            updateUserToolStripMenuItem.Text = "Update";
            updateUserToolStripMenuItem.Click += updateUserToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem3
            // 
            deleteToolStripMenuItem3.Name = "deleteToolStripMenuItem3";
            deleteToolStripMenuItem3.Size = new Size(141, 26);
            deleteToolStripMenuItem3.Text = "Delete";
            deleteToolStripMenuItem3.Click += deleteToolStripMenuItem3_Click;
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(96, 24);
            dashboardToolStripMenuItem.Text = "Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem2, updateToolStripMenuItem1, deleteToolStripMenuItem1, deleteToolStripMenuItem6 });
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(63, 24);
            logOutToolStripMenuItem.Text = "Tracks";
            // 
            // addToolStripMenuItem2
            // 
            addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            addToolStripMenuItem2.Size = new Size(141, 26);
            addToolStripMenuItem2.Text = "Show";
            // 
            // updateToolStripMenuItem1
            // 
            updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            updateToolStripMenuItem1.Size = new Size(141, 26);
            updateToolStripMenuItem1.Text = "Add";
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(141, 26);
            deleteToolStripMenuItem1.Text = "Update";
            // 
            // deleteToolStripMenuItem6
            // 
            deleteToolStripMenuItem6.Name = "deleteToolStripMenuItem6";
            deleteToolStripMenuItem6.Size = new Size(141, 26);
            deleteToolStripMenuItem6.Text = "Delete";
            // 
            // delStud_btn
            // 
            delStud_btn.Location = new Point(276, 203);
            delStud_btn.Name = "delStud_btn";
            delStud_btn.Size = new Size(164, 36);
            delStud_btn.TabIndex = 113;
            delStud_btn.Text = "Delete Student";
            delStud_btn.UseVisualStyleBackColor = true;
            delStud_btn.Click += delStud_btn_Click;
            // 
            // studid_del_nm
            // 
            studid_del_nm.Location = new Point(388, 127);
            studid_del_nm.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            studid_del_nm.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            studid_del_nm.Name = "studid_del_nm";
            studid_del_nm.Size = new Size(150, 27);
            studid_del_nm.TabIndex = 112;
            studid_del_nm.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // studid_del_lbl
            // 
            studid_del_lbl.AutoSize = true;
            studid_del_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studid_del_lbl.Location = new Point(222, 132);
            studid_del_lbl.Name = "studid_del_lbl";
            studid_del_lbl.Size = new Size(94, 25);
            studid_del_lbl.TabIndex = 111;
            studid_del_lbl.Text = "Student Id";
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, userToolStripMenuItem, coursesToolStripMenuItem, traToolStripMenuItem, logOutToolStripMenuItem, logOutToolStripMenuItem1 });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(800, 28);
            menu.TabIndex = 84;
            menu.Text = "menu";
            // 
            // coursesToolStripMenuItem
            // 
            coursesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, updateToolStripMenuItem, deleteToolStripMenuItem, deleteToolStripMenuItem4 });
            coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            coursesToolStripMenuItem.Size = new Size(91, 24);
            coursesToolStripMenuItem.Text = "Instructors";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(141, 26);
            addToolStripMenuItem.Text = "Show";
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(141, 26);
            updateToolStripMenuItem.Text = "Add";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(141, 26);
            deleteToolStripMenuItem.Text = "Update";
            // 
            // deleteToolStripMenuItem4
            // 
            deleteToolStripMenuItem4.Name = "deleteToolStripMenuItem4";
            deleteToolStripMenuItem4.Size = new Size(141, 26);
            deleteToolStripMenuItem4.Text = "Delete";
            // 
            // traToolStripMenuItem
            // 
            traToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem1, updateToolStripMenuItem2, deleteToolStripMenuItem2, deleteToolStripMenuItem5 });
            traToolStripMenuItem.Name = "traToolStripMenuItem";
            traToolStripMenuItem.Size = new Size(74, 24);
            traToolStripMenuItem.Text = "Courses";
            // 
            // addToolStripMenuItem1
            // 
            addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            addToolStripMenuItem1.Size = new Size(141, 26);
            addToolStripMenuItem1.Text = "Show";
            // 
            // updateToolStripMenuItem2
            // 
            updateToolStripMenuItem2.Name = "updateToolStripMenuItem2";
            updateToolStripMenuItem2.Size = new Size(141, 26);
            updateToolStripMenuItem2.Text = "Add";
            // 
            // deleteToolStripMenuItem2
            // 
            deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            deleteToolStripMenuItem2.Size = new Size(141, 26);
            deleteToolStripMenuItem2.Text = "Update";
            // 
            // deleteToolStripMenuItem5
            // 
            deleteToolStripMenuItem5.Name = "deleteToolStripMenuItem5";
            deleteToolStripMenuItem5.Size = new Size(141, 26);
            deleteToolStripMenuItem5.Text = "Delete";
            // 
            // logOutToolStripMenuItem1
            // 
            logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            logOutToolStripMenuItem1.Size = new Size(74, 24);
            logOutToolStripMenuItem1.Text = "Log out";
            logOutToolStripMenuItem1.Click += logOutToolStripMenuItem1_Click;
            // 
            // deleteStud_pnl
            // 
            deleteStud_pnl.Controls.Add(delStudMsg_lbl);
            deleteStud_pnl.Controls.Add(studid_del_lbl);
            deleteStud_pnl.Controls.Add(delStud_btn);
            deleteStud_pnl.Controls.Add(studid_del_nm);
            deleteStud_pnl.Location = new Point(65, 45);
            deleteStud_pnl.Name = "deleteStud_pnl";
            deleteStud_pnl.Size = new Size(184, 99);
            deleteStud_pnl.TabIndex = 114;
            // 
            // welcome_lbl
            // 
            welcome_lbl.AutoSize = true;
            welcome_lbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            welcome_lbl.Location = new Point(256, 87);
            welcome_lbl.Name = "welcome_lbl";
            welcome_lbl.Size = new Size(139, 38);
            welcome_lbl.TabIndex = 0;
            welcome_lbl.Text = "Welcome";
            // 
            // stat_lbl
            // 
            stat_lbl.AutoSize = true;
            stat_lbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            stat_lbl.Location = new Point(296, 153);
            stat_lbl.Name = "stat_lbl";
            stat_lbl.Size = new Size(239, 38);
            stat_lbl.TabIndex = 8;
            stat_lbl.Text = "System Statistics";
            // 
            // stat_pnl
            // 
            stat_pnl.Controls.Add(noTracks_lbl);
            stat_pnl.Controls.Add(noCrs_lbl);
            stat_pnl.Controls.Add(noIns_lbl);
            stat_pnl.Controls.Add(noStud_lbl);
            stat_pnl.Controls.Add(tracks_lbl);
            stat_pnl.Controls.Add(course_lbl);
            stat_pnl.Controls.Add(instructor_lbl);
            stat_pnl.Controls.Add(students_lbl);
            stat_pnl.Controls.Add(welcome_lbl);
            stat_pnl.Controls.Add(stat_lbl);
            stat_pnl.Location = new Point(255, 45);
            stat_pnl.Name = "stat_pnl";
            stat_pnl.Size = new Size(159, 67);
            stat_pnl.TabIndex = 85;
            // 
            // noTracks_lbl
            // 
            noTracks_lbl.AutoSize = true;
            noTracks_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noTracks_lbl.Location = new Point(590, 276);
            noTracks_lbl.Name = "noTracks_lbl";
            noTracks_lbl.Size = new Size(42, 25);
            noTracks_lbl.TabIndex = 16;
            noTracks_lbl.Text = "100";
            // 
            // noCrs_lbl
            // 
            noCrs_lbl.AutoSize = true;
            noCrs_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noCrs_lbl.Location = new Point(446, 277);
            noCrs_lbl.Name = "noCrs_lbl";
            noCrs_lbl.Size = new Size(42, 25);
            noCrs_lbl.TabIndex = 15;
            noCrs_lbl.Text = "100";
            // 
            // noIns_lbl
            // 
            noIns_lbl.AutoSize = true;
            noIns_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noIns_lbl.Location = new Point(256, 277);
            noIns_lbl.Name = "noIns_lbl";
            noIns_lbl.Size = new Size(42, 25);
            noIns_lbl.TabIndex = 14;
            noIns_lbl.Text = "100";
            // 
            // noStud_lbl
            // 
            noStud_lbl.AutoSize = true;
            noStud_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noStud_lbl.Location = new Point(107, 277);
            noStud_lbl.Name = "noStud_lbl";
            noStud_lbl.Size = new Size(42, 25);
            noStud_lbl.TabIndex = 13;
            noStud_lbl.Text = "100";
            // 
            // tracks_lbl
            // 
            tracks_lbl.AutoSize = true;
            tracks_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tracks_lbl.Location = new Point(590, 218);
            tracks_lbl.Name = "tracks_lbl";
            tracks_lbl.Size = new Size(71, 28);
            tracks_lbl.TabIndex = 12;
            tracks_lbl.Text = "Tracks";
            // 
            // course_lbl
            // 
            course_lbl.AutoSize = true;
            course_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            course_lbl.Location = new Point(415, 218);
            course_lbl.Name = "course_lbl";
            course_lbl.Size = new Size(85, 28);
            course_lbl.TabIndex = 11;
            course_lbl.Text = "Courses";
            // 
            // instructor_lbl
            // 
            instructor_lbl.AutoSize = true;
            instructor_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            instructor_lbl.Location = new Point(231, 218);
            instructor_lbl.Name = "instructor_lbl";
            instructor_lbl.Size = new Size(114, 28);
            instructor_lbl.TabIndex = 10;
            instructor_lbl.Text = "Instructors";
            // 
            // students_lbl
            // 
            students_lbl.AutoSize = true;
            students_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            students_lbl.Location = new Point(82, 218);
            students_lbl.Name = "students_lbl";
            students_lbl.Size = new Size(95, 28);
            students_lbl.TabIndex = 9;
            students_lbl.Text = "Students";
            // 
            // addStud_pnl
            // 
            addStud_pnl.Controls.Add(addStudMsg_lbl);
            addStud_pnl.Controls.Add(stud_head_lbl);
            addStud_pnl.Controls.Add(addStud_btn);
            addStud_pnl.Controls.Add(genderStud_box);
            addStud_pnl.Controls.Add(trackidStud_nm);
            addStud_pnl.Controls.Add(ageStud_nm);
            addStud_pnl.Controls.Add(zipStud_txt);
            addStud_pnl.Controls.Add(streetStud_txt);
            addStud_pnl.Controls.Add(cityStud_txt);
            addStud_pnl.Controls.Add(phoneStud_txt);
            addStud_pnl.Controls.Add(emailStud_txt);
            addStud_pnl.Controls.Add(lnameStud_txt);
            addStud_pnl.Controls.Add(fnameStud_txt);
            addStud_pnl.Controls.Add(passStud_txt);
            addStud_pnl.Controls.Add(usernameStud_txt);
            addStud_pnl.Controls.Add(trackidStud_lbl);
            addStud_pnl.Controls.Add(ageStud_lbl);
            addStud_pnl.Controls.Add(zipStud_lbl);
            addStud_pnl.Controls.Add(streetStud_lbl);
            addStud_pnl.Controls.Add(cityStud_lbl);
            addStud_pnl.Controls.Add(phoneStud_lbl);
            addStud_pnl.Controls.Add(emailStud_lbl);
            addStud_pnl.Controls.Add(lnameStud_lbl);
            addStud_pnl.Controls.Add(fnameStud_lbl);
            addStud_pnl.Controls.Add(usernameStud_lbl);
            addStud_pnl.Controls.Add(passStud_lbl);
            addStud_pnl.Controls.Add(message_lbl);
            addStud_pnl.Location = new Point(639, 34);
            addStud_pnl.Name = "addStud_pnl";
            addStud_pnl.Size = new Size(140, 80);
            addStud_pnl.TabIndex = 115;
            // 
            // stud_head_lbl
            // 
            stud_head_lbl.AutoSize = true;
            stud_head_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stud_head_lbl.Location = new Point(236, 17);
            stud_head_lbl.Name = "stud_head_lbl";
            stud_head_lbl.Size = new Size(119, 25);
            stud_head_lbl.TabIndex = 136;
            stud_head_lbl.Text = "Add Student";
            // 
            // addStud_btn
            // 
            addStud_btn.Location = new Point(215, 356);
            addStud_btn.Name = "addStud_btn";
            addStud_btn.Size = new Size(167, 40);
            addStud_btn.TabIndex = 135;
            addStud_btn.Text = "Add Student";
            addStud_btn.UseVisualStyleBackColor = true;
            addStud_btn.Click += addStud_btn_Click;
            // 
            // genderStud_box
            // 
            genderStud_box.Controls.Add(male_rdo);
            genderStud_box.Controls.Add(female_rdo);
            genderStud_box.Location = new Point(327, 184);
            genderStud_box.Name = "genderStud_box";
            genderStud_box.Size = new Size(226, 55);
            genderStud_box.TabIndex = 134;
            genderStud_box.TabStop = false;
            genderStud_box.Text = "Gender";
            // 
            // male_rdo
            // 
            male_rdo.AutoSize = true;
            male_rdo.Location = new Point(27, 23);
            male_rdo.Name = "male_rdo";
            male_rdo.Size = new Size(63, 24);
            male_rdo.TabIndex = 44;
            male_rdo.TabStop = true;
            male_rdo.Text = "Male";
            male_rdo.UseVisualStyleBackColor = true;
            // 
            // female_rdo
            // 
            female_rdo.AutoSize = true;
            female_rdo.Location = new Point(124, 23);
            female_rdo.Name = "female_rdo";
            female_rdo.Size = new Size(78, 24);
            female_rdo.TabIndex = 45;
            female_rdo.TabStop = true;
            female_rdo.Text = "Female";
            female_rdo.UseVisualStyleBackColor = true;
            // 
            // trackidStud_nm
            // 
            trackidStud_nm.Location = new Point(423, 297);
            trackidStud_nm.Name = "trackidStud_nm";
            trackidStud_nm.Size = new Size(125, 27);
            trackidStud_nm.TabIndex = 133;
            // 
            // ageStud_nm
            // 
            ageStud_nm.Location = new Point(423, 247);
            ageStud_nm.Name = "ageStud_nm";
            ageStud_nm.Size = new Size(125, 27);
            ageStud_nm.TabIndex = 132;
            // 
            // zipStud_txt
            // 
            zipStud_txt.Location = new Point(423, 130);
            zipStud_txt.Name = "zipStud_txt";
            zipStud_txt.Size = new Size(125, 27);
            zipStud_txt.TabIndex = 131;
            // 
            // streetStud_txt
            // 
            streetStud_txt.Location = new Point(423, 84);
            streetStud_txt.Name = "streetStud_txt";
            streetStud_txt.Size = new Size(125, 27);
            streetStud_txt.TabIndex = 130;
            // 
            // cityStud_txt
            // 
            cityStud_txt.Location = new Point(423, 44);
            cityStud_txt.Name = "cityStud_txt";
            cityStud_txt.Size = new Size(125, 27);
            cityStud_txt.TabIndex = 129;
            // 
            // phoneStud_txt
            // 
            phoneStud_txt.Location = new Point(110, 301);
            phoneStud_txt.Name = "phoneStud_txt";
            phoneStud_txt.Size = new Size(125, 27);
            phoneStud_txt.TabIndex = 128;
            // 
            // emailStud_txt
            // 
            emailStud_txt.Location = new Point(110, 242);
            emailStud_txt.Name = "emailStud_txt";
            emailStud_txt.Size = new Size(125, 27);
            emailStud_txt.TabIndex = 127;
            // 
            // lnameStud_txt
            // 
            lnameStud_txt.Location = new Point(111, 188);
            lnameStud_txt.Name = "lnameStud_txt";
            lnameStud_txt.Size = new Size(125, 27);
            lnameStud_txt.TabIndex = 126;
            // 
            // fnameStud_txt
            // 
            fnameStud_txt.Location = new Point(111, 130);
            fnameStud_txt.Name = "fnameStud_txt";
            fnameStud_txt.Size = new Size(125, 27);
            fnameStud_txt.TabIndex = 125;
            // 
            // passStud_txt
            // 
            passStud_txt.Location = new Point(111, 88);
            passStud_txt.Name = "passStud_txt";
            passStud_txt.Size = new Size(125, 27);
            passStud_txt.TabIndex = 124;
            // 
            // usernameStud_txt
            // 
            usernameStud_txt.Location = new Point(110, 51);
            usernameStud_txt.Name = "usernameStud_txt";
            usernameStud_txt.Size = new Size(125, 27);
            usernameStud_txt.TabIndex = 123;
            // 
            // trackidStud_lbl
            // 
            trackidStud_lbl.AutoSize = true;
            trackidStud_lbl.Location = new Point(320, 304);
            trackidStud_lbl.Name = "trackidStud_lbl";
            trackidStud_lbl.Size = new Size(60, 20);
            trackidStud_lbl.TabIndex = 122;
            trackidStud_lbl.Text = "Track Id";
            // 
            // ageStud_lbl
            // 
            ageStud_lbl.AutoSize = true;
            ageStud_lbl.Location = new Point(334, 254);
            ageStud_lbl.Name = "ageStud_lbl";
            ageStud_lbl.Size = new Size(36, 20);
            ageStud_lbl.TabIndex = 121;
            ageStud_lbl.Text = "Age";
            // 
            // zipStud_lbl
            // 
            zipStud_lbl.AutoSize = true;
            zipStud_lbl.Location = new Point(322, 133);
            zipStud_lbl.Name = "zipStud_lbl";
            zipStud_lbl.Size = new Size(70, 20);
            zipStud_lbl.TabIndex = 120;
            zipStud_lbl.Text = "Zip Code";
            // 
            // streetStud_lbl
            // 
            streetStud_lbl.AutoSize = true;
            streetStud_lbl.Location = new Point(332, 91);
            streetStud_lbl.Name = "streetStud_lbl";
            streetStud_lbl.Size = new Size(48, 20);
            streetStud_lbl.TabIndex = 119;
            streetStud_lbl.Text = "Street";
            // 
            // cityStud_lbl
            // 
            cityStud_lbl.AutoSize = true;
            cityStud_lbl.Location = new Point(336, 47);
            cityStud_lbl.Name = "cityStud_lbl";
            cityStud_lbl.Size = new Size(34, 20);
            cityStud_lbl.TabIndex = 118;
            cityStud_lbl.Text = "City";
            // 
            // phoneStud_lbl
            // 
            phoneStud_lbl.AutoSize = true;
            phoneStud_lbl.Location = new Point(18, 304);
            phoneStud_lbl.Name = "phoneStud_lbl";
            phoneStud_lbl.Size = new Size(50, 20);
            phoneStud_lbl.TabIndex = 117;
            phoneStud_lbl.Text = "Phone";
            // 
            // emailStud_lbl
            // 
            emailStud_lbl.AutoSize = true;
            emailStud_lbl.Location = new Point(22, 249);
            emailStud_lbl.Name = "emailStud_lbl";
            emailStud_lbl.Size = new Size(46, 20);
            emailStud_lbl.TabIndex = 116;
            emailStud_lbl.Text = "Email";
            // 
            // lnameStud_lbl
            // 
            lnameStud_lbl.AutoSize = true;
            lnameStud_lbl.Location = new Point(17, 193);
            lnameStud_lbl.Name = "lnameStud_lbl";
            lnameStud_lbl.Size = new Size(79, 20);
            lnameStud_lbl.TabIndex = 115;
            lnameStud_lbl.Text = "Last Name";
            // 
            // fnameStud_lbl
            // 
            fnameStud_lbl.AutoSize = true;
            fnameStud_lbl.Location = new Point(14, 137);
            fnameStud_lbl.Name = "fnameStud_lbl";
            fnameStud_lbl.Size = new Size(80, 20);
            fnameStud_lbl.TabIndex = 114;
            fnameStud_lbl.Text = "First Name";
            // 
            // usernameStud_lbl
            // 
            usernameStud_lbl.AutoSize = true;
            usernameStud_lbl.Location = new Point(14, 51);
            usernameStud_lbl.Name = "usernameStud_lbl";
            usernameStud_lbl.Size = new Size(82, 20);
            usernameStud_lbl.TabIndex = 112;
            usernameStud_lbl.Text = "User Name";
            // 
            // passStud_lbl
            // 
            passStud_lbl.AutoSize = true;
            passStud_lbl.Location = new Point(14, 91);
            passStud_lbl.Name = "passStud_lbl";
            passStud_lbl.Size = new Size(70, 20);
            passStud_lbl.TabIndex = 113;
            passStud_lbl.Text = "Password";
            // 
            // message_lbl
            // 
            message_lbl.AutoSize = true;
            message_lbl.Location = new Point(150, 280);
            message_lbl.Name = "message_lbl";
            message_lbl.Size = new Size(0, 20);
            message_lbl.TabIndex = 111;
            // 
            // updateStud_pnl
            // 
            updateStud_pnl.Controls.Add(label1);
            updateStud_pnl.Controls.Add(updateStu_btn);
            updateStud_pnl.Controls.Add(genderUpd_txt);
            updateStud_pnl.Controls.Add(trackidUpd_txt);
            updateStud_pnl.Controls.Add(ageUpd_txt);
            updateStud_pnl.Controls.Add(zipUpd_txt);
            updateStud_pnl.Controls.Add(streetUpd_txt);
            updateStud_pnl.Controls.Add(fnameUpd_txt);
            updateStud_pnl.Controls.Add(cityUpd_txt);
            updateStud_pnl.Controls.Add(emailUpd_txt);
            updateStud_pnl.Controls.Add(phoneUpd_txt);
            updateStud_pnl.Controls.Add(lnameUpd_txt);
            updateStud_pnl.Controls.Add(studidUpdate_txt);
            updateStud_pnl.Controls.Add(label2);
            updateStud_pnl.Controls.Add(label3);
            updateStud_pnl.Controls.Add(label4);
            updateStud_pnl.Controls.Add(label5);
            updateStud_pnl.Controls.Add(label6);
            updateStud_pnl.Controls.Add(label7);
            updateStud_pnl.Controls.Add(label8);
            updateStud_pnl.Controls.Add(label9);
            updateStud_pnl.Controls.Add(label10);
            updateStud_pnl.Controls.Add(usernameUpdate_lbl);
            updateStud_pnl.Controls.Add(label13);
            updateStud_pnl.Location = new Point(455, 56);
            updateStud_pnl.Name = "updateStud_pnl";
            updateStud_pnl.Size = new Size(122, 58);
            updateStud_pnl.TabIndex = 116;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 136;
            label1.Text = "Update Student";
            // 
            // updateStu_btn
            // 
            updateStu_btn.Location = new Point(215, 356);
            updateStu_btn.Name = "updateStu_btn";
            updateStu_btn.Size = new Size(167, 40);
            updateStu_btn.TabIndex = 135;
            updateStu_btn.Text = "Update Student";
            updateStu_btn.UseVisualStyleBackColor = true;
            // 
            // genderUpd_txt
            // 
            genderUpd_txt.Controls.Add(radioButton1);
            genderUpd_txt.Controls.Add(radioButton2);
            genderUpd_txt.Location = new Point(327, 184);
            genderUpd_txt.Name = "genderUpd_txt";
            genderUpd_txt.Size = new Size(226, 55);
            genderUpd_txt.TabIndex = 134;
            genderUpd_txt.TabStop = false;
            genderUpd_txt.Text = "Gender";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(27, 23);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 44;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(124, 23);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 45;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // trackidUpd_txt
            // 
            trackidUpd_txt.Location = new Point(423, 297);
            trackidUpd_txt.Name = "trackidUpd_txt";
            trackidUpd_txt.Size = new Size(125, 27);
            trackidUpd_txt.TabIndex = 133;
            // 
            // ageUpd_txt
            // 
            ageUpd_txt.Location = new Point(423, 247);
            ageUpd_txt.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
            ageUpd_txt.Minimum = new decimal(new int[] { 21, 0, 0, 0 });
            ageUpd_txt.Name = "ageUpd_txt";
            ageUpd_txt.Size = new Size(125, 27);
            ageUpd_txt.TabIndex = 132;
            ageUpd_txt.Value = new decimal(new int[] { 22, 0, 0, 0 });
            // 
            // zipUpd_txt
            // 
            zipUpd_txt.Location = new Point(423, 130);
            zipUpd_txt.Name = "zipUpd_txt";
            zipUpd_txt.Size = new Size(125, 27);
            zipUpd_txt.TabIndex = 131;
            // 
            // streetUpd_txt
            // 
            streetUpd_txt.Location = new Point(423, 84);
            streetUpd_txt.Name = "streetUpd_txt";
            streetUpd_txt.Size = new Size(125, 27);
            streetUpd_txt.TabIndex = 130;
            // 
            // fnameUpd_txt
            // 
            fnameUpd_txt.Location = new Point(111, 88);
            fnameUpd_txt.Name = "fnameUpd_txt";
            fnameUpd_txt.Size = new Size(125, 27);
            fnameUpd_txt.TabIndex = 129;
            // 
            // cityUpd_txt
            // 
            cityUpd_txt.Location = new Point(110, 301);
            cityUpd_txt.Name = "cityUpd_txt";
            cityUpd_txt.Size = new Size(125, 27);
            cityUpd_txt.TabIndex = 128;
            // 
            // emailUpd_txt
            // 
            emailUpd_txt.Location = new Point(110, 242);
            emailUpd_txt.Name = "emailUpd_txt";
            emailUpd_txt.Size = new Size(125, 27);
            emailUpd_txt.TabIndex = 127;
            // 
            // phoneUpd_txt
            // 
            phoneUpd_txt.Location = new Point(111, 188);
            phoneUpd_txt.Name = "phoneUpd_txt";
            phoneUpd_txt.Size = new Size(125, 27);
            phoneUpd_txt.TabIndex = 126;
            // 
            // lnameUpd_txt
            // 
            lnameUpd_txt.Location = new Point(111, 130);
            lnameUpd_txt.Name = "lnameUpd_txt";
            lnameUpd_txt.Size = new Size(125, 27);
            lnameUpd_txt.TabIndex = 125;
            // 
            // studidUpdate_txt
            // 
            studidUpdate_txt.Location = new Point(410, 17);
            studidUpdate_txt.Name = "studidUpdate_txt";
            studidUpdate_txt.Size = new Size(125, 27);
            studidUpdate_txt.TabIndex = 123;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(320, 304);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 122;
            label2.Text = "Track Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(334, 254);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 121;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(322, 133);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 120;
            label4.Text = "Zip Code";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(332, 91);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 119;
            label5.Text = "Street";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 308);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 118;
            label6.Text = "City";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 195);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 117;
            label7.Text = "Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 249);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 116;
            label8.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 135);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 115;
            label9.Text = "Last Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 91);
            label10.Name = "label10";
            label10.Size = new Size(80, 20);
            label10.TabIndex = 114;
            label10.Text = "First Name";
            // 
            // usernameUpdate_lbl
            // 
            usernameUpdate_lbl.AutoSize = true;
            usernameUpdate_lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameUpdate_lbl.Location = new Point(287, 21);
            usernameUpdate_lbl.Name = "usernameUpdate_lbl";
            usernameUpdate_lbl.Size = new Size(82, 20);
            usernameUpdate_lbl.TabIndex = 112;
            usernameUpdate_lbl.Text = "Student Id";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(150, 280);
            label13.Name = "label13";
            label13.Size = new Size(0, 20);
            label13.TabIndex = 111;
            // 
            // addStudentDtoBindingSource
            // 
            addStudentDtoBindingSource.DataSource = typeof(DTOs.AddStudentDto);
            // 
            // showStud_grd
            // 
            showStud_grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            showStud_grd.Location = new Point(620, 140);
            showStud_grd.Name = "showStud_grd";
            showStud_grd.RowHeadersWidth = 51;
            showStud_grd.Size = new Size(159, 113);
            showStud_grd.TabIndex = 117;
            // 
            // delStudMsg_lbl
            // 
            delStudMsg_lbl.AutoSize = true;
            delStudMsg_lbl.Location = new Point(273, 252);
            delStudMsg_lbl.Name = "delStudMsg_lbl";
            delStudMsg_lbl.Size = new Size(0, 20);
            delStudMsg_lbl.TabIndex = 114;
            // 
            // addStudMsg_lbl
            // 
            addStudMsg_lbl.AutoSize = true;
            addStudMsg_lbl.Location = new Point(423, 366);
            addStudMsg_lbl.Name = "addStudMsg_lbl";
            addStudMsg_lbl.Size = new Size(0, 20);
            addStudMsg_lbl.TabIndex = 137;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(showStud_grd);
            Controls.Add(updateStud_pnl);
            Controls.Add(deleteStud_pnl);
            Controls.Add(addStud_pnl);
            Controls.Add(menu);
            Controls.Add(stat_pnl);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)studid_del_nm).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            deleteStud_pnl.ResumeLayout(false);
            deleteStud_pnl.PerformLayout();
            stat_pnl.ResumeLayout(false);
            stat_pnl.PerformLayout();
            addStud_pnl.ResumeLayout(false);
            addStud_pnl.PerformLayout();
            genderStud_box.ResumeLayout(false);
            genderStud_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackidStud_nm).EndInit();
            ((System.ComponentModel.ISupportInitialize)ageStud_nm).EndInit();
            updateStud_pnl.ResumeLayout(false);
            updateStud_pnl.PerformLayout();
            genderUpd_txt.ResumeLayout(false);
            genderUpd_txt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackidUpd_txt).EndInit();
            ((System.ComponentModel.ISupportInitialize)ageUpd_txt).EndInit();
            ((System.ComponentModel.ISupportInitialize)addStudentDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)showStud_grd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem showUserToolStripMenuItem;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private ToolStripMenuItem updateUserToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem3;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem2;
        private ToolStripMenuItem updateToolStripMenuItem1;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripMenuItem deleteToolStripMenuItem6;
        private Button delStud_btn;
        private NumericUpDown studid_del_nm;
        private Label studid_del_lbl;
        private MenuStrip menu;
        private ToolStripMenuItem coursesToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem4;
        private ToolStripMenuItem traToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem1;
        private ToolStripMenuItem updateToolStripMenuItem2;
        private ToolStripMenuItem deleteToolStripMenuItem2;
        private ToolStripMenuItem deleteToolStripMenuItem5;
        private ToolStripMenuItem logOutToolStripMenuItem1;
        private Label welcome_lbl;
        private Label stat_lbl;
        private Panel stat_pnl;
        private Panel deleteStud_pnl;
        private Panel addStud_pnl;
        private Button addStud_btn;
        private GroupBox genderStud_box;
        private RadioButton male_rdo;
        private RadioButton female_rdo;
        private NumericUpDown trackidStud_nm;
        private NumericUpDown ageStud_nm;
        private TextBox zipStud_txt;
        private TextBox streetStud_txt;
        private TextBox cityStud_txt;
        private TextBox phoneStud_txt;
        private TextBox emailStud_txt;
        private TextBox lnameStud_txt;
        private TextBox fnameStud_txt;
        private TextBox passStud_txt;
        private TextBox usernameStud_txt;
        private Label trackidStud_lbl;
        private Label ageStud_lbl;
        private Label zipStud_lbl;
        private Label streetStud_lbl;
        private Label cityStud_lbl;
        private Label phoneStud_lbl;
        private Label emailStud_lbl;
        private Label lnameStud_lbl;
        private Label fnameStud_lbl;
        private Label usernameStud_lbl;
        private Label passStud_lbl;
        private Label message_lbl;
        private Label noTracks_lbl;
        private Label noCrs_lbl;
        private Label noIns_lbl;
        private Label noStud_lbl;
        private Label tracks_lbl;
        private Label course_lbl;
        private Label instructor_lbl;
        private Label students_lbl;
        private Label stud_head_lbl;
        private Panel updateStud_pnl;
        private Label label1;
        private Button updateStu_btn;
        private GroupBox genderUpd_txt;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private NumericUpDown trackidUpd_txt;
        private NumericUpDown ageUpd_txt;
        private TextBox zipUpd_txt;
        private TextBox streetUpd_txt;
        private TextBox fnameUpd_txt;
        private TextBox cityUpd_txt;
        private TextBox emailUpd_txt;
        private TextBox phoneUpd_txt;
        private TextBox lnameUpd_txt;
        private TextBox studidUpdate_txt;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label usernameUpdate_lbl;
        private Label label13;
        private BindingSource addStudentDtoBindingSource;
        private DataGridView showStud_grd;
        private Label delStudMsg_lbl;
        private Label addStudMsg_lbl;
    }
}