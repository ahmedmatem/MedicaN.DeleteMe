namespace MedicaN
{
    partial class FormEditPatient
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
            comboBoxGender = new ComboBox();
            buttonCancel = new Button();
            buttonEdit = new Button();
            labelPhone = new Label();
            labelGender = new Label();
            labelLastName = new Label();
            labelName = new Label();
            labelPin = new Label();
            textBoxPhone = new TextBox();
            textBoxPin = new TextBox();
            textBoxLastName = new TextBox();
            textBoxName = new TextBox();
            SuspendLayout();
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "мъж", "жена" });
            comboBoxGender.Location = new Point(291, 47);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(174, 23);
            comboBoxGender.TabIndex = 24;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(291, 247);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(174, 23);
            buttonCancel.TabIndex = 23;
            buttonCancel.Text = "Отказ";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.DialogResult = DialogResult.OK;
            buttonEdit.Location = new Point(66, 247);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(187, 23);
            buttonEdit.TabIndex = 22;
            buttonEdit.Text = "Редактиране";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(291, 97);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(59, 15);
            labelPhone.TabIndex = 21;
            labelPhone.Text = "Телефон:";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(291, 29);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(33, 15);
            labelGender.TabIndex = 20;
            labelGender.Text = "Пол:";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(66, 97);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(61, 15);
            labelLastName.TabIndex = 18;
            labelLastName.Text = "Фамилия:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(66, 29);
            labelName.Name = "labelName";
            labelName.Size = new Size(34, 15);
            labelName.TabIndex = 17;
            labelName.Text = "Име:";
            // 
            // labelPin
            // 
            labelPin.AutoSize = true;
            labelPin.Location = new Point(66, 167);
            labelPin.Name = "labelPin";
            labelPin.Size = new Size(31, 15);
            labelPin.TabIndex = 19;
            labelPin.Text = "ЕГН:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(291, 115);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(174, 23);
            textBoxPhone.TabIndex = 16;
            // 
            // textBoxPin
            // 
            textBoxPin.Location = new Point(66, 185);
            textBoxPin.Name = "textBoxPin";
            textBoxPin.Size = new Size(187, 23);
            textBoxPin.TabIndex = 15;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(66, 115);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(187, 23);
            textBoxLastName.TabIndex = 14;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(66, 47);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(187, 23);
            textBoxName.TabIndex = 13;
            // 
            // FormEditPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 325);
            Controls.Add(comboBoxGender);
            Controls.Add(buttonCancel);
            Controls.Add(buttonEdit);
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
            Name = "FormEditPatient";
            Text = "Редактиране на пациент";
            Load += FormEditPatient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxGender;
        private Button buttonCancel;
        private Button buttonEdit;
        private Label labelPhone;
        private Label labelGender;
        private Label labelLastName;
        private Label labelName;
        private Label labelPin;
        private TextBox textBoxPhone;
        private TextBox textBoxPin;
        private TextBox textBoxLastName;
        private TextBox textBoxName;
    }
}