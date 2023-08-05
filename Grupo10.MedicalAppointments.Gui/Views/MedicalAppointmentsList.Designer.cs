namespace Grupo10.MedicalAppointments.Gui.Views
{
    partial class MedicalAppointmentsList
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
            appointmentsGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)appointmentsGridView).BeginInit();
            SuspendLayout();
            // 
            // appointmentsGridView
            // 
            appointmentsGridView.AllowUserToAddRows = false;
            appointmentsGridView.AllowUserToDeleteRows = false;
            appointmentsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentsGridView.Dock = DockStyle.Fill;
            appointmentsGridView.Location = new Point(0, 0);
            appointmentsGridView.Name = "appointmentsGridView";
            appointmentsGridView.ReadOnly = true;
            appointmentsGridView.RowTemplate.Height = 25;
            appointmentsGridView.Size = new Size(352, 367);
            appointmentsGridView.TabIndex = 0;
            // 
            // MedicalAppointmentsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(appointmentsGridView);
            Name = "MedicalAppointmentsList";
            Size = new Size(352, 367);
            ((System.ComponentModel.ISupportInitialize)appointmentsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView appointmentsGridView;
    }
}
