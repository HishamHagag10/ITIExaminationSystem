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
            coursesToolStripMenuItem = new ToolStripMenuItem();
            dashBoardToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            lblName = new Label();
            lblEmail = new Label();
            lblDepartment = new Label();
            lblSalary = new Label();
            lblGender = new Label();
            lblPhone = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            dashboardpanel = new Panel();
            label1 = new Label();
            label6 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            panelDetails = new Panel();
            button1 = new Button();
            label8 = new Label();
            label7 = new Label();
            label2 = new Label();
            label3 = new Label();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            dashboardpanel.SuspendLayout();
            panelDetails.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Location = new Point(0, 33);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1151, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(24, 24);
            menu.Items.AddRange(new ToolStripItem[] { coursesToolStripMenuItem, dashBoardToolStripMenuItem, logoutToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1151, 33);
            menu.TabIndex = 1;
            menu.Text = "menuStrip2";
            // 
            // coursesToolStripMenuItem
            // 
            coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            coursesToolStripMenuItem.Size = new Size(91, 29);
            coursesToolStripMenuItem.Text = "Courses";
            coursesToolStripMenuItem.Click += coursesToolStripMenuItem_Click;
            // 
            // dashBoardToolStripMenuItem
            // 
            dashBoardToolStripMenuItem.Name = "dashBoardToolStripMenuItem";
            dashBoardToolStripMenuItem.Size = new Size(115, 29);
            dashBoardToolStripMenuItem.Text = "DashBoard";
            dashBoardToolStripMenuItem.Click += dashBoardToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(85, 29);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(59, 147);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 25);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(59, 231);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(59, 302);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(111, 25);
            lblDepartment.TabIndex = 4;
            lblDepartment.Text = "Department:";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(550, 311);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(63, 25);
            lblSalary.TabIndex = 7;
            lblSalary.Text = "Salary:";
            lblSalary.Click += lblSalary_Click;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(560, 147);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(73, 25);
            lblGender.TabIndex = 8;
            lblGender.Text = "Gender:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(550, 231);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(66, 25);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "Phone:";
            lblPhone.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(422, 308);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(dashboardpanel);
            panel2.Controls.Add(panelDetails);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(0, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(1173, 882);
            panel2.TabIndex = 12;
            panel2.Paint += panel2_Paint;
            // 
            // dashboardpanel
            // 
            dashboardpanel.Controls.Add(label1);
            dashboardpanel.Controls.Add(label6);
            dashboardpanel.Controls.Add(label9);
            dashboardpanel.Controls.Add(label10);
            dashboardpanel.Controls.Add(label11);
            dashboardpanel.Controls.Add(label12);
            dashboardpanel.Location = new Point(277, 372);
            dashboardpanel.Name = "dashboardpanel";
            dashboardpanel.Size = new Size(775, 423);
            dashboardpanel.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(549, 233);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 15;
            label1.Text = "Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(559, 149);
            label6.Name = "label6";
            label6.Size = new Size(73, 25);
            label6.TabIndex = 14;
            label6.Text = "Gender:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(549, 313);
            label9.Name = "label9";
            label9.Size = new Size(63, 25);
            label9.TabIndex = 13;
            label9.Text = "Salary:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(58, 304);
            label10.Name = "label10";
            label10.Size = new Size(111, 25);
            label10.TabIndex = 12;
            label10.Text = "Department:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(58, 233);
            label11.Name = "label11";
            label11.Size = new Size(58, 25);
            label11.TabIndex = 11;
            label11.Text = "Email:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(58, 149);
            label12.Name = "label12";
            label12.Size = new Size(63, 25);
            label12.TabIndex = 10;
            label12.Text = "Name:";
            // 
            // panelDetails
            // 
            panelDetails.Controls.Add(button1);
            panelDetails.Controls.Add(label8);
            panelDetails.Controls.Add(label7);
            panelDetails.Controls.Add(label2);
            panelDetails.Location = new Point(714, 45);
            panelDetails.Name = "panelDetails";
            panelDetails.Size = new Size(341, 331);
            panelDetails.TabIndex = 5;
            panelDetails.Paint += panelDetails_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.Location = new Point(130, 251);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Hide";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(97, 23);
            label8.Name = "label8";
            label8.Size = new Size(128, 25);
            label8.TabIndex = 4;
            label8.Text = "CourseDetails";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 158);
            label7.Name = "label7";
            label7.Size = new Size(125, 25);
            label7.TabIndex = 3;
            label7.Text = "CourseName:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 87);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 2;
            label2.Text = "CourseID:";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(88, 57);
            label3.Name = "label3";
            label3.Size = new Size(224, 28);
            label3.TabIndex = 4;
            label3.Text = "ALL Instructor Courses";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 922);
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
            Name = "InstructorForm";
            Text = "InstructorForm";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            dashboardpanel.ResumeLayout(false);
            dashboardpanel.PerformLayout();
            panelDetails.ResumeLayout(false);
            panelDetails.PerformLayout();
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
        private Panel panelDetails;
        private Button button1;
        private Label label8;
        private Label label7;
        private Label label2;
        private Label label3;
        private ToolStripMenuItem dashBoardToolStripMenuItem;
        private Panel dashboardpanel;
        private Label label1;
        private Label label6;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}