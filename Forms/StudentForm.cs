using DB_Project.DB_Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ITIExaminationSystem.Forms
{
    public partial class StudentForm : Form
    {
        private DB_Manager _dbManager;
        public StudentForm(DB_Manager dB_Manager)
        {
            _dbManager = dB_Manager;
            InitializeComponent();
        }
    }
}
