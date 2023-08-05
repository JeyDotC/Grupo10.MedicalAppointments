using Grupo10.MedicalAppointments.Model.Entities;
using Grupo10.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo10.MedicalAppointments.Gui
{
    internal class AppState
    {
        public StateUnit<MedicalAppointment> CurrentMedicalAppointMent { get; } = new StateUnit<MedicalAppointment>(new MedicalAppointment());

        public StateUnit<IEnumerable<MedicalAppointment>> Appointments { get; } = new StateUnit<IEnumerable<MedicalAppointment>>(Enumerable.Empty<MedicalAppointment>());

    }
}
