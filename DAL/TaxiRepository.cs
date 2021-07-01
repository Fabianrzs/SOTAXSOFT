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
        private PersonaRepository repository;

        public TaxiRepository(ConnectionManager connection)
        {
             repository = new PersonaRepository(connection);
            _connection = connection._connection;
        }

        public void GuardarTaxi(Taxi taxi)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Taxis (Placa, Modelo, Kilometraje, IdPropietario,IdConductor)" +
                    "Values (@Placa, @Modelo, @Kilometraje, @IdPropietario, @IdConductor)";
                command.Parameters.Add("@Placa", SqlDbType.VarChar).Value = taxi.Placa;
                command.Parameters.Add("@Modelo", SqlDbType.VarChar).Value = taxi.Modelo;
                command.Parameters.Add("@Kilometraje", SqlDbType.VarChar).Value = taxi.Kilometraje;
                command.Parameters.Add("@IdConductor", SqlDbType.VarChar).Value = taxi.Conductor.Identificacion;
                command.Parameters.Add("@IdPropietario", SqlDbType.VarChar).Value = taxi.Propietario.Identificacion;

                command.ExecuteNonQuery();
            }
        }

        public Taxi BuscarPorPlaca(string placa)
        {

            using (var command = _connection.CreateCommand())
            {
                command.Parameters.Add("@Placa", SqlDbType.VarChar).Value = placa;
                command.CommandText = "select Placa, Modelo, Kilometraje, IdPropietario, " +
                    "IdConductor from Taxis where Placa=@Placa";

                var dataReader = command.ExecuteReader();
                dataReader.Read();

                return DataReaderMapToTaxi(dataReader);
            }
        }

        public List<Taxi> ConsultarTaxis()
        {
            List<Taxi> taxis = new List<Taxi>();

            using (var command = _connection.CreateCommand())
            {

                command.CommandText = "SELECT Placa, Modelo, Kilometraje, IdPropietario, IdConductor FROM TAXIS";

                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Taxi taxi = DataReaderMapToTaxi(dataReader);
                        taxis.Add(taxi);
                    }
                }
            }
            return taxis;
        }

        public int Modificar(Taxi taxi)
        {
            using (var command = _connection.CreateCommand())
            {
                
                command.Parameters.Add("@Modelo", SqlDbType.Decimal).Value = taxi.Modelo;
                command.Parameters.Add("@Kilometraje", SqlDbType.VarChar).Value = taxi.Kilometraje;
                command.Parameters.Add("@IdConductor", SqlDbType.VarChar).Value = taxi.Conductor.Identificacion;
                command.Parameters.Add("@IdPropietario", SqlDbType.VarChar).Value = taxi.Propietario.Identificacion;
                command.Parameters.Add("@Placa", SqlDbType.VarChar).Value = taxi.Placa;

                command.CommandText = "Update Taxis set Modelo = @Modelo, Kilometraje = @Kilometraje, IdConductor =  @IdConductor, IdPropietario = @IdPropietario where Placa = @Placa";
                return command.ExecuteNonQuery();
            }
        }

        public int Eliminar(string placa)
        {
            using (var command = _connection.CreateCommand())
            {
                command.Parameters.Add("@Placa", SqlDbType.VarChar).Value = placa;
                command.CommandText = "Delete Taxis where Placa = @Placa";
                return command.ExecuteNonQuery();

            }
        }

        private Taxi DataReaderMapToTaxi(SqlDataReader dataReader)
        {
            Taxi taxi = null;
            
            if (!dataReader.HasRows) return taxi;
            else
            {
                string placa = (string)dataReader["Placa"];
                string modelo = (string)dataReader["Modelo"];
                string kilometraje = (string)dataReader["Kilometraje"];

                Conductor conductor = (Conductor)repository.BuscarPorIdentificacion((string)dataReader["IdConductor"]);
                Propietario propietario = (Propietario)repository.BuscarPorIdentificacion((string)dataReader["IdPropietario"]);

                taxi = new Taxi(propietario, conductor)
                {
                    Placa = (string)dataReader["Placa"],
                    Modelo = (string)dataReader["Modelo"],
                    Kilometraje = (string)dataReader["Kilometraje"]
                };            
            }
            return taxi;
        }
    }
}
