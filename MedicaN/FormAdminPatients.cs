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
    public partial class FormAdminPatients : Form
    {
        private User user;

        public FormAdminPatients(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FormAdminPatients_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void LoadPatients()
        {
            List<Patient> patients = GetPatientsFromDb();
            LoadPatientsInTable(patients);
        }

        private void LoadPatientsInTable(List<Patient> patients)
        {
            patientBindingSource.DataSource = patients;
        }

        private List<Patient> GetPatientsFromDb()
        {
            using (var context = new HealthNdbContext())
            {
                return context.Patients.ToList();
            }
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            var addPatientForm = new FormAddPatient();
            if (addPatientForm.ShowDialog() == DialogResult.OK)
            {
                Patient? newPatient = addPatientForm.NewPatient;
                if (newPatient is not null)
                {
                    SavePatientInDb(newPatient);
                    LoadPatients();
                }
            }
        }

        private void SavePatientInDb(Patient newPatient)
        {
            using (var context = new HealthNdbContext())
            {
                context.Patients.Add(newPatient);
                context.SaveChanges();
            }
        }

        private void buttonEditPatient_Click(object sender, EventArgs e)
        {
            var selectedPatient = (Patient)patientBindingSource.Current;
            if(selectedPatient is not null)
            {
                var editPationtForm = new FormEditPatient(selectedPatient);
                if(editPationtForm.ShowDialog() == DialogResult.OK)
                {
                    LoadPatients();
                }
            }
        }
    }
}
