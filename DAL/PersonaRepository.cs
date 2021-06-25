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
    public class PersonaRepository
    {

        private SqlConnection _connection;

        public PersonaRepository(ConnectionManager connection)
        {
            _connection = connection._connection;
        }

        public void Guardar (Persona persona)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Personas (Identificacion, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, NumeroContacto, Rol)" +
                    "Values (@Identificacion, @PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @NumeroContacto,@Rol)";
                command.Parameters.Add("@Identificacion", SqlDbType.VarChar).Value = persona.Identificacion;
                command.Parameters.Add("@PrimerNombre", SqlDbType.VarChar).Value = persona.PrimerNombre;
                command.Parameters.Add("@SegundoNombre", SqlDbType.VarChar).Value = persona.SegundoNombre;
                command.Parameters.Add("@PrimerApellido", SqlDbType.VarChar).Value = persona.PrimerApellido;
                command.Parameters.Add("@SegundoApellido", SqlDbType.VarChar).Value = persona.SegundoApellido;
                command.Parameters.Add("@NumeroContacto", SqlDbType.VarChar).Value = persona.NumeroContacto;
                command.Parameters.Add("@Rol", SqlDbType.VarChar).Value = persona.Rol;
                command.ExecuteNonQuery();
            }
        }

    }
}
