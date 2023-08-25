using N29Backend.Services;

namespace FrontEnd.WinForm
{
    public partial class Form1 : Form
    {
        private readonly IUserService _userService;
        public Form1(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Click_Click(object sender, EventArgs e)
        {
            _userService.GetAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}