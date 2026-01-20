using DB_Project.DB_Repository;
using DB_Project.DTOs;
using DB_Project.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITIExaminationSystem
{
    public partial class AppForm
    {
        private void login_btn_Click(object sender, EventArgs e)
        {
            _username = username_txt.Text;
            _password = password_txt.Text;
            var ret = _dbManager.SelectOne<LogedUser>("login_Sp",
                new { @user_name = _username, @pass = _password });
            if (ret.Status != 1 || ret.Data == null)
                message_lbl.Text = "Login Failed, Incorrect username or password";
            else
            {
                _logedUser = ret.Data;
                message_lbl.Text = "Successfully Logged in as ";
                // hide user name & password & button 
                username_lbl.Visible = false;
                username_txt.Visible = false;
                password_lbl.Visible = false;
                password_txt.Visible = false;
                login_btn.Visible = false;
                switch (ret.Data.Role)
                {
                    case nameof(Role.student):
                        ShowStudentDashboard();
                        break;
                    case nameof(Role.instructor):
                        ShowInstructorDashboard();
                        break;
                    default:
                        ShowAdminDashboard();
                        break;
                }
            }
        }

        private void username_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                password_txt.Select();
            }
        }

        private void password_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_btn.PerformClick();
            }
            else if (e.KeyCode == Keys.Up)
            {
                username_txt.Select();
            }

        }
    }
}
