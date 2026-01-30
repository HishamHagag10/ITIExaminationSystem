namespace ITIExaminationSystem.Forms

{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lname_lbl;
        private System.Windows.Forms.Label phone_lbl;
        private System.Windows.Forms.Label email_lbl;

       



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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            menu = new MenuStrip();
            studentToolStripMenuItem = new ToolStripMenuItem();
            iNFOToolStripMenuItem = new ToolStripMenuItem();
            coursesToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            panel01 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label9 = new Label();
            phone_lbl = new Label();
            email_lbl = new Label();
            lname_lbl = new Label();
            fname_lbl = new Label();
            welcome_lbl = new Label();
            panelexam = new Panel();
            examcorrectgrade = new Button();
            yes_btn = new Button();
            panelcouerseid = new Panel();
            label12 = new Label();
            textBox1cid = new TextBox();
            label11 = new Label();
            label10 = new Label();
            panel2 = new Panel();
            panelDetails = new Panel();
            button1 = new Button();
            label8 = new Label();
            label7 = new Label();
            label2 = new Label();
            lblCourseName = new Label();
            lblCourseId = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            exam_pnl = new Panel();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            nxt = new Button();
            ques_lbl = new Label();
            menu.SuspendLayout();
            panel01.SuspendLayout();
            panelexam.SuspendLayout();
            panelcouerseid.SuspendLayout();
            panel2.SuspendLayout();
            panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            exam_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // menu
            // 
            menu.BackColor = Color.LightGray;
            menu.ImageScalingSize = new Size(24, 24);
            menu.Items.AddRange(new ToolStripItem[] { studentToolStripMenuItem, toolStripMenuItem1, logoutToolStripMenuItem });
            menu.Location = new Point(0, 24);
            menu.Name = "menu";
            menu.Padding = new Padding(5, 2, 0, 2);
            menu.Size = new Size(1230, 28);
            menu.TabIndex = 1;
            menu.Text = "menu";
            menu.ItemClicked += menuStrip1_ItemClicked;
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { iNFOToolStripMenuItem, coursesToolStripMenuItem });
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(74, 24);
            studentToolStripMenuItem.Text = "Student";
            studentToolStripMenuItem.Click += studentToolStripMenuItem_Click;
            // 
            // iNFOToolStripMenuItem
            // 
            iNFOToolStripMenuItem.Name = "iNFOToolStripMenuItem";
            iNFOToolStripMenuItem.Size = new Size(143, 26);
            iNFOToolStripMenuItem.Text = "INFO";
            iNFOToolStripMenuItem.Click += iNFOToolStripMenuItem_Click;
            // 
            // coursesToolStripMenuItem
            // 
            coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            coursesToolStripMenuItem.Size = new Size(143, 26);
            coursesToolStripMenuItem.Text = "Courses";
            coursesToolStripMenuItem.Click += coursesToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(59, 24);
            toolStripMenuItem1.Text = "Exam";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(212, 26);
            toolStripMenuItem2.Text = "Take Exam";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(212, 26);
            toolStripMenuItem3.Text = "ShowExamAnswer";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(70, 24);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(5, 2, 0, 2);
            menuStrip2.Size = new Size(1230, 24);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // panel01
            // 
            panel01.BackColor = SystemColors.ActiveCaption;
            panel01.Controls.Add(label5);
            panel01.Controls.Add(label4);
            panel01.Controls.Add(label3);
            panel01.Controls.Add(label9);
            panel01.Controls.Add(phone_lbl);
            panel01.Controls.Add(email_lbl);
            panel01.Controls.Add(lname_lbl);
            panel01.Controls.Add(fname_lbl);
            panel01.Controls.Add(welcome_lbl);
            panel01.Location = new Point(10, 59);
            panel01.Margin = new Padding(2);
            panel01.Name = "panel01";
            panel01.Size = new Size(435, 339);
            panel01.TabIndex = 3;
            panel01.Paint += studentInfo_pnl_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 158);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 8;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(232, 158);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 7;
            label4.Text = "Phone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(221, 108);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 6;
            label3.Text = "LastName:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(2, 101);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(86, 20);
            label9.TabIndex = 5;
            label9.Text = "FirstName:";
            // 
            // phone_lbl
            // 
            phone_lbl.AutoSize = true;
            phone_lbl.Location = new Point(332, 158);
            phone_lbl.Margin = new Padding(2, 0, 2, 0);
            phone_lbl.Name = "phone_lbl";
            phone_lbl.Size = new Size(50, 20);
            phone_lbl.TabIndex = 4;
            phone_lbl.Text = "Phone";
            phone_lbl.Click += phone_lbl_Click;
            // 
            // email_lbl
            // 
            email_lbl.AutoSize = true;
            email_lbl.Location = new Point(112, 158);
            email_lbl.Margin = new Padding(2, 0, 2, 0);
            email_lbl.Name = "email_lbl";
            email_lbl.Size = new Size(46, 20);
            email_lbl.TabIndex = 3;
            email_lbl.Text = "Email";
            // 
            // lname_lbl
            // 
            lname_lbl.AutoSize = true;
            lname_lbl.Location = new Point(332, 108);
            lname_lbl.Margin = new Padding(2, 0, 2, 0);
            lname_lbl.Name = "lname_lbl";
            lname_lbl.Size = new Size(75, 20);
            lname_lbl.TabIndex = 2;
            lname_lbl.Text = "LastName";
            // 
            // fname_lbl
            // 
            fname_lbl.AutoSize = true;
            fname_lbl.Location = new Point(97, 101);
            fname_lbl.Margin = new Padding(2, 0, 2, 0);
            fname_lbl.Name = "fname_lbl";
            fname_lbl.Size = new Size(76, 20);
            fname_lbl.TabIndex = 1;
            fname_lbl.Text = "FirstName";
            // 
            // welcome_lbl
            // 
            welcome_lbl.AutoSize = true;
            welcome_lbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcome_lbl.ForeColor = Color.Black;
            welcome_lbl.Location = new Point(40, 16);
            welcome_lbl.Margin = new Padding(2, 0, 2, 0);
            welcome_lbl.Name = "welcome_lbl";
            welcome_lbl.Size = new Size(93, 25);
            welcome_lbl.TabIndex = 0;
            welcome_lbl.Text = "Welcome";
            welcome_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelexam
            // 
            panelexam.BackColor = SystemColors.ActiveCaption;
            panelexam.Controls.Add(examcorrectgrade);
            panelexam.Controls.Add(yes_btn);
            panelexam.Controls.Add(panelcouerseid);
            panelexam.Controls.Add(label10);
            panelexam.Location = new Point(264, 342);
            panelexam.Margin = new Padding(2);
            panelexam.Name = "panelexam";
            panelexam.Size = new Size(384, 333);
            panelexam.TabIndex = 5;
            panelexam.Paint += panelexam_Paint;
            // 
            // examcorrectgrade
            // 
            examcorrectgrade.BackColor = SystemColors.ControlLight;
            examcorrectgrade.Location = new Point(68, 264);
            examcorrectgrade.Margin = new Padding(2);
            examcorrectgrade.Name = "examcorrectgrade";
            examcorrectgrade.Size = new Size(113, 27);
            examcorrectgrade.TabIndex = 9;
            examcorrectgrade.Text = "Show Grade";
            examcorrectgrade.UseVisualStyleBackColor = false;
            examcorrectgrade.Click += examcorrectgrade_Click;
            // 
            // yes_btn
            // 
            yes_btn.Location = new Point(232, 264);
            yes_btn.Margin = new Padding(2);
            yes_btn.Name = "yes_btn";
            yes_btn.Size = new Size(90, 27);
            yes_btn.TabIndex = 7;
            yes_btn.Text = "Yes";
            yes_btn.UseVisualStyleBackColor = true;
            yes_btn.Click += yes_btn_Click;
            // 
            // panelcouerseid
            // 
            panelcouerseid.Controls.Add(label12);
            panelcouerseid.Controls.Add(textBox1cid);
            panelcouerseid.Controls.Add(label11);
            panelcouerseid.Location = new Point(41, 114);
            panelcouerseid.Margin = new Padding(2);
            panelcouerseid.Name = "panelcouerseid";
            panelcouerseid.Size = new Size(293, 120);
            panelcouerseid.TabIndex = 6;
            panelcouerseid.Paint += panel1_Paint;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(76, 10);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(130, 29);
            label12.TabIndex = 2;
            label12.Text = "Enter Course ID";
            // 
            // textBox1cid
            // 
            textBox1cid.Location = new Point(137, 57);
            textBox1cid.Margin = new Padding(2);
            textBox1cid.Name = "textBox1cid";
            textBox1cid.Size = new Size(121, 27);
            textBox1cid.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(18, 62);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(71, 20);
            label11.TabIndex = 0;
            label11.Text = "CourseId";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sylfaen", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(27, 23);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(335, 35);
            label10.TabIndex = 5;
            label10.Text = "Are You Ready For Exam?";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(panelDetails);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(627, 59);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(602, 385);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // panelDetails
            // 
            panelDetails.Controls.Add(button1);
            panelDetails.Controls.Add(label8);
            panelDetails.Controls.Add(label7);
            panelDetails.Controls.Add(label2);
            panelDetails.Controls.Add(lblCourseName);
            panelDetails.Controls.Add(lblCourseId);
            panelDetails.Location = new Point(330, 27);
            panelDetails.Margin = new Padding(2);
            panelDetails.Name = "panelDetails";
            panelDetails.Size = new Size(273, 265);
            panelDetails.TabIndex = 5;
            panelDetails.Paint += panelDetails_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.Location = new Point(22, 223);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 6;
            button1.Text = "Hide";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(78, 18);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 4;
            label8.Text = "CourseDetails";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 126);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(103, 20);
            label7.TabIndex = 3;
            label7.Text = "CourseName:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 70);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 2;
            label2.Text = "CourseID:";
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Location = new Point(147, 126);
            lblCourseName.Margin = new Padding(2, 0, 2, 0);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(94, 20);
            lblCourseName.TabIndex = 1;
            lblCourseName.Text = "CourseName";
            // 
            // lblCourseId
            // 
            lblCourseId.AutoSize = true;
            lblCourseId.Location = new Point(156, 70);
            lblCourseId.Margin = new Padding(2, 0, 2, 0);
            lblCourseId.Name = "lblCourseId";
            lblCourseId.Size = new Size(67, 20);
            lblCourseId.TabIndex = 0;
            lblCourseId.Text = "CourseId";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 46);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 23);
            label1.TabIndex = 4;
            label1.Text = "ALL Student Courses";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 114);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(284, 244);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // exam_pnl
            // 
            exam_pnl.Controls.Add(radioButton4);
            exam_pnl.Controls.Add(radioButton3);
            exam_pnl.Controls.Add(radioButton2);
            exam_pnl.Controls.Add(radioButton1);
            exam_pnl.Controls.Add(nxt);
            exam_pnl.Controls.Add(ques_lbl);
            exam_pnl.Location = new Point(473, 75);
            exam_pnl.Name = "exam_pnl";
            exam_pnl.Size = new Size(327, 241);
            exam_pnl.TabIndex = 6;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(34, 174);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(117, 24);
            radioButton4.TabIndex = 5;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(34, 133);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(117, 24);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(34, 92);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 24);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(34, 54);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // nxt
            // 
            nxt.Location = new Point(192, 192);
            nxt.Name = "nxt";
            nxt.Size = new Size(94, 29);
            nxt.TabIndex = 1;
            nxt.Text = "Next";
            nxt.UseVisualStyleBackColor = true;
            nxt.Click += nxt_Click;
            // 
            // ques_lbl
            // 
            ques_lbl.AutoSize = true;
            ques_lbl.Location = new Point(22, 20);
            ques_lbl.Name = "ques_lbl";
            ques_lbl.Size = new Size(66, 20);
            ques_lbl.TabIndex = 0;
            ques_lbl.Text = "question";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1230, 816);
            Controls.Add(exam_pnl);
            Controls.Add(panelexam);
            Controls.Add(panel2);
            Controls.Add(panel01);
            Controls.Add(menu);
            Controls.Add(menuStrip2);
            MainMenuStrip = menu;
            Margin = new Padding(2);
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            panel01.ResumeLayout(false);
            panel01.PerformLayout();
            panelexam.ResumeLayout(false);
            panelexam.PerformLayout();
            panelcouerseid.ResumeLayout(false);
            panelcouerseid.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelDetails.ResumeLayout(false);
            panelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            exam_pnl.ResumeLayout(false);
            exam_pnl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private MenuStrip menu;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem iNFOToolStripMenuItem;
        private ToolStripMenuItem coursesToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Panel panel01;
        private Label welcome_lbl;
        private Label ques_lbl;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label fname_lbl;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panelDetails;
        private Label lblCourseName;
        private Label lblCourseId;
        private Label label8;
        private Label label7;
        private Label label2;
        private Label label9;
        private Button button1;
        private Panel panelexam;
        private Label label10;
        private Button TakeExam;
        private Panel panelcouerseid;
        private Label label12;
        private TextBox textBox1cid;
        private Label label11;
        private Button button3;
        private Button yes_btn;
        private Button examcorrectgrade;
        private Panel exam_pnl;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button nxt;
    }
}