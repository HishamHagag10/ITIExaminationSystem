using DB_Project.DB_Repository;
using DB_Project.DTOs;
using ITIExaminationSystem.DTOs;
using ITIExaminationSystem.Helpers;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITIExaminationSystem.Forms
{

    public partial class InstructorForm : Form
    {
        private DB_Manager _dbManager;
        public event Action LoggedOut;
        private int _userId;


        private void HideAllControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Visible = false;
            }
            menu.Visible = true;
        }
        public InstructorForm(DB_Manager dB_Manager, int userId)
        {
            _dbManager = dB_Manager;
            InitializeComponent();
            _userId = userId;
            LoadInstructorData();

            panel2.Visible = false;
            dashboardpanel.Visible = false;
        }
        private void InstructorForm_Load(object sender, EventArgs e)
        {
            LoadInstructorData();

        }


        private void LoadInstructorData()
        {
            var instructor = _dbManager.SelectOne<InstructorDTO>(SP.GetInstructorById, new { @id = _userId });

            if (instructor != null)
            {
                lblName.Text = $"Name: {instructor.Data.Ins_Name}";
                lblEmail.Text = $"Email: {instructor.Data.Ins_Email}";
                lblDepartment.Text = $"Department: {instructor.Data.Ins_Dob}";
                lblGender.Text = $"Gender: :{instructor.Data.Ins_Gender}";
                lblPhone.Text = $"Phone: {instructor.Data.Ins_PhoneNo}";
                lblSalary.Text = $"Salary: {instructor.Data.Ins_Salary}";

            }
            else
            {
                MessageBox.Show("Instructor data not found!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
           

        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoggedOut?.Invoke();
            this.Close();
        }

        private void lblSalary_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel2.Visible = true;
            panel2.BringToFront();
            panelDetails.Visible = false;

            var result = _dbManager.SelectMany<ins_CourseDto>(
                SP.InstructorCourses,
                new { @id = _userId}   
            );

            if (result?.Data != null && result.Data.Count > 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = result.Data;

                AddDetailsButton();

                if (dataGridView1.Columns.Contains("Id"))
                    dataGridView1.Columns["Id"].Visible = false;
            }
            else
            {
                MessageBox.Show("No courses found");
            }
        }

        private void AddDetailsButton()
        {
            if (!dataGridView1.Columns.Contains("btnDetails"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "btnDetails";
                btn.HeaderText = "Details";
                btn.Text = "Details";
                btn.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(btn);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dataGridView1.Columns[e.ColumnIndex].Name != "btnDetails")
                return;
            int courseId = Convert.ToInt32(
                    dataGridView1.Rows[e.RowIndex].Cells["Id"].Value
                );

            string courseName =
                dataGridView1.Rows[e.RowIndex].Cells["crs_name"].Value.ToString();

            label2.Text = $"Course ID: {courseId}";
            label7.Text = $"Course Name: {courseName}";

            panelDetails.Visible = true;
            panelDetails.BringToFront();
        }



        private void panelDetails_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideCourseDetails();
        }
        private void HideCourseDetails()
        {
            label2.Text = string.Empty;
            label7.Text = string.Empty;
            panelDetails.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HideCourseDetails();
        }

        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dashboardpanel.Visible = true;
            panel2.Visible = false;
            var instructor = _dbManager.SelectOne<InstructorDTO>(SP.GetInstructorById, new { @id = _userId });

            if (instructor != null)
            {
                label12.Text = $"Name: {instructor.Data.Ins_Name}";
                label11.Text = $"Email: {instructor.Data.Ins_Email}";
                label10.Text = $"Department: {instructor.Data.Ins_Dob}";
                label6.Text = $"Gender: :{instructor.Data.Ins_Gender}";
                label1.Text = $"Phone: {instructor.Data.Ins_PhoneNo}";
                label9.Text = $"Salary: {instructor.Data.Ins_Salary}";

            }
            else
            {
                MessageBox.Show("Instructor data not found!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



        }
    }
}










