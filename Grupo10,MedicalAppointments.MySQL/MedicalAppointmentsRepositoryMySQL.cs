﻿using Grupo10.MedicalAppointments.Model.Entities;
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
    a.id, 
    a.name, 
    a.lastname, 
    a.identification, 
    a.phone, 
    a.date,
    d.id as d_id,
    d.name as d_name,
    d.specialty as d_speciality
FROM medical_appointments a join doctors d on a.doctor_id = d.id";
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
                        Doctor = new Doctor
                        {
                            Id = result.GetInt32("d_id"),
                            Name = result.GetString("d_name"),
                            Speciality = result.GetString("d_speciality"),
                        }
                    };
                }
            }
        }
    }
}