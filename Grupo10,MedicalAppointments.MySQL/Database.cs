using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo10_MedicalAppointments.MySQL
{
    public sealed class Database
    {
        private readonly string _connectionString;

        public Database(string connectionString)
        {
            _connectionString = connectionString;
        }

        public MySqlConnection Open()
        {
            var connection = new MySqlConnection(_connectionString); 
            connection.Open();
            return connection;
        }
    }
}
