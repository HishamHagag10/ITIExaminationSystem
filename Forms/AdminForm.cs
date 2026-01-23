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
using System.Text.RegularExpressions;

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
            updateStud_pnl.Visible = true;
            updateStud_pnl.Dock = DockStyle.Fill;
        }

        private void deleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            HideAllControls();
            deleteStud_pnl.Visible = true;
            deleteStud_pnl.Dock = DockStyle.Fill;
        }

        // Validate inputs before creating the DTO
        private bool TryValidateAddStudent(out string errorMessage)
        {
            errorMessage = string.Empty;

            // Username
            var username = usernameStud_txt.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(username))
            {
                errorMessage = "Username is required.";
                return false;
            }
            if (username.Length < 3)
            {
                errorMessage = "Username must be at least 3 characters.";
                return false;
            }

            // Password
            var password = passStud_txt.Text ?? string.Empty;
            if (string.IsNullOrEmpty(password))
            {
                errorMessage = "Password is required.";
                return false;
            }
            if (password.Length < 6)
            {
                errorMessage = "Password must be at least 6 characters.";
                return false;
            }

            // First/Last name
            if (string.IsNullOrWhiteSpace(fnameStud_txt.Text))
            {
                errorMessage = "First name is required.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(lnameStud_txt.Text))
            {
                errorMessage = "Last name is required.";
                return false;
            }

            // Email
            var email = emailStud_txt.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(email))
            {
                errorMessage = "Email is required.";
                return false;
            }
            // Simple email regex validation
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern, RegexOptions.IgnoreCase))
            {
                errorMessage = "Invalid email format.";
                return false;
            }

            // Phone - allow digits, spaces, +, -, ()
            var phone = phoneStud_txt.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(phone))
            {
                errorMessage = "Phone number is required.";
                return false;
            }
            var phonePattern = @"^[\d\+\-\s\(\)]+$";
            if (!Regex.IsMatch(phone, phonePattern) || phone.Length < 7)
            {
                errorMessage = "Invalid phone number.";
                return false;
            }

            // Age
            var age = (int)ageStud_nm.Value;
            if (age < 16 || age > 120)
            {
                errorMessage = "Age must be between 16 and 120.";
                return false;
            }

            // Gender - ensure at least one radio exists and one is selected
            if (!male_rdo.Checked && !female_rdo.Checked)
            {
                errorMessage = "Please select a gender.";
                return false;
            }

            // Track id
            var trackId = (int)trackidStud_nm.Value;
            if (trackId <= 0)
            {
                errorMessage = "Track Id must be greater than 0.";
                return false;
            }

            // City / Street
            if (string.IsNullOrWhiteSpace(cityStud_txt.Text))
            {
                errorMessage = "City is required.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(streetStud_txt.Text))
            {
                errorMessage = "Street is required.";
                return false;
            }

            // Zipcode - optional but if provided ensure digits only and reasonable length
            var zipcode = zipStud_txt.Text?.Trim() ?? string.Empty;
            if (!string.IsNullOrEmpty(zipcode))
            {
                if (!Regex.IsMatch(zipcode, @"^\d{3,10}$"))
                {
                    errorMessage = "Zip code must be numeric and between 3 and 10 digits.";
                    return false;
                }
            }

            return true;
        }

        private void addStud_btn_Click(object sender, EventArgs e)
        {
            // Clear previous message
            addStudMsg_lbl.Text = string.Empty;

            if (!TryValidateAddStudent(out var validationError))
            {
                addStudMsg_lbl.Text = validationError;
                return;
            }

            AddStudentDto studentDto = new AddStudentDto()
            {
                // rename the properties to match the DTO
                user_name = usernameStud_txt.Text.Trim(),
                pass = passStud_txt.Text,
                std_first_name = fnameStud_txt.Text.Trim(),
                std_last_name = lnameStud_txt.Text.Trim(),
                std_phoneno = phoneStud_txt.Text.Trim(),
                std_email = emailStud_txt.Text.Trim(),
                std_city = cityStud_txt.Text.Trim(),
                std_street = streetStud_txt.Text.Trim(),
                std_age = (int)ageStud_nm.Value,
                std_gender = male_rdo.Checked ? 'M' : 'F',
                std_zipcode = zipStud_txt.Text.Trim(),
                track_id = (int)trackidStud_nm.Value
            };
            var result = _dbManager.
                ExecuteSPWithReturn(SP.AddStudent, studentDto);
            switch (result)
            {
                case 1:
                    addStudMsg_lbl.Text = "Student added successfully";
                    break;
                case -1:
                    addStudMsg_lbl.Text = "Username already exists";
                    break;
                case -2:
                    addStudMsg_lbl.Text = "Email already exists";
                    break;
                default:
                    addStudMsg_lbl.Text = "An error occurred while adding the student";
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
                    delStudMsg_lbl.Text="Student deleted successfully";
                    break;
                default:
                    delStudMsg_lbl.Text = "An error occurred while deleting the student";
                    break;
            }
        }

        private void showUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllControls();
            showStud_grd.Visible = true;
            showStud_grd.Dock = DockStyle.Fill;
            var result = _dbManager.
                SelectMany <SelectStudentDto>(SP.SelectStudents);
            showStud_grd.DataSource = result.Data;
        }

        
    }
}
