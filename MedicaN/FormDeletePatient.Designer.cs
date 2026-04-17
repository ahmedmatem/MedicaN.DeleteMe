namespace MedicaN
{
    partial class FormDeletePatient
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
            labelDeleteMessage = new Label();
            buttonDelete = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelDeleteMessage
            // 
            labelDeleteMessage.AutoSize = true;
            labelDeleteMessage.Location = new Point(49, 31);
            labelDeleteMessage.Name = "labelDeleteMessage";
            labelDeleteMessage.Size = new Size(38, 15);
            labelDeleteMessage.TabIndex = 0;
            labelDeleteMessage.Text = "label1";
            // 
            // buttonDelete
            // 
            buttonDelete.DialogResult = DialogResult.OK;
            buttonDelete.Location = new Point(49, 76);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(190, 23);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Изтриване";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(256, 76);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(190, 23);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Отказ";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormDeletePatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 145);
            Controls.Add(buttonCancel);
            Controls.Add(buttonDelete);
            Controls.Add(labelDeleteMessage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDeletePatient";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Изтриване на пациент";
            Load += FormDeletePatient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDeleteMessage;
        private Button buttonDelete;
        private Button buttonCancel;
    }
}