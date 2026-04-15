using MedicaN.Data;
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
    public partial class FormEditPatient : Form
    {
        public Patient Patient { get; private set; }

        public FormEditPatient(Patient patient)
        {
            InitializeComponent();
            Patient = patient;
        }

        private void FormEditPatient_Load(object sender, EventArgs e)
        {
            textBoxName.Text = Patient.FirstName;
            textBoxLastName.Text = Patient.LastName;
            textBoxPin.Text = Patient.Pin;
            comboBoxGender.Text = Patient.Gender;
            textBoxPhone.Text = Patient.Phone;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Patient.FirstName = textBoxName.Text;
            Patient.LastName = textBoxLastName.Text;
            Patient.Pin = textBoxPin.Text;
            Patient.Gender = comboBoxGender.Text;
            Patient.Phone = textBoxPhone.Text;
        }
    }
}
