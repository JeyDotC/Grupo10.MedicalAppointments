using Grupo10.MedicalAppointments.Gui.Views;
using Grupo10.MedicalAppointments.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo10.MedicalAppointments.Gui.Controllers
{
    internal class MedicalAppointmentsListController
    {
        private readonly AppState _state;
        private readonly MedicalAppointmentsList _view;
        private readonly IMedicalAppointmentsRepository _medicalAppointmentsRepository;

        public MedicalAppointmentsListController(AppState state, MedicalAppointmentsList view, IMedicalAppointmentsRepository medicalAppointmentsRepository)
        {
            _state = state;
            _view = view;
            _medicalAppointmentsRepository = medicalAppointmentsRepository;
        }

        public void Setup()
        {
            _state.Appointments.OnChange((newData, oldData) =>
            {
                _view.RenderData(newData);
            });

            // Initial load
            _state.Appointments.Value = _medicalAppointmentsRepository.GetAll();
        }
    }
}
