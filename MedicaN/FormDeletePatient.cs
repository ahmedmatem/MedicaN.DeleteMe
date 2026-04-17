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
    public partial class FormDeletePatient : Form
    {
        private Patient patient;

        public FormDeletePatient(Patient _patient)
        {
            InitializeComponent();
            patient = _patient;
        }

        private void FormDeletePatient_Load(object sender, EventArgs e)
        {
            labelDeleteMessage.Text = $"Сигурни ли сте, че искате да изтриете пациента {patient.FirstName} {patient.LastName}?";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
