namespace MedicaN
{
    partial class FormAdminPatients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewPatients = new DataGridView();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pinDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patientBindingSource = new BindingSource(components);
            buttonExaminations = new Button();
            buttonAddPatient = new Button();
            buttonEditPatient = new Button();
            buttonDeletePatient = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPatients
            // 
            dataGridViewPatients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPatients.AutoGenerateColumns = false;
            dataGridViewPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPatients.Columns.AddRange(new DataGridViewColumn[] { firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, pinDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn });
            dataGridViewPatients.DataSource = patientBindingSource;
            dataGridViewPatients.Location = new Point(2, -1);
            dataGridViewPatients.Name = "dataGridViewPatients";
            dataGridViewPatients.Size = new Size(782, 355);
            dataGridViewPatients.TabIndex = 0;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "Име";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // pinDataGridViewTextBoxColumn
            // 
            pinDataGridViewTextBoxColumn.DataPropertyName = "Pin";
            pinDataGridViewTextBoxColumn.HeaderText = "ЕГН";
            pinDataGridViewTextBoxColumn.Name = "pinDataGridViewTextBoxColumn";
            pinDataGridViewTextBoxColumn.Width = 150;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Пол";
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.Width = 50;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // patientBindingSource
            // 
            patientBindingSource.DataSource = typeof(Data.Models.Patient);
            // 
            // buttonExaminations
            // 
            buttonExaminations.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonExaminations.Location = new Point(12, 385);
            buttonExaminations.Name = "buttonExaminations";
            buttonExaminations.Size = new Size(160, 23);
            buttonExaminations.TabIndex = 1;
            buttonExaminations.Text = "Покажи прегледи";
            buttonExaminations.UseVisualStyleBackColor = true;
            // 
            // buttonAddPatient
            // 
            buttonAddPatient.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonAddPatient.Location = new Point(208, 385);
            buttonAddPatient.Name = "buttonAddPatient";
            buttonAddPatient.Size = new Size(160, 23);
            buttonAddPatient.TabIndex = 2;
            buttonAddPatient.Text = "Добави пациент";
            buttonAddPatient.UseVisualStyleBackColor = true;
            buttonAddPatient.Click += buttonAddPatient_Click;
            // 
            // buttonEditPatient
            // 
            buttonEditPatient.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonEditPatient.Location = new Point(404, 385);
            buttonEditPatient.Name = "buttonEditPatient";
            buttonEditPatient.Size = new Size(160, 23);
            buttonEditPatient.TabIndex = 3;
            buttonEditPatient.Text = "Редактирай пациент";
            buttonEditPatient.UseVisualStyleBackColor = true;
            // 
            // buttonDeletePatient
            // 
            buttonDeletePatient.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDeletePatient.Location = new Point(601, 385);
            buttonDeletePatient.Name = "buttonDeletePatient";
            buttonDeletePatient.Size = new Size(160, 23);
            buttonDeletePatient.TabIndex = 4;
            buttonDeletePatient.Text = "Изтрий пациент";
            buttonDeletePatient.UseVisualStyleBackColor = true;
            // 
            // FormAdminPatients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 429);
            Controls.Add(buttonDeletePatient);
            Controls.Add(buttonEditPatient);
            Controls.Add(buttonAddPatient);
            Controls.Add(buttonExaminations);
            Controls.Add(dataGridViewPatients);
            Name = "FormAdminPatients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Пациенти";
            Load += FormAdminPatients_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPatients;
        private BindingSource patientBindingSource;
        private Button buttonExaminations;
        private Button buttonAddPatient;
        private Button buttonEditPatient;
        private Button buttonDeletePatient;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
    }
}