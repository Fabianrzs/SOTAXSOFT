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
                command.CommandText = "INSERT INTO Personas (Identificacion, PrimerNombre," +
                    " SegundoNombre, PrimerApellido, SegundoApellido, NumeroContacto, Rol)" +
                    "Values (@Identificacion, @PrimerNombre, @SegundoNombre, @PrimerApellido," +
                    " @SegundoApellido, @NumeroContacto, @Rol)";
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

        public Persona BuscarPorIdentificacion(string identificacion)
        {
            using (var command = _connection.CreateCommand())
            {
                command.Parameters.Add("@Identificacion", SqlDbType.VarChar).Value = identificacion;
                command.CommandText = "select Identificacion, PrimerNombre, SegundoNombre, PrimerApellido, " +
                    "SegundoApellido, NumeroContacto, Rol from personas where Identificacion=@Identificacion";

                var dataReader = command.ExecuteReader();
                dataReader.Read();

                return DataReaderMapToPerson(dataReader);
            } 
        }

        public Conductor BuscarConductor(string identificacion)
        {

            using (var command = _connection.CreateCommand())
            {
                command.Parameters.Add("@Identificacion", SqlDbType.VarChar).Value = identificacion;
                command.CommandText = "select Identificacion, PrimerNombre, SegundoNombre, PrimerApellido, " +
                    "SegundoApellido, NumeroContacto, Rol from personas where Identificacion=@Identificacion";

                var dataReader = command.ExecuteReader();
                dataReader.Read();

                return (Conductor)DataReaderMapToPerson(dataReader);
            }
        }

        public Propietario BuscarPropietario(string identificacion)
        {

            using (var command = _connection.CreateCommand())
            {
                command.Parameters.Add("@Identificacion", SqlDbType.VarChar).Value = identificacion;
                command.CommandText = "select Identificacion, PrimerNombre, SegundoNombre, PrimerApellido, " +
                    "SegundoApellido, NumeroContacto, Rol from personas where Identificacion=@Identificacion";

                var dataReader = command.ExecuteReader();
                dataReader.Read();

                return (Propietario)DataReaderMapToPerson(dataReader);
            }
        }

        //public Persona BuscarPersona(string identificacion, string rol)
        //{

        //    using (var command = _connection.CreateCommand())
        //    {
        //        command.Parameters.Add("@Identificacion", SqlDbType.VarChar).Value = identificacion;
        //        command.Parameters.Add("@Rol", SqlDbType.VarChar).Value = rol;
        //        command.CommandText = "select Identificacion, PrimerNombre, SegundoNombre, PrimerApellido, " +
        //            "SegundoApellido, NumeroContacto, Rol from personas" +
        //            " where Identificacion=@Identificacion and Rol = @Rol";

        //        var dataReader = command.ExecuteReader();
        //        dataReader.Read();

        //        return DataReaderMapToPerson(dataReader);
        //    }
        //}

        public List<Persona> ConsultarRol(string rol)
        {
            List<Persona> personas = new List<Persona>();

            using (var command = _connection.CreateCommand())
            {

                command.Parameters.Add("@Rol", SqlDbType.VarChar).Value = rol;
                command.CommandText = "select Identificacion, PrimerNombre, SegundoNombre, PrimerApellido, " +
                    "SegundoApellido, NumeroContacto, Rol from personas where Rol = @Rol;";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Persona persona = DataReaderMapToPerson(dataReader);
                        personas.Add(persona);
                    }
                }
            }
            return personas;
        }

        public int Modificar(Persona persona)
        {
            using (var command = _connection.CreateCommand())
            {

                command.Parameters.Add("@PrimerNombre", SqlDbType.VarChar).Value = persona.PrimerNombre;
                command.Parameters.Add("@SegundoNombre", SqlDbType.VarChar).Value = persona.SegundoNombre;
                command.Parameters.Add("@PrimerApellido", SqlDbType.VarChar).Value = persona.PrimerApellido;
                command.Parameters.Add("@SegundoApellido", SqlDbType.VarChar).Value = persona.SegundoApellido;
                command.Parameters.Add("@NumeroContacto", SqlDbType.VarChar).Value = persona.NumeroContacto;
                command.Parameters.Add("@Identificacion", SqlDbType.VarChar).Value = persona.Identificacion;

                command.CommandText = "Update Personas set PrimerNombre = @PrimerNombre," +
                   " SegundoNombre = @SegundoNombre, PrimerApellido =  @PrimerApellido, " +
                   "SegundoApellido = @SegundoApellido, NumeroContacto = @NumeroContacto where Identificacion = @Identificacion";
                return command.ExecuteNonQuery();
            }
        }

        public int Eliminar(string identificacion)
        {
            using (var command = _connection.CreateCommand())
            {
                command.Parameters.Add("@Identificacion", SqlDbType.VarChar).Value = identificacion;
                command.CommandText = "Delete Personas where Identificacion = @Identificacion";
                return command.ExecuteNonQuery();

            }
        }

        private Persona DataReaderMapToPerson(SqlDataReader dataReader)
        {

            if (!dataReader.HasRows) return null;

            if (dataReader.GetString(6).Equals("propietario"))
            {
                Propietario propietario = new Propietario();
                propietario.Identificacion = dataReader.GetString(0);
                propietario.PrimerNombre = dataReader.GetString(1);
                propietario.SegundoNombre = dataReader.GetString(2);
                propietario.PrimerApellido = dataReader.GetString(3);
                propietario.SegundoApellido = dataReader.GetString(4);
                propietario.NumeroContacto = dataReader.GetString(5);
                return (Propietario)propietario;
            }
            else
            {
                Conductor conductor = new Conductor();
                conductor.Identificacion = dataReader.GetString(0);
                conductor.PrimerNombre = dataReader.GetString(1);
                conductor.SegundoNombre = dataReader.GetString(2);
                conductor.PrimerApellido = dataReader.GetString(3);
                conductor.SegundoApellido = dataReader.GetString(4);
                conductor.NumeroContacto = dataReader.GetString(5);
                return (Conductor)conductor;
            }

        }
    }
}
