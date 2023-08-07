using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo10.MedicalAppointments.Model.Entities
{
    public class Doctor
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Speciality { get; set; } = string.Empty;
    }
}
