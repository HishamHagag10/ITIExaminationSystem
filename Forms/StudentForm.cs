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


        public StudentForm(DB_Manager dB_Manager, int studentId, int examnum)
        {
            _dbManager = dB_Manager;
            _studentId = studentId;
            InitializeComponent();
            _examnum = examnum;
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
        //student information

        private void iNFOToolStripMenuItem_Click(object sender, EventArgs e)
        {

            HideAllControls();
            panel01.Visible = true;
            panel01.Dock = DockStyle.Fill;
            StudentDTO studentDto = new StudentDTO()
            {
                std_first_name = fname_lbl.Text,
                std_last_name = lname_lbl.Text,
                std_phoneno = phone_lbl.Text,
                std_email = email_lbl.Text,
            };
            //int :status   .... data
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


        //allcourses




        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoggedOut?.Invoke();
            this.Close();
        }

        //offictal appearing course
        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDetails.Visible = false;
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
            panelexam.Controls.Clear();

            Label lbl = new Label();
            lbl.Text = q.qus_text;
            lbl.AutoSize = true;
            lbl.Font = new Font("Arial", 12, FontStyle.Bold);
            lbl.Location = new Point(10, 10);
            panelexam.Controls.Add(lbl);

            FlowLayoutPanel flp = new FlowLayoutPanel();
            flp.Location = new Point(10, 50);
            flp.Size = new Size(400, 150);
            panelexam.Controls.Add(flp);

            foreach (var choice in q.Choices)
            {
                CheckBox cb = new CheckBox();
                cb.Text = choice;
                cb.AutoSize = true;

                cb.Checked = (q.SelectedAnswer == choice);

                cb.CheckedChanged += (s, e) =>
                {
                    if (cb.Checked)
                    {
                        q.SelectedAnswer = cb.Text;

                        foreach (var other in flp.Controls.OfType<CheckBox>())
                        {
                            if (other != cb)
                                other.Checked = false;
                        }
                    }
                };

                flp.Controls.Add(cb);
            }

            System.Windows.Forms.Button btnNext = new System.Windows.Forms.Button();
            btnNext.Text = currentIndex == examQuestions.Count - 1 ? "Finish" : "Next";
            btnNext.Location = new Point(10, flp.Bottom + 10);
            btnNext.Width = 100;
            btnNext.Height = 40;
            btnNext.Click += BtnNext_Click;

            panelexam.Controls.Add(btnNext);
        }



        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < examQuestions.Count - 1)
            {
                currentIndex++;
                DisplayQuestion(examQuestions[currentIndex]);
            }
            else
            {
                MessageBox.Show("Exam Finished, Good Luck!");



                //  panel1_Paint_1(sender, e)
                panelexam.Controls.Clear();
                //  panelexam.Visible = false;
                //panelshow.Visible = true;
                examcorrectgrade.Parent = panelexam;
                examcorrectgrade.Visible = true;
                examcorrectgrade.Enabled = true;


                //menu.Visible = true;


            }
        }
        //grade 
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



        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {


            HideAllControls();
            panelexam.Visible = true;
            panelexam.Dock = DockStyle.Fill;

            if (examQuestions == null || examQuestions.Count == 0)
            {
                MessageBox.Show("No exam questions available.");
                return;
            }

            currentIndex = 0;
            //DisplayQuestion(examQuestions[currentIndex], showAnswer: true);


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
            //HideAllControls();
            //panel01.Visible = true;
            //panel01.Dock = DockStyle.Fill;

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

    
        //private void btnTakeExam_Click(object sender, EventArgs e)
        //{
        //}

        private void TakeExam_Click(object sender, EventArgs e)
        {





        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


            //if (textBox1cid.Text == SP.takeExam{ @crsid_})
            //{
            TakeExam_Click(sender, e); return;
            //}
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
                q.Choices = q.choices.Split(',').Select(x => x.Trim()).ToList()
            );

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
    }
}



