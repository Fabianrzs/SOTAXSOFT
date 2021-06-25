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
                repository.Guardar (persona);
                return $"Registro guardado satisfactoriamente";
            }
            catch (Exception e) 
            { 
                return $"Se preseto la siguiente Excepción: {e.Message}"; 
            }
            finally
            { 
                connection.Close();
            }
        }
    }
}
