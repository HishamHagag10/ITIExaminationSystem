using DB_Project.DB_Repository;
using ITIExaminationSystem.DTOs;
using ITIExaminationSystem.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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
            addStud_btn.Visible = true;
            resetAdd_btn.Visible = true;
            updateStu_btn.Visible = false;
            stud_head_lbl.Text = "Add Student";
            usernameStud_txt.Enabled = true;
            passStud_txt.Enabled = true;
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

           var list = res.Data
        .Select(s => new
        {
            s.Id,
            s.FullName,
            s.Phone,
            s.TrackId,
            s.is_active   
        })
        .ToList();
                students_dgv.DataSource = list;

           
                    students_dgv.DataSource = res.Data;
                if (!students_dgv.Columns.Contains("is_active"))
                {
                    var col = new DataGridViewCheckBoxColumn();
                    col.Name = "is_active";
                    col.HeaderText = "Active";
                    col.DataPropertyName = "is_active";
                    col.Visible = true;
                    col.ReadOnly = true;
                    students_dgv.Columns.Add(col);
                }
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
            var id = (int)students_dgv.SelectedRows[0].Cells["stdId"].Value;

            // Show add student panel for update (like instructor update)
            HideAllControls();
            addStud_pnl.Visible = true;
            addStud_pnl.Dock = DockStyle.Fill;

            // Configure buttons - hide add/reset, show update
            addStud_btn.Visible = false;
            resetAdd_btn.Visible = false;
            updateStu_btn.Visible = true;

            // Change header
            stud_head_lbl.Text = "Update Student";

            // Disable username and password fields (cannot edit credentials)
            usernameStud_txt.Enabled = false;
            passStud_txt.Enabled = false;

            // Load student details from database
            var detailRes = _dbManager.SelectOne<AddStudentDto>(SP.SelectStudent, new { id = id });
            if (detailRes != null && detailRes.Data != null)
            {
                var d = detailRes.Data;
                usernameStud_txt.Text = d.user_name;
                passStud_txt.Text = d.pass;
                fnameStud_txt.Text = d.std_first_name;
                lnameStud_txt.Text = d.std_last_name;
                emailStud_txt.Text = d.std_email;
                phoneStud_txt.Text = d.std_phoneno;
                cityStud_txt.Text = d.std_city;
                streetStud_txt.Text = d.std_street;
                zipStud_txt.Text = d.std_zipcode;
                ageStud_nm.Value = Math.Min(Math.Max(d.std_age, (int)ageStud_nm.Minimum), (int)ageStud_nm.Maximum);
                try { trackidStud_nm.Value = Math.Max(trackidStud_nm.Minimum, d.track_id); } catch { }

                // Set gender
                if (d.std_gender == 'M')
                {
                    male_rdo.Checked = true;
                    female_rdo.Checked = false;
                }
                else if (d.std_gender == 'F')
                {
                    female_rdo.Checked = true;
                    male_rdo.Checked = false;
                }
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
            // Clear previous message
            addStudMsg_lbl.Text = string.Empty;

            // Get student ID from the selected row in the grid
            if (students_dgv.SelectedRows.Count != 1)
            {
                addStudMsg_lbl.ForeColor = Color.Red;
                addStudMsg_lbl.Text = "Invalid student selection.";
                return;
            }

            int id = (int)students_dgv.SelectedRows[0].Cells["stdId"].Value;

            // Validate all editable fields (using addStud validation)
            if (!TryValidateAddStudent(out var validationError))
            {
                addStudMsg_lbl.ForeColor = Color.Red;
                addStudMsg_lbl.Text = validationError;
                return;
            }

            // Create DTO with student ID and updated fields from addStud_pnl
            var dto = new
            {
                user_id = id,
                std_first_name = fnameStud_txt.Text.Trim(),
                std_last_name = lnameStud_txt.Text.Trim(),
                std_phoneno = phoneStud_txt.Text.Trim(),
                std_email = emailStud_txt.Text.Trim(),
                std_street = streetStud_txt.Text.Trim(),
                std_zipcode = zipStud_txt.Text.Trim(),
                std_city = cityStud_txt.Text.Trim(),
                std_age = (int)ageStud_nm.Value,
                std_gender = male_rdo.Checked ? "M" : (female_rdo.Checked ? "F" : (string?)null),
                track_id = (int)trackidStud_nm.Value
            };

            var cellValue = students_dgv.SelectedRows[0].Cells["is_active"].Value;
            bool isActive = cellValue != null && Convert.ToBoolean(cellValue);
            if (!isActive)
            {
                addStudMsg_lbl.ForeColor = Color.Red;
                addStudMsg_lbl.Text = "This Account has been deleted before,NO Operation will be performed ";
                return;
            }


            // Execute update
            var result = _dbManager.ExecuteSPWithReturn(SP.UpdateStudent, dto);
            if (result == 1)
            {
                addStudMsg_lbl.ForeColor = Color.Green;
                addStudMsg_lbl.Text = "Student updated successfully";
                // Refresh the student list
                showUserToolStripMenuItem_Click(sender, e);
            }
            else
            {
                addStudMsg_lbl.ForeColor = Color.Red;
                addStudMsg_lbl.Text = "Failed to update student";
            }
        }

        private void dgvDelete_btn_Click(object? sender, EventArgs e)
        {
         
            if (students_dgv.SelectedRows.Count != 1) return;

            if (!students_dgv.Columns.Contains("is_active"))
            {
                opMsg_lbl.ForeColor = Color.Red;
                opMsg_lbl.Text = "Cannot validate student status. Column missing.";
                return;
            }

            var cellValue = students_dgv.SelectedRows[0].Cells["is_active"].Value;
            bool isActive = cellValue != null && Convert.ToBoolean(cellValue);

            if (!isActive)
            {
                opMsg_lbl.ForeColor = Color.Red;
                opMsg_lbl.Text = "This Account has been deleted before,NO Operation will be performed";
                return;
            }






            var id = (int)students_dgv.SelectedRows[0].Cells["stdId"].Value;

          
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

        private void showInstructors()
        {
            HideAllControls();
            menu.Visible = true;

            var res = _dbManager.SelectMany<SelectInstructorDto>(SP.SelectInstructors);
            if (res != null && res.Data != null)
            {
                instructors_dgv.AutoGenerateColumns = false;
                instructors_dgv.Columns.Clear(); 

                // Text Columns
                instructors_dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Id",
                    HeaderText = "ID",
                    DataPropertyName = "Id"
                });
                instructors_dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Name",
                    HeaderText = "Name",
                    DataPropertyName = "Name"
                });
                instructors_dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Phone",
                    HeaderText = "Phone",
                    DataPropertyName = "Phone"
                });
                instructors_dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Salary",
                    HeaderText = "Salary",
                    DataPropertyName = "Salary"
                });

                // Checkbox Column for IsActive
                instructors_dgv.Columns.Add(new DataGridViewCheckBoxColumn
                {
                    Name = "is_active",
                    HeaderText = "Active",
                    DataPropertyName = "is_active", 
                    ReadOnly = true
                });

               //DataSource
                instructors_dgv.DataSource = res.Data;
                instructors_dgv.Refresh();
            }

            instructors_dgv.ClearSelection();
            insUpdate_btn.Enabled = false;
            insDelete_btn.Enabled = false;
            showIns_pnl.Visible = true;
            showIns_pnl.Dock = DockStyle.Fill;
        }
            //HideAllControls();
            //menu.Visible = true;

            //var res = _dbManager.SelectMany<SelectInstructorDto>(SP.SelectInstructors);
            //if (res != null && res.Data != null)
            //{
            //    var list = res.Data.Select(i => new { i.Id, i.Name, i.Phone, i.Salary }).ToList();
            //    instructors_dgv.DataSource = list;
            //}
            //instructors_dgv.ClearSelection();
            //insUpdate_btn.Enabled = false;
            //insDelete_btn.Enabled = false;
            //showIns_pnl.Visible = true;
            //showIns_pnl.Dock = DockStyle.Fill;
            //}
        

        private void instructors_dgv_SelectionChanged(object? sender, EventArgs e)
        {
            if (instructors_dgv.SelectedRows.Count == 1)
            {
                insUpdate_btn.Enabled = true;
                insDelete_btn.Enabled = true;
            }
            else
            {
                insUpdate_btn.Enabled = false;
                insDelete_btn.Enabled = false;
            }
        }

        private void insUpdate_btn_Click(object? sender, EventArgs e)
        {
            if (instructors_dgv.SelectedRows.Count != 1) return;
         

            bool isActive = (bool)instructors_dgv.SelectedRows[0].Cells["is_active"].Value;
            if (!isActive)
            {
                insMsg_lbl.ForeColor = Color.Red;
                insMsg_lbl.Text = "This account has been deactivated. You cannot update it.";
                return;
            }

            var id = (int)instructors_dgv.SelectedRows[0].Cells["Id"].Value;
            // show add/update instructor panel with id prefilled
            HideAllControls();
            addIns_pnl.Visible = true;
            addIns_btn.Visible = false;
            resetIns_btn.Visible = false;
            ipdIns_btn.Visible = true;
            addInsHead_lbl.Text = "Update Instructor";
            ins_username_txt.Enabled = false;
            ins_pass_txt.Enabled = false;
            addIns_pnl.Dock = DockStyle.Fill;
            // load instructor details if proc available
            var res = _dbManager.SelectOne<AddInstructorDto>(SP.SelectInstructor, new { id = id });
            if (res != null && res.Data != null)
            {
                var d = res.Data;
                ins_username_txt.Text = d.user_name;
                ins_pass_txt.Text = d.pass;
                ins_name_txt.Text = d.ins_name;
                ins_phone_txt.Text = d.ins_phoneNo ?? string.Empty;
                ins_email_txt.Text = d.ins_email ?? string.Empty;
                ins_salary_nm.Value = d.ins_salary;
                ins_dob_picker.Value = d.ins_dob;
                ins_city_txt.Text = d.ins_city ?? string.Empty;
                ins_street_txt.Text = d.ins_street ?? string.Empty;
                if (d.ins_gender == 'M') { ins_male_rdo.Checked = true; ins_female_rdo.Checked = false; }
                else if (d.ins_gender == 'F') { ins_female_rdo.Checked = true; ins_male_rdo.Checked = false; }
            }
        }

        private void insDelete_btn_Click(object? sender, EventArgs e)
        {
            if (instructors_dgv.SelectedRows.Count != 1) return;
            bool isActive = (bool)instructors_dgv.SelectedRows[0].Cells["is_active"].Value;
            if (!isActive)
            {
                insMsg_lbl.ForeColor = Color.Red;
                insMsg_lbl.Text = "This account has been deactivated. You cannot delete it.";
                return;
            }
            var id = (int)instructors_dgv.SelectedRows[0].Cells["Id"].Value;
            var result = _dbManager.ExecuteSPWithReturn(SP.DeleteInstructor, new { id = id });
            if (result == 1)
            {
                insMsg_lbl.ForeColor = Color.Green;
                insMsg_lbl.Text = "Instructor deleted successfully";
                showInstructors();
            }
            else
            {
                insMsg_lbl.ForeColor = Color.Red;
                insMsg_lbl.Text = "Failed to delete instructor";
            }
        }
        private void addIns_btn_Click(object? sender, EventArgs e)
        {
            // Clear previous message
            addInsMsg_lbl.Text = string.Empty;

            if (!TryValidateAddInstructor(out var validationError))
            {
                addInsMsg_lbl.ForeColor = Color.Red;
                addInsMsg_lbl.Text = validationError;
                return;
            }

            var dto = new AddInstructorDto()
            {
                user_name = ins_username_txt.Text.Trim(),
                pass = ins_pass_txt.Text,
                ins_name = ins_name_txt.Text.Trim(),
                ins_gender = ins_male_rdo.Checked ? 'M' : 'F',
                ins_phoneNo = ins_phone_txt.Text.Trim(),
                ins_email = ins_email_txt.Text.Trim(),
                ins_salary = ins_salary_nm.Value,
                ins_dob = ins_dob_picker.Value,
                ins_city = ins_city_txt.Text.Trim(),
                ins_street = ins_street_txt.Text.Trim(),
            };

            var result = _dbManager.ExecuteSPWithReturn(SP.AddInstructor, dto);
            if (result == 1)
            {
                insMsg_lbl.ForeColor = Color.Green;
                insMsg_lbl.Text = "Instructor added successfully";
                // refresh list
                showInstructors();
            }
            else
            {
                addInsMsg_lbl.ForeColor = Color.Red;
                addInsMsg_lbl.Text = "Failed to add instructor";
            }
        }

        // Validate inputs before creating the AddInstructorDto
        private bool TryValidateAddInstructor(out string errorMessage)
        {
            errorMessage = string.Empty;

            var username = ins_username_txt.Text?.Trim() ?? string.Empty;
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

            var password = ins_pass_txt.Text ?? string.Empty;
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

            if (string.IsNullOrWhiteSpace(ins_name_txt.Text))
            {
                errorMessage = "Instructor name is required.";
                return false;
            }

            var email = ins_email_txt.Text?.Trim() ?? string.Empty;
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

            var phone = ins_phone_txt.Text?.Trim() ?? string.Empty;
            var phonePattern = @"^[\d\+\-\s\(\)]+$";
            if (string.IsNullOrWhiteSpace(phone) || !Regex.IsMatch(phone, phonePattern) || phone.Length < 7)
            {
                errorMessage = "Invalid phone number.";
                return false;
            }

            // Salary already constrained by control; ensure value present
            try
            {
                var salary = ins_salary_nm.Value;
                if (salary < ins_salary_nm.Minimum || salary > ins_salary_nm.Maximum)
                {
                    errorMessage = "Salary is out of allowed range.";
                    return false;
                }
            }
            catch { }

            // DOB -> instructor should be at least 18 and not older than 100
            try
            {
                var dob = ins_dob_picker.Value;
                var today = DateTime.Today;
                var age = today.Year - dob.Year;
                if (dob > today.AddYears(-age)) age--;
                if (age < 18 || age > 100)
                {
                    errorMessage = "Instructor age must be between 18 and 100.";
                    return false;
                }
            }
            catch { }

            if (string.IsNullOrWhiteSpace(ins_city_txt.Text))
            {
                errorMessage = "City is required.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(ins_street_txt.Text))
            {
                errorMessage = "Street is required.";
                return false;
            }

            if (!ins_male_rdo.Checked && !ins_female_rdo.Checked)
            {
                errorMessage = "Please select a gender.";
                return false;
            }

            return true;
        }

        private void resetIns_btn_Click(object? sender, EventArgs e)
        {
            ins_username_txt.Text = string.Empty;
            ins_pass_txt.Text = string.Empty;
            ins_name_txt.Text = string.Empty;
            ins_phone_txt.Text = string.Empty;
            ins_email_txt.Text = string.Empty;
            ins_salary_nm.Value = 10000;
            ins_city_txt.Text = string.Empty;
            ins_street_txt.Text = string.Empty;
            ins_male_rdo.Checked = false;
            ins_female_rdo.Checked = false;
        }
        private void showInsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insMsg_lbl.Text = "";
            showInstructors();
        }

        private void addInsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllControls();
            resetIns_btn_Click(sender, e);
            addIns_pnl.Visible = true;
            addIns_btn.Visible = true;
            resetIns_btn.Visible = true;
            ipdIns_btn.Visible = false;
            ins_username_txt.Enabled = true;
            ins_pass_txt.Enabled = true;
            addInsHead_lbl.Text = "Add Instructor";
            addIns_pnl.Dock = DockStyle.Fill;
        }

        private void ipdIns_btn_Click(object sender, EventArgs e)
        {
            addInsMsg_lbl.Text = string.Empty;
            var id = (int)instructors_dgv.SelectedRows[0].Cells["insId"].Value;
            if (!TryValidateAddInstructor(out var validationError))
            {
                addInsMsg_lbl.ForeColor = Color.Red;
                addInsMsg_lbl.Text = validationError;
                return;
            }

            var dto = new
            {
                user_id = id,
                ins_name = ins_name_txt.Text.Trim(),
                ins_phoneNo = ins_phone_txt.Text.Trim(),
                ins_email = ins_email_txt.Text.Trim(),
                ins_salary = ins_salary_nm.Value,
                ins_dob = ins_dob_picker.Value,
                ins_city = ins_city_txt.Text.Trim(),
                ins_street = ins_street_txt.Text.Trim(),
                ins_gender = ins_male_rdo.Checked ? "M" : (ins_female_rdo.Checked ? "F" : (string?)null)
            };
            var result = _dbManager.ExecuteSPWithReturn(SP.UpdateInstructor, dto);
            if (result == 1)
            {
                insMsg_lbl.ForeColor = Color.Green;
                insMsg_lbl.Text = "Instructor Updated successfully";
                // refresh list
                showInstructors();
            }
            else
            {
                addInsMsg_lbl.ForeColor = Color.Red;
                addInsMsg_lbl.Text = "Failed to Update instructor";
            }
        }

        // ============== COURSES MANAGEMENT ==============

        private void showCourses()
        {
            HideAllControls();
            menu.Visible = true;
            var res = _dbManager.SelectMany<SelectCourseDto>(SP.SelectCourses);
            if (res != null && res.Data != null)
            {
                var list = res.Data.Select(c => new { c.crs_id, c.crs_name, c.ins_id, c.track_id }).ToList();
                courses_dgv.DataSource = list;
            }
            courses_dgv.ClearSelection();
            crsUpdate_btn.Enabled = false;
            crsDelete_btn.Enabled = false;
            showCrs_pnl.Visible = true;
            showCrs_pnl.Dock = DockStyle.Fill;
        }

        private void courses_dgv_SelectionChanged(object? sender, EventArgs e)
        {
            if (courses_dgv.SelectedRows.Count == 1)
            {
                crsUpdate_btn.Enabled = true;
                crsDelete_btn.Enabled = true;
            }
            else
            {
                crsUpdate_btn.Enabled = false;
                crsDelete_btn.Enabled = false;
            }
        }

        private void crsUpdate_btn_Click(object? sender, EventArgs e)
        {
            if (courses_dgv.SelectedRows.Count != 1) return;
            var id = (int)courses_dgv.SelectedRows[0].Cells["crsId"].Value;
            // show add/update course panel with id prefilled
            HideAllControls();
            addCrs_pnl.Visible = true;
            addCrs_btn.Visible = false;
            resetCrs_btn.Visible = false;
            updCrs_btn.Visible = true;
            addCrsHead_lbl.Text = "Update Course";
            addCrs_pnl.Dock = DockStyle.Fill;
            // load course details
            var res = _dbManager.SelectOne<SelectCourseDto>(SP.SelectCourse, new { crs_id = id });
            if (res != null && res.Data != null)
            {
                var d = res.Data;
                crs_name_txt.Text = d.crs_name;
                crs_insid_nm.Value = d.ins_id ?? 0;
                crs_trackid_nm.Value = d.track_id;
            }
        }

        private void crsDelete_btn_Click(object? sender, EventArgs e)
        {
            if (courses_dgv.SelectedRows.Count != 1) return;
            var id = (int)courses_dgv.SelectedRows[0].Cells["crsId"].Value;
            var result = _dbManager.ExecuteSPWithReturn(SP.DeleteCourse, new { crs_id = id });
            if (result == 1)
            {
                crsMsg_lbl.ForeColor = Color.Green;
                crsMsg_lbl.Text = "Course deleted successfully";
                showCourses();
            }
            else
            {
                crsMsg_lbl.ForeColor = Color.Red;
                crsMsg_lbl.Text = "Failed to delete course";
            }
        }

        private bool TryValidateAddCourse(out string errorMessage)
        {
            errorMessage = string.Empty;

            var crsName = crs_name_txt.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(crsName))
            {
                errorMessage = "Course name is required.";
                return false;
            }
            if (crsName.Length < 3)
            {
                errorMessage = "Course name must be at least 3 characters.";
                return false;
            }

            var insId = (int)crs_insid_nm.Value;
            // Instructor ID can be 0 (nullable), but if provided, must be valid
            if (insId < 0)
            {
                errorMessage = "Invalid instructor ID.";
                return false;
            }

            var trackId = (int)crs_trackid_nm.Value;
            if (trackId <= 0)
            {
                errorMessage = "Track ID must be greater than 0.";
                return false;
            }

            return true;
        }

        private void addCrs_btn_Click(object? sender, EventArgs e)
        {
            addCrsMsg_lbl.Text = string.Empty;

            if (!TryValidateAddCourse(out var validationError))
            {
                addCrsMsg_lbl.ForeColor = Color.Red;
                addCrsMsg_lbl.Text = validationError;
                return;
            }

            var dto = new
            {
                crs_name = crs_name_txt.Text.Trim(),
                ins_id = (int)crs_insid_nm.Value == 0 ? (int?)null : (int)crs_insid_nm.Value,
                track_id = (int)crs_trackid_nm.Value
            };

            var result = _dbManager.ExecuteSPWithReturn(SP.AddCourse, dto);
            if (result == 1)
            {
                addCrsMsg_lbl.ForeColor = Color.Green;
                addCrsMsg_lbl.Text = "Course added successfully";
                ClearAddCourseForm();
                // Optionally refresh the list
                showCourses();
            }
            else if (result == -2)
            {
                addCrsMsg_lbl.ForeColor = Color.Red;
                addCrsMsg_lbl.Text = "Instructor ID does not exist";
            }
            else if (result == -3)
            {
                addCrsMsg_lbl.ForeColor = Color.Red;
                addCrsMsg_lbl.Text = "Track ID does not exist";
            }
            else
            {
                addCrsMsg_lbl.ForeColor = Color.Red;
                addCrsMsg_lbl.Text = "Failed to add course";
            }
        }

        private void resetCrs_btn_Click(object? sender, EventArgs e)
        {
            ClearAddCourseForm();
        }

        private void ClearAddCourseForm()
        {
            crs_name_txt.Text = string.Empty;
            crs_insid_nm.Value = 0;
            crs_trackid_nm.Value = 1;
            addCrsMsg_lbl.Text = string.Empty;
        }

        private void showCrsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            crsMsg_lbl.Text = "";
            showCourses();
        }

        private void addCrsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            HideAllControls();
            ClearAddCourseForm();
            addCrs_pnl.Visible = true;
            addCrs_btn.Visible = true;
            resetCrs_btn.Visible = true;
            updCrs_btn.Visible = false;
            addCrsHead_lbl.Text = "Add Course";
            addCrs_pnl.Dock = DockStyle.Fill;
        }

        private void updCrs_btn_Click(object sender, EventArgs e)
        {
            addCrsMsg_lbl.Text = string.Empty;
            var id = (int)courses_dgv.SelectedRows[0].Cells["crsId"].Value;
            if (!TryValidateAddCourse(out var validationError))
            {
                addCrsMsg_lbl.ForeColor = Color.Red;
                addCrsMsg_lbl.Text = validationError;
                return;
            }

            var dto = new
            {
                crs_id = id,
                crs_name = crs_name_txt.Text.Trim(),
                ins_id = (int)crs_insid_nm.Value == 0 ? (int?)null : (int)crs_insid_nm.Value,
                track_id = (int)crs_trackid_nm.Value
            };

            var result = _dbManager.ExecuteSPWithReturn(SP.UpdateCourse, dto);
            if (result == 1)
            {
                crsMsg_lbl.ForeColor = Color.Green;
                crsMsg_lbl.Text = "Course updated successfully";
                showCourses();
            }
            else if (result == -1)
            {
                addCrsMsg_lbl.ForeColor = Color.Red;
                addCrsMsg_lbl.Text = "Course ID does not exist";
            }
            else if (result == -2)
            {
                addCrsMsg_lbl.ForeColor = Color.Red;
                addCrsMsg_lbl.Text = "Instructor ID does not exist";
            }
            else if (result == -3)
            {
                addCrsMsg_lbl.ForeColor = Color.Red;
                addCrsMsg_lbl.Text = "Track ID does not exist";
            }
            else
            {
                addCrsMsg_lbl.ForeColor = Color.Red;
                addCrsMsg_lbl.Text = "Failed to update course";
            }
        }

        // ============== TRACKS MANAGEMENT ==============

        private void showTracks()
        {
            HideAllControls();
            menu.Visible = true;
            var res = _dbManager.SelectMany<TrackDto>(SP.SelectTracks);
            if (res != null && res.Data != null)
            {
                var list = res.Data.Select(t => new { t.track_id, t.track_name }).ToList();
                tracks_dgv.DataSource = list;
            }
            tracks_dgv.ClearSelection();
            trkUpdate_btn.Enabled = false;
            trkDelete_btn.Enabled = false;
            showTrk_pnl.Visible = true;
            showTrk_pnl.Dock = DockStyle.Fill;
        }

        private void tracks_dgv_SelectionChanged(object? sender, EventArgs e)
        {
            if (tracks_dgv.SelectedRows.Count == 1)
            {
                trkUpdate_btn.Enabled = true;
                trkDelete_btn.Enabled = true;
            }
            else
            {
                trkUpdate_btn.Enabled = false;
                trkDelete_btn.Enabled = false;
            }
        }

        private void trkUpdate_btn_Click(object? sender, EventArgs e)
        {
            if (tracks_dgv.SelectedRows.Count != 1) return;
            var id = (int)tracks_dgv.SelectedRows[0].Cells["trkId"].Value;
            // show add/update track panel with id prefilled
            HideAllControls();
            addTrk_pnl.Visible = true;
            addTrk_btn.Visible = false;
            resetTrk_btn.Visible = false;
            updTrk_btn.Visible = true;
            addTrkHead_lbl.Text = "Update Track";
            addTrk_pnl.Dock = DockStyle.Fill;
            // load track details
            var res = _dbManager.SelectOne<TrackDto>(SP.SelectTrack, new { track_id = id });
            if (res != null && res.Data != null)
            {
                var d = res.Data;
                trk_name_txt.Text = d.track_name;
            }
        }

        private void trkDelete_btn_Click(object? sender, EventArgs e)
        {
            if (tracks_dgv.SelectedRows.Count != 1) return;
            var id = (int)tracks_dgv.SelectedRows[0].Cells["trkId"].Value;
            var result = _dbManager.ExecuteSPWithReturn(SP.DeleteTrack, new { track_id = id });
            if (result == 1)
            {
                trkMsg_lbl.ForeColor = Color.Green;
                trkMsg_lbl.Text = "Track deleted successfully";
                showTracks();
            }
            else if (result == -1)
            {
                trkMsg_lbl.ForeColor = Color.Red;
                trkMsg_lbl.Text = "Track does not exist";
            }
            else
            {
                trkMsg_lbl.ForeColor = Color.Red;
                trkMsg_lbl.Text = "Failed to delete track";
            }
        }

        private bool TryValidateAddTrack(out string errorMessage)
        {
            errorMessage = string.Empty;

            var trkName = trk_name_txt.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(trkName))
            {
                errorMessage = "Track name is required.";
                return false;
            }
            if (trkName.Length < 2)
            {
                errorMessage = "Track name must be at least 2 characters.";
                return false;
            }

            return true;
        }

        private void addTrk_btn_Click(object? sender, EventArgs e)
        {
            addTrkMsg_lbl.Text = string.Empty;

            if (!TryValidateAddTrack(out var validationError))
            {
                addTrkMsg_lbl.ForeColor = Color.Red;
                addTrkMsg_lbl.Text = validationError;
                return;
            }

            var dto = new
            {
                track_name = trk_name_txt.Text.Trim()
            };

            var result = _dbManager.ExecuteSPWithReturn(SP.AddTrack, dto);
            if (result == 1)
            {
                addTrkMsg_lbl.ForeColor = Color.Green;
                addTrkMsg_lbl.Text = "Track added successfully";
                ClearAddTrackForm();
                // Optionally refresh the list
                showTracks();
            }
            else
            {
                addTrkMsg_lbl.ForeColor = Color.Red;
                addTrkMsg_lbl.Text = "Failed to add track";
            }
        }

        private void resetTrk_btn_Click(object? sender, EventArgs e)
        {
            ClearAddTrackForm();
        }

        private void ClearAddTrackForm()
        {
            trk_name_txt.Text = string.Empty;
            addTrkMsg_lbl.Text = string.Empty;
        }

        private void showTrkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trkMsg_lbl.Text = "";
            showTracks();
        }

        private void addTrkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllControls();
            ClearAddTrackForm();
            addTrk_pnl.Visible = true;
            addTrk_btn.Visible = true;
            resetTrk_btn.Visible = true;
            updTrk_btn.Visible = false;
            addTrkHead_lbl.Text = "Add Track";
            addTrk_pnl.Dock = DockStyle.Fill;
        }

        private void updTrk_btn_Click(object sender, EventArgs e)
        {
            addTrkMsg_lbl.Text = string.Empty;
            var id = (int)tracks_dgv.SelectedRows[0].Cells["trkId"].Value;
            if (!TryValidateAddTrack(out var validationError))
            {
                addTrkMsg_lbl.ForeColor = Color.Red;
                addTrkMsg_lbl.Text = validationError;
                return;
            }

            var dto = new
            {
                track_id = id,
                track_name = trk_name_txt.Text.Trim()
            };

            var result = _dbManager.ExecuteSPWithReturn(SP.UpdateTrack, dto);
            if (result == 1)
            {
                trkMsg_lbl.ForeColor = Color.Green;
                trkMsg_lbl.Text = "Track updated successfully";
                showTracks();
            }
            else if (result == -1)
            {
                addTrkMsg_lbl.ForeColor = Color.Red;
                addTrkMsg_lbl.Text = "Track does not exist";
            }
            else
            {
                addTrkMsg_lbl.ForeColor = Color.Red;
                addTrkMsg_lbl.Text = "Failed to update track";
            }
        }
    }
}


