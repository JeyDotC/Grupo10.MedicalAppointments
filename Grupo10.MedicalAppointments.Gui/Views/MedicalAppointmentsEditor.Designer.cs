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
            label2 = new Label();
            groupBox1 = new GroupBox();
            patientPhoneTextBox = new TextBox();
            label5 = new Label();
            patientIdentificationTextBox = new TextBox();
            label4 = new Label();
            patientLastNameTextBox = new TextBox();
            label3 = new Label();
            patientNameTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            appointmentDateTimePicker = new DateTimePicker();
            saveButton = new Button();
            cancelButton = new Button();
            appointmentTimePicker = new DateTimePicker();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // availableDoctorsComboBox
            // 
            availableDoctorsComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            availableDoctorsComboBox.FormattingEnabled = true;
            availableDoctorsComboBox.Location = new Point(3, 263);
            availableDoctorsComboBox.Name = "availableDoctorsComboBox";
            availableDoctorsComboBox.Size = new Size(188, 23);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(patientPhoneTextBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(patientIdentificationTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(patientLastNameTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(patientNameTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(3, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(188, 213);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Paciente";
            // 
            // patientPhoneTextBox
            // 
            patientPhoneTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            patientPhoneTextBox.Location = new Point(6, 173);
            patientPhoneTextBox.Name = "patientPhoneTextBox";
            patientPhoneTextBox.Size = new Size(176, 23);
            patientPhoneTextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 155);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 8;
            label5.Text = "Teléfono";
            // 
            // patientIdentificationTextBox
            // 
            patientIdentificationTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            patientIdentificationTextBox.Location = new Point(6, 128);
            patientIdentificationTextBox.Name = "patientIdentificationTextBox";
            patientIdentificationTextBox.Size = new Size(176, 23);
            patientIdentificationTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 110);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 6;
            label4.Text = "Identificación";
            // 
            // patientLastNameTextBox
            // 
            patientLastNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            patientLastNameTextBox.Location = new Point(6, 83);
            patientLastNameTextBox.Name = "patientLastNameTextBox";
            patientLastNameTextBox.Size = new Size(176, 23);
            patientLastNameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 65);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // patientNameTextBox
            // 
            patientNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            patientNameTextBox.Location = new Point(6, 37);
            patientNameTextBox.Name = "patientNameTextBox";
            patientNameTextBox.Size = new Size(176, 23);
            patientNameTextBox.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(95, 21);
            label6.TabIndex = 4;
            label6.Text = "Cita médica";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 289);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 9;
            label7.Text = "Fecha";
            // 
            // appointmentDateTimePicker
            // 
            appointmentDateTimePicker.Format = DateTimePickerFormat.Short;
            appointmentDateTimePicker.Location = new Point(3, 305);
            appointmentDateTimePicker.Name = "appointmentDateTimePicker";
            appointmentDateTimePicker.Size = new Size(95, 23);
            appointmentDateTimePicker.TabIndex = 10;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            saveButton.BackColor = SystemColors.Highlight;
            saveButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.ForeColor = SystemColors.ControlLightLight;
            saveButton.Location = new Point(113, 334);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(78, 37);
            saveButton.TabIndex = 11;
            saveButton.Text = "Guardar";
            saveButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cancelButton.Location = new Point(32, 342);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "Cancelar";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // appointmentTimePicker
            // 
            appointmentTimePicker.Format = DateTimePickerFormat.Time;
            appointmentTimePicker.Location = new Point(101, 305);
            appointmentTimePicker.Name = "appointmentTimePicker";
            appointmentTimePicker.Size = new Size(90, 23);
            appointmentTimePicker.TabIndex = 13;
            // 
            // MedicalAppointmentsEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(appointmentTimePicker);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(appointmentDateTimePicker);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(availableDoctorsComboBox);
            Name = "MedicalAppointmentsEditor";
            Size = new Size(194, 374);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ComboBox availableDoctorsComboBox;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox patientPhoneTextBox;
        private Label label5;
        private TextBox patientIdentificationTextBox;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label7;
        private DateTimePicker appointmentDateTimePicker;
        private TextBox patientLastNameTextBox;
        private TextBox patientNameTextBox;
        public Button saveButton;
        public Button cancelButton;
        private DateTimePicker appointmentTimePicker;
    }
}
