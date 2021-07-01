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

        public string GuardarTaxi (Taxi taxi, string idPropietario, string idConducto)
        {
            try
            {
                connection.Open();

                taxi.Conductor = (Conductor)_repository.BuscarPorIdentificacion(idConducto);
                taxi.Propietario = (Propietario)_repository.BuscarPorIdentificacion(idPropietario);

                if (taxi.Propietario != null)
                {
                    if (taxi.Conductor != null)
                    {
                        if (repository.BuscarPorPlaca(taxi.Placa) == null)
                        {
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

        public string ModificarTaxi(Taxi taxi, string idPropietario, string idConducto, string placa)
        {
            try
            {
                connection.Open();

                taxi.Conductor = (Conductor)_repository.BuscarPorIdentificacion(idConducto);
                taxi.Propietario = (Propietario)_repository.BuscarPorIdentificacion(idPropietario);

                if (taxi.Propietario != null)
                {
                    if (taxi.Conductor != null)
                    {
                        if (repository.BuscarPorPlaca(placa) != null)
                        {                 
                            repository.Modificar(taxi);
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

        public string EliminarTaxi(string placa)
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

        public ConsultaResponseTaxi ConsultarTaxis()
        {
            try
            {
                connection.Open();
                return new ConsultaResponseTaxi(repository.ConsultarTaxis());
            }
            catch (Exception e) { return new ConsultaResponseTaxi($"Se preseto la siguiente Excepción: {e.Message}"); }
            finally
            {
                connection.Close();
            }

        }

        public RegistroResponseTaxi RegistroTaxi(string placa)
        {
            try
            {
                connection.Open();
                return new RegistroResponseTaxi(repository.BuscarPorPlaca(placa));
            }
            catch (Exception e) { return new RegistroResponseTaxi($"Se preseto la siguiente Excepción: {e.Message}"); }
            finally
            {
                connection.Close();
            }
        }

        public class ConsultaResponseTaxi
        {
            public List<Taxi> Taxis { get; set; }
            public string Mensaje { get; set; }
            public bool Error { get; set; }

            public ConsultaResponseTaxi(List<Taxi> taxis)
            {
                Taxis = taxis;
                Error = false;
            }

            public ConsultaResponseTaxi(string mensaje)
            {
                Mensaje = mensaje;
                Error = true;
            }
        }

        public class RegistroResponseTaxi
        {
            public Taxi Taxi { get; set; }
            public string Mensaje { get; set; }
            public bool Error { get; set; }

            public RegistroResponseTaxi(Taxi taxi)
            {
                Taxi = taxi;
                Error = false;
            }

            public RegistroResponseTaxi(string mensaje)
            {
                Mensaje = mensaje;
                Error = true;
            }
        }
    }
}
