using MedicaN.Data;
using MedicaN.Data.Models;
using Microsoft.AspNet.Identity;

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
        }

        private User? Login(string username, string password)
        {
            HashPassword(password);
            using (var context = new HealthNdbContext())
            {
                return context.Users.FirstOrDefault(u =>
                    u.Username == username &&
                    u.PasswordHash == password);
            }
        }

        private string HashPassword(string password)
        {
            var hasher = new PasswordHasher();
            var hashedPassword = hasher.HashPassword(password);
            return hashedPassword;
        }
    }
}
