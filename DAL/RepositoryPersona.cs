using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RepositoryPersona
    {

        private SqlConnection _connection;

        public RepositoryPersona(ConnectionManager connection)
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

    }
}
