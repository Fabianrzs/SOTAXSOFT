using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaxiRepository
    {
        private SqlConnection _connection;

        public TaxiRepository(ConnectionManager connection)
        {
            _connection = connection._connection;
        }

        public void GuardarTaxi(Taxi taxi)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Taxis (Placa, Modelo, Kilometraje)" +
                    "Values (@Placa, @Modelo, @Kilometraje)";
                command.Parameters.Add("@Placa", SqlDbType.VarChar).Value = taxi.Placa;
                command.Parameters.Add("@Modelo", SqlDbType.Decimal).Value = taxi.Modelo;
                command.Parameters.Add("@Kilometraje", SqlDbType.Decimal).Value = taxi.Kilometraje;
                command.ExecuteNonQuery();
            }
        }
    }
}
