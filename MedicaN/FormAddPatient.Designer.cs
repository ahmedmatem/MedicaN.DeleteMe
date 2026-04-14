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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            labelName = new Label();
            labelLastName = new Label();
            labelPin = new Label();
            labelGender = new Label();
            labelPhone = new Label();
            buttonAdd = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(49, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(49, 187);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(187, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(274, 49);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(174, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(274, 117);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(174, 23);
            textBox5.TabIndex = 4;
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
            // FormAddPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 316);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(labelPhone);
            Controls.Add(labelGender);
            Controls.Add(labelLastName);
            Controls.Add(labelName);
            Controls.Add(labelPin);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddPatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавяне на пациент";
            Load += FormAddPatient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label labelName;
        private Label labelLastName;
        private Label labelPin;
        private Label labelGender;
        private Label labelPhone;
        private Button buttonAdd;
        private Button buttonCancel;
    }
}