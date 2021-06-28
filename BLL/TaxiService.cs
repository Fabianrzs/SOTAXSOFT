using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaxiService
    {
        private readonly ConnectionManager connection;
        private readonly TaxiRepository repository;
        private readonly PersonaRepository _repository; 
        
        public TaxiService(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            repository = new TaxiRepository(connection);
            _repository = new PersonaRepository(connection);
        }

        public string Guardar (Taxi taxi, string idPropietario, string idConducto)
        {
            try
            {
                connection.Open();
                Propietario propietario = (Propietario)_repository.BuscarPorIdentificacion(idPropietario);
                Conductor conductor = (Conductor)_repository.BuscarPorIdentificacion(idConducto);
                if (propietario != null)
                {
                    if (conductor != null)
                    {
                        if (repository.BuscarPorPlaca(taxi.Placa) == null)
                        {
                            taxi.Conductor = conductor;
                            taxi.Propietario = propietario;
                            repository.GuardarTaxi(taxi);
                            return $"Registro guardado satisfactoriamente";
                        }
                    }
                    return $"El conductor no se encuentra registrado";
                }
                return $"El propietario no se encuentra registrado";
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

        public string Modificar(Taxi taxi, string idPropietario, string idConducto)
        {
            try
            {
                connection.Open();
                Propietario propietario = (Propietario)_repository.BuscarPorIdentificacion(idPropietario);
                Conductor conductor = (Conductor)_repository.BuscarPorIdentificacion(idConducto);
                if (propietario != null)
                {
                    if (conductor != null)
                    {
                        if (repository.BuscarPorPlaca(taxi.Placa) == null)
                        {
                            taxi.Conductor = conductor;
                            taxi.Propietario = propietario;
                            repository.GuardarTaxi(taxi);
                            return $"Registro modificado satisfactoriamente";
                        }
                        return $"La placa no puede ser cambiada";
                    }
                    return $"El conductor no se encuentra registrado";
                }
                return $"El propietario no se encuentra registrado";
                
            }
            catch (Exception e) { return $"Se preseto la siguiente Excepción: {e.Message}"; }
            finally
            {
                connection.Close();
            }


        }

        public string Eliminar(string placa)
        {
            try
            {
                connection.Open();
                if (repository.BuscarPorPlaca(placa) != null)
                {
                    repository.Eliminar(placa);
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

        public ConsultaResponse Consultar()
        {
            try
            {
                connection.Open();
                return new ConsultaResponse(repository.ConsultarTaxis());
            }
            catch (Exception e) { return new ConsultaResponse($"Se preseto la siguiente Excepción: {e.Message}"); }
            finally
            {
                connection.Close();
            }

        }

        public RegistroResponse Registro(string placa)
        {
            try
            {
                connection.Open();
                return new RegistroResponse(repository.BuscarPorPlaca(placa));
            }
            catch (Exception e) { return new RegistroResponse($"Se preseto la siguiente Excepción: {e.Message}"); }
            finally
            {
                connection.Close();
            }
        }

        public class ConsultaResponse
        {
            public List<Taxi> Taxis { get; set; }
            public string Mensaje { get; set; }
            public bool Error { get; set; }

            public ConsultaResponse(List<Taxi> taxis)
            {
                Taxis = taxis;
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
            public Taxi Taxi { get; set; }
            public string Mensaje { get; set; }
            public bool Error { get; set; }

            public RegistroResponse(Taxi taxi)
            {
                Taxi = taxi;
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
