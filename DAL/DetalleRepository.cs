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
    public class DetalleRepository
    {
        private SqlConnection _connection;
        private TaxiRepository repository;

        public DetalleRepository(ConnectionManager connection)
        {
            _connection = connection._connection;
            repository = new TaxiRepository(connection);
        }

        public void GuardarDetalle (Detalle detalle)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Detalles (CodigoDetalle, TipoDetalle, FechaDetalle, ValorDetalle, Descripcion, Placa)" +
                    "Values (@CodDetalle, @TipoDetalle, @FechaDetalle, @ValorDetalle, @Descripcion, @Placae)";
                command.Parameters.Add("@CodigoDetalle", SqlDbType.Decimal).Value = detalle.CodigoDetalle;
                command.Parameters.Add("@TipoDetalle", SqlDbType.VarChar).Value = detalle.TipoDetalle;
                command.Parameters.Add("@FechaDetalle", SqlDbType.DateTime).Value = detalle.FechaDetalle;
                command.Parameters.Add("@ValorDetalle", SqlDbType.Decimal).Value = detalle.ValorDetalle;
                command.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = detalle.Descripcion;
                command.Parameters.Add("@Placa", SqlDbType.VarChar).Value = detalle.Taxi.Placa;
                command.ExecuteNonQuery();
            }
        }

        public Detalle BuscarPorCodigoDetalle(double codigoDetalle)
        {
            SqlDataReader dataReader;

            using (var command = _connection.CreateCommand())
            {
                command.Parameters.Add("@CodDetalle", SqlDbType.Decimal).Value = codigoDetalle;
                command.CommandText = "SELECT * FROM DETALLES";
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToDetalle(dataReader);
            }
        }

        public List<Detalle> ConsultarDetalles()
        {
            List<Detalle> detalles = new List<Detalle>();

            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM DETALLES";

                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        detalles.Add(DataReaderMapToDetalle(dataReader));
                    }
                }
            }
            return detalles;
        }

        public int Modificar(Detalle detalle)
        {
            using (var command = _connection.CreateCommand())
            {
                command.Parameters.Add("@CodigoDetalle", SqlDbType.VarChar).Value = detalle.CodigoDetalle;
                command.Parameters.Add("@FechaDetalle", SqlDbType.DateTime).Value = detalle.FechaDetalle;
                command.Parameters.Add("@ValorDetalle", SqlDbType.Decimal).Value = detalle.ValorDetalle;
                command.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = detalle.Descripcion;
                command.Parameters.Add("@Placa", SqlDbType.VarChar).Value = detalle.Taxi.Placa;

                command.CommandText = "UPDATE DETALLES SET FechaDetalle = @FechaDetalle, " +
                    "ValorDetalle = @ValorDetalle, Placa = @Placa Where CodigoDetalle = @CodigoDetalle ";
                return command.ExecuteNonQuery();
            }
        }

        public int Eliminar(double codDetalle)
        {
            using (var command = _connection.CreateCommand())
            {
                command.Parameters.Add("@CodigoDetalle", SqlDbType.Decimal).Value = codDetalle;
                command.CommandText = "Delete Detalles where CodigoDetalle = @CodigoDetalle";
                return command.ExecuteNonQuery();
            }
        }



        private Detalle DataReaderMapToDetalle(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;

            Detalle detalle;

            if (((string)dataReader["TipoDetalle"]).Equals("REPARACION"))
            {
                detalle = new DetalleGasto(repository.BuscarPorPlaca((string)dataReader["Placa"]))
                {
                    CodigoDetalle = (double)dataReader["CodigoDetalle"],
                    Descripcion = (string)dataReader["Descripcion"],
                    FechaDetalle = (DateTime)dataReader["FechaDetalle"],
                    ValorDetalle = (double)dataReader["ValorDetalle"]
                };
            }
            else
            {
                detalle = new DetalleIngreso(repository.BuscarPorPlaca((string)dataReader["Placa"]))
                {
                    CodigoDetalle = (double)dataReader["CodigoDetalle"],
                    Descripcion = (string)dataReader["Descripcion"],
                    FechaDetalle = (DateTime)dataReader["FechaDetalle"],
                    ValorDetalle = (double)dataReader["ValorDetalle"]
                };
            }
            return detalle;
        }
    }
}
