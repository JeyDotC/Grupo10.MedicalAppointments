namespace Grupo10.MedicalAppointments.Gui.Views
{
    partial class MedicalAppointmentsEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            availableDoctorsComboBox = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // availableDoctorsComboBox
            // 
            availableDoctorsComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            availableDoctorsComboBox.FormattingEnabled = true;
            availableDoctorsComboBox.Location = new Point(3, 263);
            availableDoctorsComboBox.Name = "availableDoctorsComboBox";
            availableDoctorsComboBox.Size = new Size(159, 23);
            availableDoctorsComboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 245);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Doctor";
            // 
            // MedicalAppointmentsEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(availableDoctorsComboBox);
            Name = "MedicalAppointmentsEditor";
            Size = new Size(165, 344);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ComboBox availableDoctorsComboBox;
        private Label label1;
    }
}
