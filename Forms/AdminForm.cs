using DB_Project.DB_Repository;
using ITIExaminationSystem.DTOs;
using ITIExaminationSystem.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ITIExaminationSystem.Forms
{
    public partial class AdminForm : Form
    {
        private DB_Manager _dbManager;
        public event Action LoggedOut;
        public AdminForm(DB_Manager dbManager)
        {
            InitializeComponent();
            _dbManager = dbManager;
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            dashboardToolStripMenuItem_Click(sender, e);
        }
        private void HideAllControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Visible = false;
            }
            menu.Visible = true;
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

            HideAllControls();
            menu.Visible = true;
            stat_pnl.Visible = true;
            stat_pnl.Dock = DockStyle.Fill;

            welcome_lbl.Text = "Welcome Admin";
            noStud_lbl.Text = _dbManager.GetCount(Tabels.Student).ToString();
            noCrs_lbl.Text = _dbManager.GetCount(Tabels.Course).ToString();
            noIns_lbl.Text = _dbManager.GetCount(Tabels.Instructor).ToString();
            noTracks_lbl.Text = _dbManager.GetCount(Tabels.Track).ToString();
        }
        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoggedOut?.Invoke();
            this.Close();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllControls();
            addStud_pnl.Visible = true;
            addStud_pnl.Dock = DockStyle.Fill;

        }
        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllControls();
            addStud_pnl.Visible = true;
            addStud_pnl.Dock = DockStyle.Fill;
        }

        private void deleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            HideAllControls();
            deleteStud_pnl.Visible = true;
            deleteStud_pnl.Dock = DockStyle.Fill;
        }
        private void addStud_btn_Click(object sender, EventArgs e)
        {
            AddStudentDto studentDto = new AddStudentDto()
            {
                Username = usernameStud_txt.Text,
                Password = passStud_txt.Text,
                FirstName = fnameStud_txt.Text,
                LastName = lnameStud_txt.Text,
                Phone = phoneStud_txt.Text,
                Email = emailStud_txt.Text,
                City = cityStud_txt.Text,
                Street = streetStud_txt.Text,
                Age = (int)ageStud_nm.Value,
                ZipCode = zipStud_txt.Text,
                TrackId = (int)trackidStud_nm.Value
            };
            var result = _dbManager.
                ExecuteSPWithReturn(SP.AddStudent, studentDto);
            switch (result)
            {
                case 1:
                    MessageBox.Show("Student added successfully");
                    break;
                case -1:
                    MessageBox.Show("Username already exists");
                    break;
                case -2:
                    MessageBox.Show("Email already exists");
                    break;
                default:
                    MessageBox.Show("An error occurred while adding the student");
                    break;
            }
        }

        private void delStud_btn_Click(object sender, EventArgs e)
        {
            var result = _dbManager.
                ExecuteSPWithReturn(SP.DeleteStudent, new
                {
                    id = (int)studid_del_nm.Value
                });
            switch (result)
            {
                case 1:
                    MessageBox.Show("Student deleted successfully");
                    break;
                default:
                    MessageBox.Show("An error occurred while deleting the student");
                    break;
            }
        }
    }
}
