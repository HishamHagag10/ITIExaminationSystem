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
using System.Linq;

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
            //stat_pnl.Dock = DockStyle.Fill;

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
            ClearAddStudentForm();
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
                addStudMsg_lbl.ForeColor = Color.Red;
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
                    addStudMsg_lbl.ForeColor = Color.Green;
                    addStudMsg_lbl.Text = "Student added successfully";
                    // clear the form for next entry
                    ClearAddStudentForm();
                    break;
                case -1:
                    addStudMsg_lbl.ForeColor = Color.Red;
                    addStudMsg_lbl.Text = "Username already exists";
                    break;
                case -2:
                    addStudMsg_lbl.ForeColor = Color.Red;
                    addStudMsg_lbl.Text = "Email already exists";
                    break;
                default:
                    addStudMsg_lbl.ForeColor = Color.Red;
                    addStudMsg_lbl.Text = "An error occurred while adding the student";
                    break;
            }
        }

        private void showUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllControls();
            menu.Visible = true;
            // load students and show panel
            var res = _dbManager.SelectMany<SelectStudentDto>(SP.SelectStudents);
            if (res != null && res.Data != null)
            {
                var list = res.Data.Select(s => new { s.Id, s.FullName, s.Phone, s.TrackId }).ToList();
                students_dgv.DataSource = list;
            }
            students_dgv.ClearSelection();
            dgvUpdate_btn.Enabled = false;
            dgvDelete_btn.Enabled = false;
            showStud_pnl.Visible = true;
            showStud_pnl.Dock = DockStyle.Fill;
        }

        private void students_dgv_SelectionChanged(object? sender, EventArgs e)
        {
            if (students_dgv.SelectedRows.Count == 1)
            {
                dgvUpdate_btn.Enabled = true;
                dgvDelete_btn.Enabled = true;
            }
            else
            {
                dgvUpdate_btn.Enabled = false;
                dgvDelete_btn.Enabled = false;
            }
        }

        private void dgvUpdate_btn_Click(object? sender, EventArgs e)
        {
            if (students_dgv.SelectedRows.Count != 1) return;
            var id = (int)students_dgv.SelectedRows[0].Cells["Id"].Value;
            HideAllControls();
            updateStud_pnl.Visible = true;
            updateStud_pnl.Dock = DockStyle.Fill;
            studidUpdate_txt.Text = id.ToString();
            // load full student details if available
            var detailRes = _dbManager.SelectOne<AddStudentDto>
                (SP.SelectStudent, new { id = id });
            if (detailRes != null && detailRes.Data != null)
            {
                var d = detailRes.Data;
                fnameUpd_txt.Text = d.std_first_name;
                lnameUpd_txt.Text = d.std_last_name;
                phoneUpd_txt.Text = d.std_phoneno;
                emailUpd_txt.Text = d.std_email;
                cityUpd_txt.Text = d.std_city;
                streetUpd_txt.Text = d.std_street;
                zipUpd_txt.Text = d.std_zipcode;
                ageUpd_txt.Value = Math.Min(Math.Max(d.std_age, (int)ageUpd_txt.Minimum), (int)ageUpd_txt.Maximum);
                try { trackidUpd_txt.Value = Math.Max(trackidUpd_txt.Minimum, d.track_id); } catch { }
                if (d.std_gender == 'M') { radioButton1.Checked = true; radioButton2.Checked = false; }
                else if (d.std_gender == 'F') { radioButton2.Checked = true; radioButton1.Checked = false; }
            }
        }

        // Validate update inputs
        private bool TryValidateUpdateStudent(out string errorMessage)
        {
            errorMessage = string.Empty;
            if (!int.TryParse(studidUpdate_txt.Text, out int sid) || sid <= 0)
            {
                errorMessage = "Invalid student id.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(fnameUpd_txt.Text))
            {
                errorMessage = "First name is required.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(lnameUpd_txt.Text))
            {
                errorMessage = "Last name is required.";
                return false;
            }
            var email = emailUpd_txt.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(email))
            {
                errorMessage = "Email is required.";
                return false;
            }
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern, RegexOptions.IgnoreCase))
            {
                errorMessage = "Invalid email format.";
                return false;
            }
            var phone = phoneUpd_txt.Text?.Trim() ?? string.Empty;
            var phonePattern = @"^[\d\+\-\s\(\)]+$";
            if (string.IsNullOrWhiteSpace(phone) || !Regex.IsMatch(phone, phonePattern) || phone.Length < 7)
            {
                errorMessage = "Invalid phone number.";
                return false;
            }
            var age = (int)ageUpd_txt.Value;
            if (age < 16 || age > 120)
            {
                errorMessage = "Age must be between 16 and 120.";
                return false;
            }
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                errorMessage = "Please select a gender.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(cityUpd_txt.Text))
            {
                errorMessage = "City is required.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(streetUpd_txt.Text))
            {
                errorMessage = "Street is required.";
                return false;
            }
            var zipcode = zipUpd_txt.Text?.Trim() ?? string.Empty;
            if (!string.IsNullOrEmpty(zipcode) && !Regex.IsMatch(zipcode, @"^\d{3,10}$"))
            {
                errorMessage = "Zip code must be numeric and between 3 and 10 digits.";
                return false;
            }
            if ((int)trackidUpd_txt.Value <= 0)
            {
                errorMessage = "Track Id must be greater than 0.";
                return false;
            }
            return true;
        }

        private void updateStu_btn_Click(object? sender, EventArgs e)
        {
            // Use studidUpdate_txt to get the student id and other fields in updateStud_pnl to update
            if (!int.TryParse(studidUpdate_txt.Text, out int id))
            {
                MessageBox.Show("Invalid Student Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // minimal validation
            if (!TryValidateUpdateStudent(out var validationError))
            {
                updStudMsg_lbl.ForeColor = Color.Red;
                updStudMsg_lbl.Text = validationError;
                return;
            }

            var updateDto = new
            {
                std_id = id,
                std_first_name = fnameUpd_txt.Text.Trim(),
                std_last_name = lnameUpd_txt.Text.Trim(),
                std_phoneno = phoneUpd_txt.Text.Trim(),
                std_email = emailUpd_txt.Text.Trim(),
                std_street = streetUpd_txt.Text.Trim(),
                std_zipcode = zipUpd_txt.Text.Trim(),
                std_city = cityUpd_txt.Text.Trim(),
                std_age = (int)ageUpd_txt.Value,
                std_gender = radioButton1.Checked ? 'M' : (radioButton2.Checked ? 'F' : ' '),
                track_id = (int)trackidUpd_txt.Value
            };

            var result = _dbManager.ExecuteSPWithReturn(SP.UpdateStudent, updateDto);
            if (result == 1)
            {
                opMsg_lbl.ForeColor = Color.Green;
                opMsg_lbl.Text="Student updated successfully";
                // go back to list
                showUserToolStripMenuItem_Click(sender, e);
            }
            else
            {
                opMsg_lbl.ForeColor = Color.Red;
                opMsg_lbl.Text = "Failed to update student";
            }
        }

        private void dgvDelete_btn_Click(object? sender, EventArgs e)
        {
            if (students_dgv.SelectedRows.Count != 1) return;
            var id = (int)students_dgv.SelectedRows[0].Cells["Id"].Value;
            var result = _dbManager.
                ExecuteSPWithReturn(SP.DeleteStudent, new
                {
                    id
                });
            switch (result)
            {
                case 1:
                    //MessageBox.Show("Success");
                    opMsg_lbl.ForeColor = Color.Green;
                    opMsg_lbl.Text = "Student deleted successfully";
                    showUserToolStripMenuItem_Click(sender, e);
                    break;
                default:
                    //MessageBox.Show("error");
                    opMsg_lbl.ForeColor = Color.Red;
                    opMsg_lbl.Text = "An error occurred while deleting the student";
                    break;
            }

        }

        // Helper to clear all add-student fields
        private void ClearAddStudentForm()
        {
            usernameStud_txt.Text = string.Empty;
            passStud_txt.Text = string.Empty;
            fnameStud_txt.Text = string.Empty;
            lnameStud_txt.Text = string.Empty;
            emailStud_txt.Text = string.Empty;
            phoneStud_txt.Text = string.Empty;
            cityStud_txt.Text = string.Empty;
            streetStud_txt.Text = string.Empty;
            zipStud_txt.Text = string.Empty;
            ageStud_nm.Value = Math.Min(Math.Max(22, ageStud_nm.Minimum), ageStud_nm.Maximum);
            trackidStud_nm.Value = Math.Max(trackidStud_nm.Minimum, 1);
            male_rdo.Checked = false;
            female_rdo.Checked = false;
            //addStudMsg_lbl.Text = string.Empty;
        }

        // Reset button handler
        private void resetAdd_btn_Click(object sender, EventArgs e)
        {
            ClearAddStudentForm();
        }
        
    }
}
