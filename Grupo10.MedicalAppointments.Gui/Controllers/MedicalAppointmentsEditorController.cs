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

        public MedicalAppointmentsEditorController(AppState state, MedicalAppointmentsEditor view, IDoctorsRepository doctorsRepository)
        {
            _state = state;
            _view = view;
            _doctorsRepository = doctorsRepository;
        }

        public void Setup()
        {
            _state.Doctors.OnChange((newData, oldData) =>
            {
                _view.availableDoctorsComboBox.Items.Clear();
                _view.availableDoctorsComboBox.Items.AddRange(newData.ToArray());
            });

            if(!_state.Doctors.Value.Any())
            {
                _state.Doctors.Value = _doctorsRepository.GetAll();
            }
        }
    }
}
