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

        public string Guardar (Persona persona)
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

        public string Modificar(Persona persona, string identificacion)
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

        public string Eliminar(string identicacion)
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

        public ConsultaResponse Consultar(string tipo)
        {
            try
            {
                connection.Open();
                return new ConsultaResponse(repository.ConsultarRol(tipo));
            }
            catch (Exception e) { return new ConsultaResponse($"Se preseto la siguiente Excepción: {e.Message}"); }
            finally
            {
                connection.Close();
            }

        }

        public RegistroResponse Registro(string identificacion)
        {
            try
            {
                connection.Open();
                return new RegistroResponse(repository.BuscarPorIdentificacion(identificacion));
            }
            catch (Exception e) { return new RegistroResponse($"Se preseto la siguiente Excepción: {e.Message}"); }
            finally
            {
                connection.Close();
            }
        }

        public class ConsultaResponse
        {
            public List<Persona> Personas { get; set; }
            public string Mensaje { get; set; }
            public bool Error { get; set; }

            public ConsultaResponse(List<Persona> personas)
            {
                Personas = personas;
                Error = false;   
            }

            public ConsultaResponse(string mensaje)
            {
                Mensaje = mensaje;
                Error = true;
            }
        }

        public class RegistroResponse
        {
            public Persona Persona { get; set; }
            public string Mensaje { get; set; }
            public bool Error { get; set; }

            public RegistroResponse(Persona persona)
            {
                Persona = persona;
                Error = false;
            }

            public RegistroResponse(string mensaje)
            {
                Mensaje = mensaje;
                Error = true;
            }
        }


    }
}
