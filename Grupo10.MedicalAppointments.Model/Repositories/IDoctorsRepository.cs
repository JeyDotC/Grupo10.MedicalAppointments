using Grupo10.MedicalAppointments.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo10.MedicalAppointments.Model.Repositories
{
    public interface IDoctorsRepository
    {
        IEnumerable<Doctor> GetAll();
    }
}
