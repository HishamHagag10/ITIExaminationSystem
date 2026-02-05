using DB_Project.DB_Repository;
using DB_Project.DTOs;
using ITIExaminationSystem.DTOs;
using ITIExaminationSystem.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static ITIExaminationSystem.DTOs.Question;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ITIExaminationSystem.Forms
{
    public partial class StudentForm : Form
    {
        private DB_Manager _dbManager;
        public event Action LoggedOut;
        private int _studentId;
        private int _examnum;
        List<Question> examQuestions = new List<Question>();
        int currentIndex = 0;


        public StudentForm(DB_Manager dB_Manager, int studentId)
        {
            _dbManager = dB_Manager;
            _studentId = studentId;
            InitializeComponent();
        }
        private void HideAllControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Visible = false;
            }
            menu.Visible = true;
        }
        //loading
        private void StudentForm_Load(object sender, EventArgs e)
        {
            dashboardToolStripMenuItem_Click(sender, e);
            iNFOToolStripMenuItem_Click(sender, e);


        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

            HideAllControls();
            menu.Visible = true;

            welcome_lbl.Text = "Welcome Here TO YOur Info";

        }

        private void iNFOToolStripMenuItem_Click(object sender, EventArgs e)
        {

            HideAllControls();
            panel01.Visible = true;
            panel01.Dock = DockStyle.Fill;
            var result = _dbManager.SelectOne<StudentDTO>(SP.getstudentbyid, new { @id = _studentId });
            if (result.Data != null)
            {
                welcome_lbl.Text = $"Welcome {result.Data.FirstName}";
                fname_lbl.Text = result.Data.FirstName;
                lname_lbl.Text = result.Data.LastName;
                email_lbl.Text = result.Data.Email;
                phone_lbl.Text = result.Data.Phone;

            }
            else
            {
                MessageBox.Show("Student not found");
            }
        }



        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoggedOut?.Invoke();
            this.Close();
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDetails.Visible = false;
            HideAllControls();
            panel2.Visible = true;
            panel2.Dock = DockStyle.Fill;

            var result = _dbManager.SelectMany<courseDto>(SP.getstudentCourse, new { @id = _studentId });
            if (result.Status == 1 && result.Data != null && result.Data.Count > 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.AutoGenerateColumns = false;

                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = result.Data;

                dataGridView1.Visible = true;
                dataGridView1.BringToFront();

                DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
                idCol.Name = "Id";
                idCol.DataPropertyName = "Id";
                idCol.Visible = false;
                dataGridView1.Columns.Add(idCol);


                DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
                nameCol.Name = "Name";
                nameCol.DataPropertyName = "Name";
                nameCol.HeaderText = "Course Name";
                dataGridView1.Columns.Add(nameCol);
                if (!dataGridView1.Columns.Contains("btnDetails"))
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.Name = "btnDetails";
                    btn.HeaderText = "Details";
                    btn.Text = "Details";
                    btn.UseColumnTextForButtonValue = true;

                    dataGridView1.Columns.Add(btn);
                }
                if (!dataGridView1.Columns.Contains("btnTakeExam"))
                {
                    DataGridViewButtonColumn btnTakeExam = new DataGridViewButtonColumn();
                    btnTakeExam.HeaderText = "Take Exam";
                    btnTakeExam.Name = "btnTakeExam";
                    btnTakeExam.Text = "Take Exam";
                    btnTakeExam.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(btnTakeExam);
                }


                if (dataGridView1.Columns.Contains("Id"))
                    dataGridView1.Columns["Id"].Visible = false;
            }
            else
            {
                MessageBox.Show("Course not found");
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "btnDetails")
            {

                int courseId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                string courseName = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();


                lblCourseId.Text = "ID: " + courseId;
                lblCourseName.Text = "Name: " + courseName;

                panelDetails.Visible = true;
                panelDetails.BringToFront();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnTakeExam")
            {
                int courseId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                string courseName = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();


                textBox1cid.Text = courseId.ToString();

                var result = _dbManager.SelectMany<Question>(SP.takeExam, new { @crsid = courseId });

                if (result.Data == null || result.Data.Count == 0)
                {
                    MessageBox.Show("No exam questions found for this course.");
                    return;
                }

                examQuestions = result.Data;
                _examnum = examQuestions.First().ex_no;


                examQuestions.ForEach(q =>
                {
                    var ids = q.choicesId.Split(',').Select(x => int.Parse(x.Trim())).ToList();
                    var ch = q.choices.Split(',').Select(x => x.Trim()).ToList();
                    for (int i = 0; i < ids.Count; i++)
                    {
                        q.Choices.Add(new Choice
                        {
                            ChoiceId = ids[i],
                            ChoiceText = ch[i]
                        });
                    }
                });

                currentIndex = 0;


                DisplayQuestion(examQuestions[currentIndex]);

                HideAllControls();
                panelexam.Visible = true;
                panelexam.Dock = DockStyle.Fill;
            }

        }
        private void btnCloseDetails_Click(object sender, EventArgs e)
        {
            panelDetails.Visible = false;
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            HideAllControls();

            panelexam.Visible = true;
            examcorrectgrade.Visible = false;
            panelexam.Dock = DockStyle.Fill;


        }
        void DisplayQuestion(Question q)
        {
            HideAllControls();
            exam_pnl.Visible = true;
            ques_lbl.Text = q.qus_text;
            radioButton1.Visible = q.Choices.Count > 0;
            radioButton2.Visible = q.Choices.Count > 1;
            radioButton3.Visible = q.Choices.Count > 2;
            radioButton4.Visible = q.Choices.Count > 3;

            if (radioButton1.Visible) radioButton1.Text = q.Choices[0].ChoiceText;
            if (radioButton2.Visible) radioButton2.Text = q.Choices[1].ChoiceText;
            if (radioButton3.Visible) radioButton3.Text = q.Choices[2].ChoiceText;
            if (radioButton4.Visible) radioButton4.Text = q.Choices[3].ChoiceText;
            bool hasChoices = q.Choices.Count > 0 && q.Choices[0].ChoiceId != 0;
            radioButton1.Enabled = hasChoices;
            radioButton2.Enabled = hasChoices;
            radioButton3.Enabled = hasChoices;
            radioButton4.Enabled = hasChoices;
        }

        private void examcorrectgrade_Click(object sender, EventArgs e)
        {

            try
            {
                // Call the stored procedure
                var result = _dbManager.SelectMany<StudentGradeDto>(
                    SP.correctExam,
                    new
                    {
                        @ex_no = _examnum,
                        @user_id = _studentId
                    });

                // Check if Data is not null and has items
                if (result.Data != null && result.Data.Count > 0)
                {
                    decimal grade = result.Data.First().Grade;
                    MessageBox.Show($"Your grade is: {grade}%", "Exam Grade",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Grade not available yet.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching grade: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //:::::::::::::::::::ForshowexamAnswer::::::::::::::::::::
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

           

            panel2.Visible = false;
            panelexam.Visible = false;
            panel01.Visible = false;
            exam_pnl.Visible=false;

            this.Controls.Add(paneltruely);
      


            paneltruely.BringToFront();
            paneltruely.Visible = true;


            if (!paneltruely.Controls.Contains(dataGridViewexamans))
                paneltruely.Controls.Add(dataGridViewexamans);

            dataGridViewexamans.Dock = DockStyle.Fill;
            dataGridViewexamans.BringToFront();

            LoadExamAnswers();

        }


        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void phone_lbl_Click(object sender, EventArgs e)
        {

        }
        private void studentInfo_pnl_Paint(object sender, PaintEventArgs e)
        {
          ;

        }

        private void courseINFOToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
        private void chooseCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllControls();
            panel2.Visible = true;
            panel2.Dock = DockStyle.Fill;

            var result = _dbManager.SelectMany<courseDto>(SP.getstudentCourse, new { @id = _studentId });
            if (result.Data != null && result.Data.Count > 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = result.Data;

                dataGridView1.Visible = true;
                dataGridView1.BringToFront();


                if (!dataGridView1.Columns.Contains("btnDetails"))
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.Name = "btnDetails";
                    btn.HeaderText = "Details";
                    btn.Text = "Details";
                    btn.UseColumnTextForButtonValue = true;

                    dataGridView1.Columns.Add(btn);
                }


                if (dataGridView1.Columns.Contains("Id"))
                    dataGridView1.Columns["Id"].Visible = false;
            }
            else
            {
                MessageBox.Show("Course not found");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelDetails.Visible = false;
        }

        private void TakeExam_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {



            TakeExam_Click(sender, e); return;

        }

        private void yes_btn_Click(object sender, EventArgs e)
        {
            var result = _dbManager.SelectMany<Question>(
                SP.takeExam,
                new { @crsid = textBox1cid.Text }
            );

            if (result.Data == null || result.Data.Count == 0)
            {
                MessageBox.Show("No exam questions found.");
                return;
            }

            examQuestions = result.Data;
            _examnum = examQuestions.First().ex_no;
            examQuestions.ForEach(q =>
            {
                q.Choices = new List<Choice>();

                if (!string.IsNullOrWhiteSpace(q.choices) && !string.IsNullOrWhiteSpace(q.choicesId))
                {
                    var ids = q.choicesId.Split(',', StringSplitOptions.RemoveEmptyEntries)
                                          .Select(x => int.TryParse(x.Trim(), out int n) ? n : 0)
                                          .Where(x => x != 0)
                                          .ToList();

                    var ch = q.choices.Split(',', StringSplitOptions.RemoveEmptyEntries)
                                      .Select(x => x.Trim())
                                      .ToList();

                    int count = Math.Min(ids.Count, ch.Count);

                    for (int i = 0; i < count; i++)
                    {
                        q.Choices.Add(new Choice
                        {
                            ChoiceId = ids[i],
                            ChoiceText = ch[i]
                        });
                    }
                }

                if (q.Choices.Count == 0)
                {
                    q.Choices.Add(new Choice
                    {
                        ChoiceId = 0,
                        ChoiceText = "No choices available"
                    });
                }
            });

            currentIndex = 0;
            DisplayQuestion(examQuestions[currentIndex]);
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelDetails_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelexam_Paint(object sender, PaintEventArgs e)
        {
        }
        private void nxt_Click(object sender, EventArgs e)
        {
            if (examQuestions == null || examQuestions.Count == 0)
            {
                MessageBox.Show("No exam loaded.");
                return;
            }

            // 1️⃣ Get current question
            var question = examQuestions[currentIndex];

            if (question.Choices == null || question.Choices.Count == 0)
            {
                MessageBox.Show("This question has no choices.");
                return;
            }

            // 2️⃣ Check which radio button is selected
            string choiceText = null;
            int choiceId = 0;

            if (radioButton1.Checked && question.Choices.Count > 0)
            {
                choiceText = question.Choices[0].ChoiceText;
                choiceId = question.Choices[0].ChoiceId;
            }
            else if (radioButton2.Checked && question.Choices.Count > 1)
            {
                choiceText = question.Choices[1].ChoiceText;
                choiceId = question.Choices[1].ChoiceId;
            }
            else if (radioButton3.Checked && question.Choices.Count > 2)
            {
                choiceText = question.Choices[2].ChoiceText;
                choiceId = question.Choices[2].ChoiceId;
            }
            else if (radioButton4.Checked && question.Choices.Count > 3)
            {
                choiceText = question.Choices[3].ChoiceText;
                choiceId = question.Choices[3].ChoiceId;
            }
            else
            {
                MessageBox.Show("Please select a valid answer.");
                return;
            }

            // 3️⃣ Save answer using the correct student ID
            int result = _dbManager.ExecuteSPWithReturn(
                SP.AddStudentAnswer,
                new
                {
                    ex_no = _examnum,
                    std_id = 77,
                    qus_no = question.qus_no,
                    choice_text = choiceText,
                    choice_id = choiceId
                }
            );

            switch (result)
            {
                case 1:
                    break; // success
                case -1:
                    MessageBox.Show("Student not found.");
                    return;
                case -3:
                    MessageBox.Show("Question not found.");
                    return;
                default:
                    MessageBox.Show("Error saving answer.");
                    return;
            }

            // 4️⃣ Move to next question
            currentIndex++;

            if (currentIndex < examQuestions.Count)
            {
                DisplayQuestion(examQuestions[currentIndex]);
            }
            else
            {
                MessageBox.Show("Exam Finished, Good Luck!");

                HideAllControls();
                panelexam.Controls.Clear();
                panelexam.Visible = true;

                examcorrectgrade.Parent = panelexam;
                examcorrectgrade.Visible = true;
                examcorrectgrade.Enabled = true;
            }

            // 5️⃣ Reset radio buttons
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }


        private void exam_pnl_Paint(object sender, PaintEventArgs e)
        {

            paneltruely.Visible = false;
        }

        private void LoadExamAnswers()
        {

            var result = _dbManager.SelectMany<ExamReview>(
                SP.studentExamAns,
                new { std_id = 77}
            );

            if (result.Data == null || result.Data.Count == 0)
            {
                MessageBox.Show("No exam answers found for this student.");
                dataGridViewexamans.DataSource = null;
                return;
            }

            result.Data.ForEach(x =>
            {
                if (x.student_answer != null)
                    x.student_answer = x.student_answer.ToString();
                if (x.correct_answer != null)
                    x.correct_answer = x.correct_answer.ToString();
                if (x.result != null)
                    x.result = x.result.ToString();
            });

            dataGridViewexamans.AutoGenerateColumns = true;
            dataGridViewexamans.DataSource = result.Data;


            if (dataGridViewexamans.Columns.Contains("qus_no"))
                dataGridViewexamans.Columns["qus_no"].HeaderText = "Question No";
            if (dataGridViewexamans.Columns.Contains("qus_text"))
                dataGridViewexamans.Columns["qus_text"].HeaderText = "Question Text";
            if (dataGridViewexamans.Columns.Contains("student_answer"))
                dataGridViewexamans.Columns["student_answer"].HeaderText = "Your Answer";
            if (dataGridViewexamans.Columns.Contains("correct_answer"))
                dataGridViewexamans.Columns["correct_answer"].HeaderText = "Correct Answer";
            if (dataGridViewexamans.Columns.Contains("result"))
                dataGridViewexamans.Columns["result"].HeaderText = "Result";


            dataGridViewexamans.CellFormatting -= dataGridViewexamans_CellFormatting;
            dataGridViewexamans.CellFormatting += dataGridViewexamans_CellFormatting;
        }



        private void dataGridViewexamans_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewexamans.Columns[e.ColumnIndex].Name == "result")
            {
                var value = e.Value?.ToString();
                if (value == "Correct")
                {
                    dataGridViewexamans.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    dataGridViewexamans.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (value == "Wrong")
                {
                    dataGridViewexamans.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                    dataGridViewexamans.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void dataGridViewexamans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void paneltruely_Paint(object sender, PaintEventArgs e)
        {
            this.Controls.Add(paneltruely);

            paneltruely.Controls.Add(dataGridViewexamans);
            dataGridViewexamans.Dock = DockStyle.Fill;


        }
    }



}




