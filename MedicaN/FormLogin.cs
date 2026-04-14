using MedicaN.Data;
using MedicaN.Data.Models;
using Microsoft.EntityFrameworkCore;
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
                        ShowAdminPatients(user);
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

        private void ShowAdminPatients(User user)
        {
            throw new NotImplementedException();
        }

        private User? Login(string username, string password)
        {
            using (var context = new HealthNdbContext())
            {
                return context.Users
                    .Include(u => u.Role)
                    .FirstOrDefault(u =>
                        u.Username == username &&
                        u.PasswordHash == HashPassword(password)
                    );
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
