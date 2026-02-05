using DB_Project.DB_Repository;
using DB_Project.DTOs;
using DB_Project.Helpers;
using ITIExaminationSystem.Forms;
using ITIExaminationSystem.Helpers;

namespace ITIExaminationSystem
{
    public partial class AppForm : Form
    {
        private DB_Manager _dbManager;
        private LogedUser? _logedUser;

        public AppForm()
        {
            _dbManager = new DB_Manager();
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            var _username = username_txt.Text;
            var _password = password_txt.Text;
            if (string.IsNullOrEmpty(_username) || string.IsNullOrEmpty(_password))
            {
                message_lbl.Text = "Please enter username and password";
                return;
            }
            var ret = _dbManager.SelectOne<LogedUser>(SP.Login,
                new { @user_name = _username, @pass = _password });
            if (ret.Status != 1 || ret.Data == null)
                message_lbl.Text = "Login Failed, Incorrect username or password";
            else
            {
                _logedUser = ret.Data;
                message_lbl.Text = "Successfully Logged in as " + _logedUser.Role;
                // hide user name & password & button 
                username_txt.Text = "";
                password_txt.Text = "";
                message_lbl.Text = "";
                username_txt.Select();
                switch (ret.Data.Role)
                {
                    case Role.student:
                        var stud = new StudentForm(_dbManager, _logedUser.Id);
                        stud.LoggedOut += () => this.Show();
                        stud.Show();
                        this.Hide();
                        break;
                    case Role.instructor:
                        var inst = new InstructorForm(_dbManager, _logedUser.Id);
                        inst.LoggedOut += () => this.Show();
                        inst.Show();
                        this.Hide();
                        break;
                    default:
                        var admin=new AdminForm(_dbManager);
                        admin.LoggedOut += () => this.Show();
                        admin.Show();
                        this.Hide();
                        //ShowAdminDashboard();
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
