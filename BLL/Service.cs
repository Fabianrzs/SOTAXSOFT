using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Service
    {
        private readonly ConnectionManager connection;
        private readonly Repository repository;

        public Service(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            repository = new Repository(connection);

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

        public string RegistrarTaxi(Taxi taxi)
        {
            try
            {
                connection.Open();
                if (repository.IdentificacionExistente(taxi.Propietario.Identificacion) != null)
                {
                    if (repository.PlacaExistente(taxi.Placa) == null)
                    {
                        repository.GuardarTaxi(taxi);

                        return $"SE REGISTRO SACTISFACTORIAMENTE";
                    }
                    return $"NO SE PUDO REALIZAR EL REGISTRO, ESTA PLACA YA SE ENCUENTRA REGISTRADA";
                }
                return $"NO SE PUDO REALIZAR EL REGISTRO, ESTA PERSONA NO SE ENCUENTRA REGISTRADA";
            }
            catch (Exception e) { return $"ERROR DE LA APLICACION: {e.Message}"; }
            finally
            { connection.Close(); }

        }

        public string RegistrarDetalle(Detalle detalle)
        {
            try
            {
                connection.Open();
                
                    if (repository.PlacaExistente(detalle.Placa) == null)
                    {
                        detalle.GenerarCodigoDetalle();

                        repository.GuardarDetalle(detalle);

                        return $"SE REGISTRO SACTISFACTORIAMENTE";
                    }
                    return $"NO SE PUDO REALIZAR EL REGISTRO, NO SE ENCUENTRA REGISTRADA LA PLACA ASIGNADA";
                
            }
            catch (Exception e) { return $"ERROR DE LA APLICACION: {e.Message}"; }
            finally
            { connection.Close(); }

        }


    }
}
