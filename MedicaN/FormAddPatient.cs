using MedicaN.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicaN
{
    public partial class FormAddPatient : Form
    {
        public Patient? NewPatient { get; private set; }

        public FormAddPatient()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var firstName = textBoxName.Text;
            var lastName = textBoxLastName.Text;
            var pin = textBoxPin.Text;
            var gender = comboBoxGender.Text;
            var phone = textBoxPhone.Text;

            NewPatient = new Patient()
            {
                FirstName = firstName,
                LastName = lastName,
                Pin = pin,
                Gender = gender,
                Phone = phone
            };
        }
    }
}
