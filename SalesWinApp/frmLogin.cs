using BusinessObject;
using Microsoft.Extensions.Configuration;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var adminDefaultSettings = Program.Configuration.GetSection("AdminAccount").Get<MemberObject>();//.Get<MemberObject>();
            var adminEmail = adminDefaultSettings.Email;//.Email
            var adminPassword = adminDefaultSettings.Password;//Password
            var email = txtEmail.Text;
            var password = txtPassword.Text;

            if (String.IsNullOrEmpty(email))
            {
                MessageBox.Show("Your is email is empty or wrong Information and try again!");

            }
            else if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Your is password is empty or wrong Information and try again!");
            }
            else
            {
                try
                {
                    if (email.Equals(adminEmail) && password.Equals(adminPassword))
                    {
                        frmMain frmMain = new frmMain();
                        this.Hide();
                        frmMain.ShowDialog();
                        this.Show();
                    }
                    else
                    {                      
                            MessageBox.Show("Not Suppose Yet");                      
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something went wrong");
                }
            }
        }
    }
}