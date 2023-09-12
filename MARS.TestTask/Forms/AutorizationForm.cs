using MARS.TestTask.DBContext;
using MARS.TestTask.Forms;

namespace MARS.TestTask
{
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void textbox_connectionString_TextChanged(object sender, EventArgs e)
        {
            ConnectionOptions.DBName = textbox_connectionString.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ConnectionOptions.UserId = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ConnectionOptions.Password = textBox3.Text;
        }

        private void button_connection_Click(object sender, EventArgs e)
        {
            try
            {
                var ss = new MsSqlContext();
                var form = new TableViewForm();
                form.ShowDialog();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
    }
}