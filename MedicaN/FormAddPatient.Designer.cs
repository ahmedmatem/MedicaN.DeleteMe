namespace MedicaN
{
    partial class FormAddPatient
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
            textBoxName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxPin = new TextBox();
            textBoxPhone = new TextBox();
            labelName = new Label();
            labelLastName = new Label();
            labelPin = new Label();
            labelGender = new Label();
            labelPhone = new Label();
            buttonAdd = new Button();
            buttonCancel = new Button();
            comboBoxGender = new ComboBox();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(49, 49);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(187, 23);
            textBoxName.TabIndex = 0;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(49, 117);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(187, 23);
            textBoxLastName.TabIndex = 1;
            // 
            // textBoxPin
            // 
            textBoxPin.Location = new Point(49, 187);
            textBoxPin.Name = "textBoxPin";
            textBoxPin.Size = new Size(187, 23);
            textBoxPin.TabIndex = 2;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(274, 117);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(174, 23);
            textBoxPhone.TabIndex = 4;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(49, 31);
            labelName.Name = "labelName";
            labelName.Size = new Size(34, 15);
            labelName.TabIndex = 5;
            labelName.Text = "Име:";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(49, 99);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(61, 15);
            labelLastName.TabIndex = 6;
            labelLastName.Text = "Фамилия:";
            // 
            // labelPin
            // 
            labelPin.AutoSize = true;
            labelPin.Location = new Point(49, 169);
            labelPin.Name = "labelPin";
            labelPin.Size = new Size(31, 15);
            labelPin.TabIndex = 7;
            labelPin.Text = "ЕГН:";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(274, 31);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(33, 15);
            labelGender.TabIndex = 8;
            labelGender.Text = "Пол:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(274, 99);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(59, 15);
            labelPhone.TabIndex = 9;
            labelPhone.Text = "Телефон:";
            // 
            // buttonAdd
            // 
            buttonAdd.DialogResult = DialogResult.OK;
            buttonAdd.Location = new Point(49, 249);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(187, 23);
            buttonAdd.TabIndex = 10;
            buttonAdd.Text = "Добавяне";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(274, 249);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(174, 23);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Отказ";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "мъж", "жена" });
            comboBoxGender.Location = new Point(274, 49);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(174, 23);
            comboBoxGender.TabIndex = 12;
            // 
            // FormAddPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 316);
            Controls.Add(comboBoxGender);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(labelPhone);
            Controls.Add(labelGender);
            Controls.Add(labelLastName);
            Controls.Add(labelName);
            Controls.Add(labelPin);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxPin);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddPatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавяне на пациент";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxLastName;
        private TextBox textBoxPin;
        private TextBox textBoxPhone;
        private Label labelName;
        private Label labelLastName;
        private Label labelPin;
        private Label labelGender;
        private Label labelPhone;
        private Button buttonAdd;
        private Button buttonCancel;
        private ComboBox comboBoxGender;
    }
}