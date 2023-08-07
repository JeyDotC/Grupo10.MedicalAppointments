using Grupo10.MedicalAppointments.Model.Entities;
using Grupo10.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo10.MedicalAppointments.Gui.Views
{
    public partial class MedicalAppointmentsEditor : UserControl, IRenderData<MedicalAppointment>, IReturnData<MedicalAppointment>
    {
        public MedicalAppointmentsEditor()
        {
            InitializeComponent();
        }

        public MedicalAppointment Data => new MedicalAppointment
        {
            Name = patientNameTextBox.Text,
            LastName = patientLastNameTextBox.Text,
            Identification = patientIdentificationTextBox.Text,
            Phone = patientPhoneTextBox.Text,
            Date = appointmentDateTimePicker.Value,
            Doctor = (Doctor)availableDoctorsComboBox.SelectedItem
        };

        public void RenderData(MedicalAppointment data)
        {
            patientNameTextBox.Text = data.Name;
            patientLastNameTextBox.Text = data.LastName;
            patientIdentificationTextBox.Text = data.Identification;
            patientPhoneTextBox.Text = data.Phone;
            appointmentDateTimePicker.Value = data.Date;
        }
    }
}
