using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PersonaService
    {
        private readonly ConnectionManager connection;
        private readonly PersonaRepository repository;

        public PersonaService(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            repository = new PersonaRepository(connection);

        }

        public string GuardarPersona (Persona persona)
        {
            try
            {
                connection.Open();
                if(repository.BuscarPorIdentificacion(persona.Identificacion) == null){
                    
                    repository.Guardar (persona);
                    return $"Registro guardado satisfactoriamente"; 
                }
                return $"Usuario Ya Registrado Con esa Identificacion";
            }
            catch (Exception e) { return $"Se preseto la siguiente Excepción: {e.Message}"; }
            finally
            { 
                connection.Close();
            }
        }

        public string ModificarPersona(Persona persona, string identificacion)
        {
            try
            {
                connection.Open();

                if (repository.BuscarPorIdentificacion(identificacion) != null)
                {
                    repository.Modificar(persona);
                    return $"Registro modificado satisfactoriamente";
                }
                return $"La identificacion no puede ser cambiada";
            }
            catch (Exception e) { return $"Se preseto la siguiente Excepción: {e.Message}"; }
            finally
            {
                connection.Close();
            }


        }

        public string EliminarPersona(string identicacion)
        {
            try
            {
                connection.Open();

                if (repository.BuscarPorIdentificacion(identicacion) != null)
                {
                    repository.Eliminar(identicacion);
                    return $"Registro eliminado satisfactoriamente";
                }
                return $"Registro no encontrado";
            }
            catch (Exception e) { return $"Se preseto la siguiente Excepción: {e.Message}"; }
            finally
            {
                connection.Close();
            }
        }

        public ConsultaResponsePersona ConsultarPersonas(string tipo)
        {
            try
            {
                connection.Open();
                return new ConsultaResponsePersona(repository.ConsultarRol(tipo));
            }
            catch (Exception e) { return new ConsultaResponsePersona($"Se preseto la siguiente Excepción: {e.Message}"); }
            finally
            {
                connection.Close();
            }

        }

        public RegistroResponsePersona RegistroPersona(string identificacion)
        {
            try
            {
                connection.Open();
                return new RegistroResponsePersona(repository.BuscarPorIdentificacion(identificacion));
            }
            catch (Exception e) { return new RegistroResponsePersona($"Se preseto la siguiente Excepción: {e.Message}"); }
            finally
            {
                connection.Close();
            }
        }

        public class ConsultaResponsePersona
        {
            public List<Persona> Personas { get; set; }
            public string Mensaje { get; set; }
            public bool Error { get; set; }

            public ConsultaResponsePersona(List<Persona> personas)
            {
                Personas = personas;
                Error = false;   
            }

            public ConsultaResponsePersona(string mensaje)
            {
                Mensaje = mensaje;
                Error = true;
            }
        }

        public class RegistroResponsePersona
        {
            public Persona Persona { get; set; }
            public string Mensaje { get; set; }
            public bool Error { get; set; }

            public RegistroResponsePersona(Persona persona)
            {
                Persona = persona;
                Error = false;
            }

            public RegistroResponsePersona(string mensaje)
            {
                Mensaje = mensaje;
                Error = true;
            }
        }


    }
}
