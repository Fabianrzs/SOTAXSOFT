using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicePersona
    {
        private readonly ConnectionManager connection;
        private readonly RepositoryPersona repository;

        public ServicePersona(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            repository = new RepositoryPersona(connection);

        }

        public string RegistrarPersona(Persona persona)
        {
            try
            {
                connection.Open();
                if (repository.IdentificacionExistente(persona.Identificacion) == null)
                {
                    repository.GuardarPersona(persona); 
                    return $"SE REGISTRO SACTISFACTORIAMENTE {persona.PrimerNombre}";
                }
                return $"NO SE PUDO REALIZAR EL REGISTRO, ESTA PERSONA YA SE ENCUENTRA REGISTRADA";
            }
            catch (Exception e){ return $"ERROR DE LA APLICACION: {e.Message}"; }
            finally
            { connection.Close(); }
        }
    }
}
