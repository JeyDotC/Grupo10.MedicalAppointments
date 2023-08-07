using Grupo10.MedicalAppointments.Model.Entities;
using Grupo10.MedicalAppointments.Model.Repositories;

namespace Grupo10_MedicalAppointments.MySQL
{
    public class DoctorsRepositoryMySql : IDoctorsRepository
    {
        private readonly Database _db;

        public DoctorsRepositoryMySql(Database connection)
        {
            _db = connection;
        }

        public IEnumerable<Doctor> GetAll()
        {
            {
                using (var connection = _db.Open())
                {
                    var command = connection.CreateCommand();
                    command.CommandText = @"SELECT
    id,
    name,
    specialty
FROM doctors";
                    var result = command.ExecuteReader();

                    while (result.Read())
                    {
                        yield return new Doctor
                        {
                            Id = result.GetInt32("id"),
                            Name = result.GetString("name"),
                            Speciality = result.GetString("specialty"),
                        };
                    }
                }
            }
        }
    }
}
