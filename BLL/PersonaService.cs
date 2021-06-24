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

        //public string RegistrarPersona(Persona persona)
        //{
        //    try
        //    {
        //        connection.Open();
        //        if (repository.IdentificacionExistente(persona.Identificacion) == null)
        //        {
        //            repository.GuardarPersona(persona); 
        //            return $"SE REGISTRO SACTISFACTORIAMENTE {persona.PrimerNombre}";
        //        }
        //        return $"NO SE PUDO REALIZAR EL REGISTRO, ESTA PERSONA YA SE ENCUENTRA REGISTRADA";
        //    }
        //    catch (Exception e){ return $"ERROR DE LA APLICACION: {e.Message}"; }
        //    finally
        //    { connection.Close(); }
        //}
    }
}
