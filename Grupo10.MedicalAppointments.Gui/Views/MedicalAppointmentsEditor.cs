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
        private int _currentAppointmentId = 0;

        public MedicalAppointmentsEditor()
        {
            InitializeComponent();
        }

        public MedicalAppointment Data => new MedicalAppointment
        {
            Id = _currentAppointmentId,
            Name = patientNameTextBox.Text,
            LastName = patientLastNameTextBox.Text,
            Identification = patientIdentificationTextBox.Text,
            Phone = patientPhoneTextBox.Text,
            Date = new DateTime(
                year: appointmentDateTimePicker.Value.Year,
                month: appointmentDateTimePicker.Value.Month,
                day: appointmentDateTimePicker.Value.Day,
                hour: appointmentTimePicker.Value.Hour,
                minute: appointmentTimePicker.Value.Minute,
                second: appointmentTimePicker.Value.Second
            ),
            Doctor = (Doctor)availableDoctorsComboBox.SelectedItem
        };

        public void RenderData(MedicalAppointment data)
        {
            _currentAppointmentId = data.Id;

            patientNameTextBox.Text = data.Name;
            patientLastNameTextBox.Text = data.LastName;
            patientIdentificationTextBox.Text = data.Identification;
            patientPhoneTextBox.Text = data.Phone;
            appointmentDateTimePicker.Value = data.Date;
            appointmentTimePicker.Value = data.Date;

            if (data.Doctor != null && data.Doctor.Id > 0)
            {
                var selectedItem = availableDoctorsComboBox.Items.OfType<Doctor>().FirstOrDefault(d => d.Id == data.Doctor.Id);
                availableDoctorsComboBox.SelectedItem = selectedItem;
            }
            else
            {
                availableDoctorsComboBox.SelectedItem = null;
            }

            patientNameTextBox.Focus();
        }
    }
}
