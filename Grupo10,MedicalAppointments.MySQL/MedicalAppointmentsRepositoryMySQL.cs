using Grupo10.MedicalAppointments.Model.Entities;
using Grupo10.MedicalAppointments.Model.Repositories;

namespace Grupo10_MedicalAppointments.MySQL
{
    public class MedicalAppointmentsRepositoryMySQL : IMedicalAppointmentsRepository
    {
        private readonly Database _db;

        public MedicalAppointmentsRepositoryMySQL(Database connection)
        {
            _db = connection;
        }

        public void Add(MedicalAppointment medicalAppointment)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MedicalAppointment> GetAll()
        {
            using(var connection = _db.Open())
            {
                var command = connection.CreateCommand();
                command.CommandText = @"SELECT 
id, 
name, 
lastname, 
identification, 
phone, 
date, 
doctor_id 
FROM 
medical_appointments";
                var result = command.ExecuteReader();

                while(result.Read())
                {
                    yield return new MedicalAppointment
                    {
                        Id = result.GetInt32("id"),
                        Name = result.GetString("name"),
                        LastName = result.GetString("lastname"),
                        Identification = result.GetString("identification"),
                        Phone = result.GetString("phone"),
                        Date = result.GetDateTime("date"),
                    };
                }
            }
        }
    }
}