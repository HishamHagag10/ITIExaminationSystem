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
            login_btn = new Button();
            message_lbl = new Label();
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
            // login_btn
            // 
            login_btn.Location = new Point(286, 261);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(94, 29);
            login_btn.TabIndex = 5;
            login_btn.Text = "Log in";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // message_lbl
            // 
            message_lbl.AutoSize = true;
            message_lbl.Location = new Point(289, 317);
            message_lbl.Name = "message_lbl";
            message_lbl.Size = new Size(0, 20);
            message_lbl.TabIndex = 6;
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(message_lbl);
            Controls.Add(login_btn);
            Controls.Add(password_lbl);
            Controls.Add(username_lbl);
            Controls.Add(password_txt);
            Controls.Add(username_txt);
            Name = "AppForm";
            Text = "ITI Examination System";
            Load += AppForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username_txt;
        private TextBox password_txt;
        private Label username_lbl;
        private Label password_lbl;
        private Button login_btn;
        private Label message_lbl;
    }
}
