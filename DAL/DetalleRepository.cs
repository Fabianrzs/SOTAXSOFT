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

        public DetalleRepository(ConnectionManager connection)
        {
            _connection = connection._connection;
        }

        public void Guardar (Detalle detalle)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Detalles (CodigoDetalle, TipoDetalle, FechaDetalle, ValorDetalle, Descripcion, Placa)" +
                    "Values (@CodDetalle, @TipoDetalle, @FechaDetalle, @ValorDetalle, @Descripcion, @Placae)";
                command.Parameters.Add("@CodigoDetalle", SqlDbType.VarChar).Value = detalle.CodigoDetalle;
                command.Parameters.Add("@TipoDetalle", SqlDbType.VarChar).Value = detalle.TipoDetalle;
                command.Parameters.Add("@FechaDetalle", SqlDbType.DateTime).Value = detalle.FechaDetalle;
                command.Parameters.Add("@ValorDetalle", SqlDbType.Decimal).Value = detalle.ValorDetalle;
                command.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = detalle.Descripcion;
                command.Parameters.Add("@Placa", SqlDbType.VarChar).Value = detalle.Taxi.Placa;
                command.ExecuteNonQuery();
            }
        }

        //public Detalle ExistenCodigoDetalle(double codigoDetalle)
        //{
        //    SqlDataReader dataReader;

        //    using(var command = _connection.CreateCommand())
        //    {
        //        command.Parameters.Add("@CodDetalle", SqlDbType.Decimal).Value = codigoDetalle;
        //        command.CommandText = "SELECT * FROM DETALLE WHERE COIDIGODETALLE = @CodDetalle";
        //        dataReader = command.ExecuteReader();
        //        dataReader.Read();
        //        Detalle detalle = DataReaderMapToDetalle(dataReader);

        //        return detalle;


        //    }
        //}

        //private Detalle DataReaderMapToDetalle(SqlDataReader dataReader)
        //{
        //    if (!dataReader.HasRows) return null;

        //    Detalle detalle = null;

        //    return detalle;

        //}
    }
}
