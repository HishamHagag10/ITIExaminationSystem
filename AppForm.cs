using DB_Project.DB_Repository;
using DB_Project.DTOs;
using DB_Project.Helpers;
using ITIExaminationSystem.Helpers;

namespace ITIExaminationSystem
{
    public partial class AppForm : Form
    {
        private string _username = string.Empty;
        private string _password = string.Empty;
        private DB_Manager _dbManager;
        private LogedUser? _logedUser;

        public AppForm()
        {
            _dbManager = new DB_Manager();
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            showLoginTools();
        }

    }

}
