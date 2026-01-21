namespace ITIExaminationSystem
{
    partial class AppForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            username_txt = new TextBox();
            password_txt = new TextBox();
            username_lbl = new Label();
            password_lbl = new Label();
            message_lbl = new Label();
            login_btn = new Button();
            welcome_lbl = new Label();
            stat_lbl = new Label();
            noTracks_lbl = new Label();
            noCrs_lbl = new Label();
            noIns_lbl = new Label();
            noStud_lbl = new Label();
            tracks_lbl = new Label();
            course_lbl = new Label();
            instructor_lbl = new Label();
            students_lbl = new Label();
            stat_pnl = new Panel();
            logOutToolStripMenuItem1 = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            updateToolStripMenuItem1 = new ToolStripMenuItem();
            welcome_pnl = new Panel();
            addToolStripMenuItem2 = new ToolStripMenuItem();
            deleteToolStripMenuItem2 = new ToolStripMenuItem();
            updateToolStripMenuItem2 = new ToolStripMenuItem();
            addToolStripMenuItem1 = new ToolStripMenuItem();
            traToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem5 = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            coursesToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem4 = new ToolStripMenuItem();
            deleteUserToolStripMenuItem = new ToolStripMenuItem();
            updateUserToolStripMenuItem = new ToolStripMenuItem();
            addUserToolStripMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem3 = new ToolStripMenuItem();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem6 = new ToolStripMenuItem();
            menu = new MenuStrip();
            stat_pnl.SuspendLayout();
            welcome_pnl.SuspendLayout();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // username_txt
            // 
            username_txt.Location = new Point(319, 106);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(243, 27);
            username_txt.TabIndex = 0;
            username_txt.KeyDown += username_txt_KeyDown;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(321, 183);
            password_txt.Name = "password_txt";
            password_txt.PasswordChar = '*';
            password_txt.Size = new Size(241, 27);
            password_txt.TabIndex = 1;
            password_txt.KeyDown += password_txt_KeyDown;
            // 
            // username_lbl
            // 
            username_lbl.AutoSize = true;
            username_lbl.Location = new Point(195, 109);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(82, 20);
            username_lbl.TabIndex = 2;
            username_lbl.Text = "User Name";
            // 
            // password_lbl
            // 
            password_lbl.AutoSize = true;
            password_lbl.Location = new Point(195, 190);
            password_lbl.Name = "password_lbl";
            password_lbl.Size = new Size(81, 20);
            password_lbl.TabIndex = 3;
            password_lbl.Text = "Password : ";
            // 
            // message_lbl
            // 
            message_lbl.AutoSize = true;
            message_lbl.Location = new Point(277, 318);
            message_lbl.Name = "message_lbl";
            message_lbl.Size = new Size(0, 20);
            message_lbl.TabIndex = 4;
            // 
            // login_btn
            // 
            login_btn.Location = new Point(277, 260);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(94, 29);
            login_btn.TabIndex = 5;
            login_btn.Text = "Log in";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // welcome_lbl
            // 
            welcome_lbl.AutoSize = true;
            welcome_lbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            welcome_lbl.Location = new Point(98, 28);
            welcome_lbl.Name = "welcome_lbl";
            welcome_lbl.Size = new Size(139, 38);
            welcome_lbl.TabIndex = 0;
            welcome_lbl.Text = "Welcome";
            // 
            // stat_lbl
            // 
            stat_lbl.AutoSize = true;
            stat_lbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            stat_lbl.Location = new Point(211, 11);
            stat_lbl.Name = "stat_lbl";
            stat_lbl.Size = new Size(239, 38);
            stat_lbl.TabIndex = 8;
            stat_lbl.Text = "System Statistics";
            // 
            // noTracks_lbl
            // 
            noTracks_lbl.AutoSize = true;
            noTracks_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noTracks_lbl.Location = new Point(557, 128);
            noTracks_lbl.Name = "noTracks_lbl";
            noTracks_lbl.Size = new Size(42, 25);
            noTracks_lbl.TabIndex = 7;
            noTracks_lbl.Text = "100";
            // 
            // noCrs_lbl
            // 
            noCrs_lbl.AutoSize = true;
            noCrs_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noCrs_lbl.Location = new Point(408, 128);
            noCrs_lbl.Name = "noCrs_lbl";
            noCrs_lbl.Size = new Size(42, 25);
            noCrs_lbl.TabIndex = 6;
            noCrs_lbl.Text = "100";
            // 
            // noIns_lbl
            // 
            noIns_lbl.AutoSize = true;
            noIns_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noIns_lbl.Location = new Point(229, 128);
            noIns_lbl.Name = "noIns_lbl";
            noIns_lbl.Size = new Size(42, 25);
            noIns_lbl.TabIndex = 5;
            noIns_lbl.Text = "100";
            // 
            // noStud_lbl
            // 
            noStud_lbl.AutoSize = true;
            noStud_lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noStud_lbl.Location = new Point(74, 128);
            noStud_lbl.Name = "noStud_lbl";
            noStud_lbl.Size = new Size(42, 25);
            noStud_lbl.TabIndex = 4;
            noStud_lbl.Text = "100";
            // 
            // tracks_lbl
            // 
            tracks_lbl.AutoSize = true;
            tracks_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tracks_lbl.Location = new Point(543, 70);
            tracks_lbl.Name = "tracks_lbl";
            tracks_lbl.Size = new Size(71, 28);
            tracks_lbl.TabIndex = 3;
            tracks_lbl.Text = "Tracks";
            // 
            // course_lbl
            // 
            course_lbl.AutoSize = true;
            course_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            course_lbl.Location = new Point(384, 70);
            course_lbl.Name = "course_lbl";
            course_lbl.Size = new Size(85, 28);
            course_lbl.TabIndex = 2;
            course_lbl.Text = "Courses";
            // 
            // instructor_lbl
            // 
            instructor_lbl.AutoSize = true;
            instructor_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            instructor_lbl.Location = new Point(197, 70);
            instructor_lbl.Name = "instructor_lbl";
            instructor_lbl.Size = new Size(114, 28);
            instructor_lbl.TabIndex = 1;
            instructor_lbl.Text = "Instructors";
            // 
            // students_lbl
            // 
            students_lbl.AutoSize = true;
            students_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            students_lbl.Location = new Point(50, 70);
            students_lbl.Name = "students_lbl";
            students_lbl.Size = new Size(95, 28);
            students_lbl.TabIndex = 0;
            students_lbl.Text = "Students";
            // 
            // stat_pnl
            // 
            stat_pnl.Controls.Add(stat_lbl);
            stat_pnl.Controls.Add(noTracks_lbl);
            stat_pnl.Controls.Add(noCrs_lbl);
            stat_pnl.Controls.Add(noIns_lbl);
            stat_pnl.Controls.Add(noStud_lbl);
            stat_pnl.Controls.Add(tracks_lbl);
            stat_pnl.Controls.Add(course_lbl);
            stat_pnl.Controls.Add(instructor_lbl);
            stat_pnl.Controls.Add(students_lbl);
            stat_pnl.Location = new Point(73, 155);
            stat_pnl.Name = "stat_pnl";
            stat_pnl.Size = new Size(659, 210);
            stat_pnl.TabIndex = 11;
            // 
            // logOutToolStripMenuItem1
            // 
            logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            logOutToolStripMenuItem1.Size = new Size(74, 24);
            logOutToolStripMenuItem1.Text = "Log out";
            logOutToolStripMenuItem1.Click += logOutToolStripMenuItem1_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(141, 26);
            deleteToolStripMenuItem1.Text = "Update";
            // 
            // updateToolStripMenuItem1
            // 
            updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            updateToolStripMenuItem1.Size = new Size(141, 26);
            updateToolStripMenuItem1.Text = "Add";
            // 
            // welcome_pnl
            // 
            welcome_pnl.Controls.Add(welcome_lbl);
            welcome_pnl.Location = new Point(147, 57);
            welcome_pnl.Name = "welcome_pnl";
            welcome_pnl.Size = new Size(525, 92);
            welcome_pnl.TabIndex = 12;
            // 
            // addToolStripMenuItem2
            // 
            addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            addToolStripMenuItem2.Size = new Size(141, 26);
            addToolStripMenuItem2.Text = "Show";
            // 
            // deleteToolStripMenuItem2
            // 
            deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            deleteToolStripMenuItem2.Size = new Size(141, 26);
            deleteToolStripMenuItem2.Text = "Update";
            // 
            // updateToolStripMenuItem2
            // 
            updateToolStripMenuItem2.Name = "updateToolStripMenuItem2";
            updateToolStripMenuItem2.Size = new Size(141, 26);
            updateToolStripMenuItem2.Text = "Add";
            // 
            // addToolStripMenuItem1
            // 
            addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            addToolStripMenuItem1.Size = new Size(141, 26);
            addToolStripMenuItem1.Text = "Show";
            // 
            // traToolStripMenuItem
            // 
            traToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem1, updateToolStripMenuItem2, deleteToolStripMenuItem2, deleteToolStripMenuItem5 });
            traToolStripMenuItem.Name = "traToolStripMenuItem";
            traToolStripMenuItem.Size = new Size(74, 24);
            traToolStripMenuItem.Text = "Courses";
            // 
            // deleteToolStripMenuItem5
            // 
            deleteToolStripMenuItem5.Name = "deleteToolStripMenuItem5";
            deleteToolStripMenuItem5.Size = new Size(141, 26);
            deleteToolStripMenuItem5.Text = "Delete";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(141, 26);
            deleteToolStripMenuItem.Text = "Update";
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(141, 26);
            updateToolStripMenuItem.Text = "Add";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(141, 26);
            addToolStripMenuItem.Text = "Show";
            // 
            // coursesToolStripMenuItem
            // 
            coursesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, updateToolStripMenuItem, deleteToolStripMenuItem, deleteToolStripMenuItem4 });
            coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            coursesToolStripMenuItem.Size = new Size(91, 24);
            coursesToolStripMenuItem.Text = "Instructors";
            // 
            // deleteToolStripMenuItem4
            // 
            deleteToolStripMenuItem4.Name = "deleteToolStripMenuItem4";
            deleteToolStripMenuItem4.Size = new Size(141, 26);
            deleteToolStripMenuItem4.Text = "Delete";
            // 
            // deleteUserToolStripMenuItem
            // 
            deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            deleteUserToolStripMenuItem.Size = new Size(141, 26);
            deleteUserToolStripMenuItem.Text = "Update";
            // 
            // updateUserToolStripMenuItem
            // 
            updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            updateUserToolStripMenuItem.Size = new Size(141, 26);
            updateUserToolStripMenuItem.Text = "Add";
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(141, 26);
            addUserToolStripMenuItem.Text = "Show";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addUserToolStripMenuItem, updateUserToolStripMenuItem, deleteUserToolStripMenuItem, deleteToolStripMenuItem3 });
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(80, 24);
            userToolStripMenuItem.Text = "Students";
            // 
            // deleteToolStripMenuItem3
            // 
            deleteToolStripMenuItem3.Name = "deleteToolStripMenuItem3";
            deleteToolStripMenuItem3.Size = new Size(141, 26);
            deleteToolStripMenuItem3.Text = "Delete";
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
            // deleteToolStripMenuItem6
            // 
            deleteToolStripMenuItem6.Name = "deleteToolStripMenuItem6";
            deleteToolStripMenuItem6.Size = new Size(141, 26);
            deleteToolStripMenuItem6.Text = "Delete";
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, userToolStripMenuItem, coursesToolStripMenuItem, traToolStripMenuItem, logOutToolStripMenuItem, logOutToolStripMenuItem1 });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(800, 28);
            menu.TabIndex = 10;
            menu.Text = "menu";
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(stat_pnl);
            Controls.Add(welcome_pnl);
            Controls.Add(menu);
            Controls.Add(login_btn);
            Controls.Add(message_lbl);
            Controls.Add(password_lbl);
            Controls.Add(username_lbl);
            Controls.Add(password_txt);
            Controls.Add(username_txt);
            Name = "AppForm";
            Text = "ITI Examination System";
            Load += AppForm_Load;
            stat_pnl.ResumeLayout(false);
            stat_pnl.PerformLayout();
            welcome_pnl.ResumeLayout(false);
            welcome_pnl.PerformLayout();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username_txt;
        private TextBox password_txt;
        private Label username_lbl;
        private Label password_lbl;
        private Label message_lbl;
        private Button login_btn;
        private Label welcome_lbl;
        private Label stat_lbl;
        private Label noTracks_lbl;
        private Label noCrs_lbl;
        private Label noIns_lbl;
        private Label noStud_lbl;
        private Label tracks_lbl;
        private Label course_lbl;
        private Label instructor_lbl;
        private Label students_lbl;
        private Panel stat_pnl;
        private ToolStripMenuItem logOutToolStripMenuItem1;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripMenuItem updateToolStripMenuItem1;
        private Panel welcome_pnl;
        private ToolStripMenuItem addToolStripMenuItem2;
        private ToolStripMenuItem deleteToolStripMenuItem2;
        private ToolStripMenuItem updateToolStripMenuItem2;
        private ToolStripMenuItem addToolStripMenuItem1;
        private ToolStripMenuItem traToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem coursesToolStripMenuItem;
        private ToolStripMenuItem deleteUserToolStripMenuItem;
        private ToolStripMenuItem updateUserToolStripMenuItem;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private MenuStrip menu;
        private ToolStripMenuItem deleteToolStripMenuItem5;
        private ToolStripMenuItem deleteToolStripMenuItem4;
        private ToolStripMenuItem deleteToolStripMenuItem3;
        private ToolStripMenuItem deleteToolStripMenuItem6;
    }
}
