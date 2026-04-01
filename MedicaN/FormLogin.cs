using MedicaN.Data;
using MedicaN.Data.Models;
using System.Security.Cryptography;
using System.Text;

namespace MedicaN
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var username = textBoxUsername.Text;
            var password = textBoxPassword.Text;
            var user = Login(username, password);
            if(user is null)
            {
                // login failed
                MessageBox.Show("Login failed. Try again.");
            }
            else
            {
                // login successful
                switch (user.Role.RoleName)
                {
                    case "Admin":
                        MessageBox.Show("Go to Admin panel.");
                        break;
                    case "Doctor":
                        MessageBox.Show("Go to Doctor panel.");
                        break;
                    default:
                        MessageBox.Show("Error: undefined role.");
                        break;
                }               
            }
        }

        private User? Login(string username, string password)
        {
            using (var context = new HealthNdbContext())
            {
                return context.Users.FirstOrDefault(u =>
                    u.Username == username &&
                    u.PasswordHash == HashPassword(password));
            }
        }

        private string HashPassword(string password)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = SHA256.HashData(bytes);

            StringBuilder sb = new StringBuilder(hashBytes.Length * 2);
            foreach (byte b in hashBytes)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
