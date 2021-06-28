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
                command.Parameters.Add("@Modelo", SqlDbType.Decimal).Value = taxi.Modelo;
                command.Parameters.Add("@Kilometraje", SqlDbType.Decimal).Value = taxi.Kilometraje;
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

                command.CommandText = "select Placa, Modelo, Kilometraje, IdPropietario, " +
                    "IdConductor from Taxis";

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

                command.Parameters.Add("@Placa", SqlDbType.VarChar).Value = taxi.Placa;
                command.Parameters.Add("@Modelo", SqlDbType.Decimal).Value = taxi.Modelo;
                command.Parameters.Add("@Kilometraje", SqlDbType.Decimal).Value = taxi.Kilometraje;
                command.Parameters.Add("@IdConductor", SqlDbType.VarChar).Value = taxi.Conductor.Identificacion;
                command.Parameters.Add("@IdPropietario", SqlDbType.VarChar).Value = taxi.Propietario.Identificacion;

                command.CommandText = "Update Taxis set Modelo = @Modelo," +
                   " Kilometraje = @Kilometraje, IdConductor =  @IdConductor, " +
                   "IdPropietario = @IdPropietario, where Placa = @Placa";
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
            Persona persona;
            if (!dataReader.HasRows) return taxi;
            else
            {
                taxi = new Taxi();

                taxi.Placa = dataReader.GetString(0);
                taxi.Modelo = dataReader.GetDouble(1);
                taxi.Kilometraje = dataReader.GetDouble(2);
                persona = repository.BuscarPorIdentificacion(dataReader.GetString(3));
                taxi.Propietario = (Propietario)persona;
                persona = repository.BuscarPorIdentificacion(dataReader.GetString(4));
                taxi.Conductor = (Conductor)persona;
            }
            return taxi;

        }
    }
}
