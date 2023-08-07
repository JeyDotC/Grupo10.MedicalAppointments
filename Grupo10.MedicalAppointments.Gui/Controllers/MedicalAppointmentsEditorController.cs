using Grupo10.MedicalAppointments.Gui.Views;
using Grupo10.MedicalAppointments.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo10.MedicalAppointments.Gui.Controllers
{
    internal class MedicalAppointmentsEditorController
    {
        private readonly AppState _state;
        private readonly MedicalAppointmentsEditor _view;
        private readonly IDoctorsRepository _doctorsRepository;
        private readonly IMedicalAppointmentsRepository _medicalAppointmentsRepository;

        public MedicalAppointmentsEditorController(AppState state, MedicalAppointmentsEditor view, IDoctorsRepository doctorsRepository, IMedicalAppointmentsRepository medicalAppointmentsRepository)
        {
            _state = state;
            _view = view;
            _doctorsRepository = doctorsRepository;
            _medicalAppointmentsRepository = medicalAppointmentsRepository;
        }

        public void Setup()
        {
            _state.Doctors.OnChange((newData, oldData) =>
            {
                _view.availableDoctorsComboBox.Items.Clear();
                _view.availableDoctorsComboBox.Items.AddRange(newData.ToArray());
            });

            _state.CurrentMedicalAppointMent.OnChange((newData, oldData) => {
                _view.RenderData(newData);
            });

            _view.saveButton.Click += SaveButton_Click;
            _view.cancelButton.Click += CancelButton_Click;

            // Initial State
            if(!_state.Doctors.Value.Any())
            {
                _state.Doctors.Value = _doctorsRepository.GetAll();
            }

            _state.CurrentMedicalAppointMent.Value = new Model.Entities.MedicalAppointment();
        }

        private void CancelButton_Click(object? sender, EventArgs e)
        {
            _state.CurrentMedicalAppointMent.Value = new Model.Entities.MedicalAppointment();
        }

        private bool Validate(Model.Entities.MedicalAppointment appointment)
        {
            if (appointment == null)
            {
                return false;
            }

            if(
                string.IsNullOrWhiteSpace(appointment.Name) ||
                string.IsNullOrWhiteSpace(appointment.LastName) ||
                string.IsNullOrWhiteSpace(appointment.Identification) ||
                string.IsNullOrWhiteSpace(appointment.Phone) ||
                appointment.Doctor == null ||
                appointment.Doctor?.Id == 0
            )
            {
                return false;
            }

            return true;
        }

        private void SaveButton_Click(object? sender, EventArgs e)
        {
            var appointment = _view.Data;
            if(!Validate(appointment))
            {
                return;
            }

            if (appointment.Id == 0)
            {
                _medicalAppointmentsRepository.Add(appointment);
            }
            else
            {
                _medicalAppointmentsRepository.Update(appointment);
            }

            // Clear editor.
            _state.CurrentMedicalAppointMent.Value = new Model.Entities.MedicalAppointment();
            // Update appointments the list.
            _state.Appointments.Value = _medicalAppointmentsRepository.GetAll();
        }
    }
}
