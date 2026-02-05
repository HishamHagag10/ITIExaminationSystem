using DB_Project.DB_Repository;
using DB_Project.DTOs;
using ITIExaminationSystem.DTOs;
using ITIExaminationSystem.Helpers;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
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


        private void HideAllPanels()
        {
            dashboardpanel.Visible = false;
            showExam_pnl.Visible = false;
            //panel2.Visible = false;
            genExam_pnl.Visible = false;
        }
        public InstructorForm(DB_Manager dB_Manager, int userId)
        {
            _dbManager = dB_Manager;
            InitializeComponent();
            _userId = userId;
            LoadInstructorData();
            panel2.Visible = false;
        }
        private void InstructorForm_Load(object sender, EventArgs e)
        {
            LoadInstructorData();

        }


        private void LoadInstructorData()
        {
            var instructor = _dbManager.SelectOne<InstructorDTO>(SP.GetInstructorById, new { @id = _userId });
            dashboardpanel.Visible = true;
            dashboardpanel.Dock = DockStyle.Fill;
            dashboardpanel.BringToFront();
            if (instructor.Data != null)
            {
                Namelbl.Text = $"{instructor.Data.Ins_Name}";
                Emaillbl.Text = $"Email: {instructor.Data.Ins_Email}";
                deplbl.Text = $"Date: {instructor.Data.Ins_Dob}";
                genderlbl.Text = $"Gender: :{instructor.Data.Ins_Gender}";
                phonelbl.Text = $"Phone: {instructor.Data.Ins_PhoneNo}";
                salarylbl.Text = $"Salary: {instructor.Data.Ins_Salary}";
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
        private void showCourses()
        {
            HideAllPanels();
            panel2.Visible = true;
            panel2.BringToFront();
        }
        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showCourses();
            var result = _dbManager.SelectMany<ins_CourseDto>(
                SP.InstructorCourses,
                new { @id = _userId }
            );

            if (result.Data != null && result.Data.Count > 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = result.Data;
                AddGenerateExamButton();
                AddShowExamButton();
                AddShowGradesButton();
                //if (dataGridView1.Columns.Contains("crs_id"))
                //dataGridView1.Columns["crs_id"].Visible = false;
            }
            else
            {
                MessageBox.Show("No courses found");
            }
        }
        private void AddShowGradesButton()
        {
            if (!dataGridView1.Columns.Contains("btnShowGrades"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "btnShowGrades";
                btn.HeaderText = "Show Grades";
                btn.Text = "Show Grades";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);
            }
        }
        private void AddShowExamButton()
        {
            if (!dataGridView1.Columns.Contains("btnShowExam"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "btnShowExam";
                btn.HeaderText = "Show Exam";
                btn.Text = "Show Exam";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);
            }
        }

        private void AddGenerateExamButton()
        {
            if (!dataGridView1.Columns.Contains("btnGenerateExam"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "btnGenerateExam";
                btn.HeaderText = "Generate Exam";
                btn.Text = "Generate Exam";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HideAllPanels();
            if (e.RowIndex < 0) return;
            int courseId = Convert.ToInt32(
                    dataGridView1.Rows[e.RowIndex].Cells["crs_id"].Value
                );
            gcrsid_txt.Text = courseId.ToString();
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnGenerateExam")
            {
                HideAllPanels();
                genExam_pnl.Visible = true;
                genExam_pnl.Dock = DockStyle.Fill;
                genExam_pnl.BringToFront();
                return;
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnShowExam")
            {
                HideAllPanels();
                showExam_pnl.Controls.Clear();
                showExam_pnl.Visible = true;
                showExam_pnl.Dock = DockStyle.Fill;
                showExam_pnl.AutoSize = true;
                showExam_pnl.AutoScroll = true;
                showExam_pnl.BringToFront();
                var result = _dbManager.SelectMany<Question>(
                    SP.takeExam,
                    new { @crsid = courseId }
                );
                var head = new Label
                {
                    Text = "Exam Questions",
                    AutoSize = true,
                    Location = new Point(400, 20),
                    Font = new Font("Arial", 16, FontStyle.Bold),
                    Size = new Size(230, 40)
                };
                showExam_pnl.Controls.Add(head);
                if (result.Data != null)
                {
                    for (int i = 0; i < result.Data.Count; i++)
                    {
                        var question = result.Data[i];
                        var lbl = new Label
                        {
                            Text = "Question " + (i + 1).ToString() + " : " + question.qus_text,
                            AutoSize = true,
                            Location = new Point(20, 50 + (i * 80)),
                            Font = new Font("Arial", 10, FontStyle.Bold)
                        };
                        var lbl2 = new Label
                        {
                            Text = "Choices : " + question.choices,
                            AutoSize = true,
                            Location = new Point(50, 80 + (i * 80)),
                            Font = new Font("Arial", 10, FontStyle.Bold)
                        };

                        showExam_pnl.Controls.Add(lbl);
                        showExam_pnl.Controls.Add(lbl2);
                    }
                    var back = new System.Windows.Forms.Button
                    {
                        Text = "Back",
                        Size = new Size(150, 50),
                        Location = new Point(300, 80 + (result.Data.Count * 80)),
                        Font = new Font("Arial", 10, FontStyle.Bold)
                    };
                    back.Click += (s, ev) =>
                    {
                        HideAllPanels();
                        showCourses();
                    };
                    showExam_pnl.Controls.Add(back);
                }
                else MessageBox.Show("No Exam For this Course");
                return;
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnShowGrades")
            {
                HideAllPanels();
                showExam_pnl.Controls.Clear();
                showExam_pnl.Visible = true;
                showExam_pnl.Dock = DockStyle.Fill;
                showExam_pnl.AutoSize = true;
                showExam_pnl.AutoScroll = true;
                showExam_pnl.BringToFront();
                var head = new Label
                {
                    Text = "Exam Grades",
                    AutoSize = true,
                    Location = new Point(400, 20),
                    Font = new Font("Arial", 16, FontStyle.Bold),
                    Size = new Size(230, 40)
                };
                showExam_pnl.Controls.Add(head);
                var exams=_dbManager.SelectMany<ExamDto>(
                    SP.GetCourseExams,
                    new { @crs_id = courseId }
                    );
                if (exams ==null || exams.Data == null || exams.Data.Count==0)
                {
                    MessageBox.Show("No Exam For this Course");
                    return;
                }
                var lbl = new Label
                {
                    Text = "Select Exam No : ",
                    AutoSize = true,
                    Location = new Point(150, 85),
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };
                showExam_pnl.Controls.Add(lbl);
                var list = new System.Windows.Forms.ComboBox
                {
                    Location = new Point(300, 80),
                    Size = new Size(200, 30),
                    DropDownStyle = ComboBoxStyle.DropDownList
                };
                //list.Items.AddRange(exams.Data.Select(e => e.ex_no.ToString()));
                exams.Data.ForEach(e => list.Items.Add(e.ex_no.ToString()));
                showExam_pnl.Controls.Add(list);
                list.SelectedIndexChanged += (s, ev) =>
                {
                    var selected = int.Parse(list.SelectedItem.ToString());
                    showExam_pnl.Controls.RemoveByKey("pnl");
                    showGrades(selected);
                };
                //showGrades(selected);
            }
        }

        private void showGrades(int examno)
        {
            var pnl = new Panel
            {
                Name="pnl"
            };
            pnl.AutoSize=true;
            var grades = _dbManager.SelectMany<ExamGradeDto>(
                    SP.GetExamGrades,
                    new { @ex_no = examno }
                );
            if (grades.Data != null)
            {
                for (int i = 0; i < grades.Data.Count; i++)
                {
                    var grade = grades.Data[i];
                    var lbl = new Label
                    {
                        Text = "Student ID: " + grade.user_id + " - Grade: " + grade.grade,
                        AutoSize = true,
                        Location = new Point(20, 200 + (i * 30)),
                        Font = new Font("Arial", 10, FontStyle.Bold)
                    };
                    pnl.Controls.Add(lbl);
                }
                showExam_pnl.Controls.Add(pnl);
            }
            else MessageBox.Show("No Grades For this Course");
        }
        private void panelDetails_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label2_Click_1(object sender, EventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            dashboardpanel.Visible = true;
            panel2.Visible = false;
            LoadInstructorData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Generate Exam button
            var noOfTF = noTF_nm.Value;
            var noOfMcq = noMCQ_nm.Value;
            var duration = dur_nm.Value;

            var courseId = int.Parse(gcrsid_txt.Text);
            var result = _dbManager.ExecuteSPWithReturn(
                SP.ExamGeneration, new
                {
                    @course_id = courseId,
                    @no_of_qus = noOfTF + noOfMcq,
                    @mcq_qus = noOfMcq,
                    @ex_duartion = duration
                });
            switch (result)
            {
                case 1:
                    MessageBox.Show("Exam Generated Successfully");
                    break;
                case -2:
                    MessageBox.Show("Duration Is no valid");
                    break;
                case -6:
                    MessageBox.Show("There is already exam in the same day");
                    break;
                default:
                    MessageBox.Show("Problem inserting in db");
                    break;
            }
            showCourses();
        }

        private void genBack_btn_Click(object sender, EventArgs e)
        {
            showCourses();
        }
    }
}










