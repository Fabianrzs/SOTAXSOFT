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
    public class Repository
    {
        private SqlConnection _connection;

        public Repository(ConnectionManager connection)
        {
            _connection = connection._connection;
        }

        public void GuardarPersona(Persona persona)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO PERSONAS (Identificacion, PrimeroNombre, SegundoNombre, " +
                    "PrimeroApellido, SegundoApellido, NumeroContacto, Rol)" +
                    "Values (@Identificacion,@PrimeroNombre,@SegundoNombre,@PrimeroApellido,@SegundoApellido,@NumeroContacto,@Rol)";

                command.Parameters.Add("@Identificacion", SqlDbType.VarChar).Value = persona.Identificacion;
                command.Parameters.Add("@PrimeroNombre", SqlDbType.VarChar).Value = persona.PrimerNombre;
                command.Parameters.Add("@SegundoNombre", SqlDbType.VarChar).Value = persona.SegundoNombre;
                command.Parameters.Add("@PrimeroApellido", SqlDbType.VarChar).Value = persona.PrimeroApellido;
                command.Parameters.Add("@SegundoApellido", SqlDbType.VarChar).Value = persona.SegundoApellido;
                command.Parameters.Add("@NumeroContacto", SqlDbType.VarChar).Value = persona.NumeroContacto;
                command.Parameters.Add("@Rol", SqlDbType.VarChar).Value = persona.Rol;

                command.ExecuteNonQuery();

            }
        }

        public void GuardarTaxi(Taxi taxi)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO TAXIS (Placa, Modelo, Kilometraje)" +
                    "Values (@Placa,@Modelo,@Kilometraje)";
                command.Parameters.Add("@Placa", SqlDbType.VarChar).Value = taxi.Placa;
                command.Parameters.Add("@Modelo", SqlDbType.Decimal).Value = taxi.Modelo;
                command.Parameters.Add("@Kilometraje", SqlDbType.Decimal).Value = taxi.Kilometraje;

                command.ExecuteNonQuery();

            }
        }

        public void GuardarDetalle(Detalle detalle)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO DETALLES (CodDetalle, TipoDetalle, FechaDetalle, " +
                    "ValorDetalle, DescripcionDetalle, PlacaDetalle)" +
                    "Values (@CodDetalle,@TipoDetalle,@FechaDetalle,@ValorDetalle,@DescripcionDetalle,@PlacaDetalle)";

                command.Parameters.Add("@CodDetalle", SqlDbType.Decimal).Value = detalle.CodigoDetalle;
                command.Parameters.Add("@TipoDetalle", SqlDbType.VarChar).Value = detalle.TipoDetalle;
                command.Parameters.Add("@FechaDetalle", SqlDbType.DateTime).Value = detalle.FechaDetalle;
                command.Parameters.Add("@ValorDetalle", SqlDbType.Decimal).Value = detalle.ValorDetalle;
                command.Parameters.Add("@DescripcionDetalle", SqlDbType.VarChar).Value = detalle.Descripcion;
                command.Parameters.Add("@PlacaDetalle", SqlDbType.VarChar).Value = detalle.Placa;

                command.ExecuteNonQuery();

            }

        }

        public Taxi PlacaExistente(string placa)
        {


            return null;
        }

        public Persona IdentificacionExistente(string identificacion)
        {


            return null;
        }

    }
}
