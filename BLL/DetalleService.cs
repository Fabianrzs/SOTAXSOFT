using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class DetalleService
    {
        private readonly ConnectionManager connection;
        private readonly DetalleRepository repository;
        private readonly TaxiRepository _repository;

        public DetalleService(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            repository = new DetalleRepository(connection);
            _repository = new TaxiRepository(connection);

        }

        public string GuardarDetalle(Detalle detalle, string placaTaxi)
        {
            try
            {
                connection.Open();
                detalle.Taxi = _repository.BuscarPorPlaca(placaTaxi);

                if (detalle.Taxi != null)
                {
                    if(repository.BuscarPorCodigoDetalle(detalle.CodigoDetalle) == null)
                    {
                        repository.GuardarDetalle(detalle);
                        return $"Registro guardado satisfactoriamente";
                    }
                    else { detalle.GenerarCodigoDetalle(); }

                }
                return $"El Taxi no se encuentra registrado";
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

        public string ModificarDetalle(Detalle detalle, double codigoDetalle, string placaTaxi)
        {
            try
            {
                connection.Open();

                detalle.Taxi = _repository.BuscarPorPlaca(placaTaxi);

                if (detalle.Taxi != null)
                {
                    if (repository.BuscarPorCodigoDetalle(codigoDetalle) != null)
                    {
                        repository.GuardarDetalle(detalle);
                        return $"Registro modificado satisfactoriamente";
                    }
                    return $"El codigo del detalle no puede ser cambiado";

                }
                return $"El Detalle no se encuentra registrado";

            }
            catch (Exception e) { return $"Se preseto la siguiente Excepción: {e.Message}"; }
            finally
            {
                connection.Close();
            }


        }

        public string EliminarDetalle(double codigoDetalle)
        {
            try
            {
                connection.Open();
                if (repository.BuscarPorCodigoDetalle(codigoDetalle) != null)
                {
                    repository.Eliminar(codigoDetalle);
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

        public ConsultaResponseDetalle ConsultarDetalles()
        {
            try
            {
                connection.Open();
                return new ConsultaResponseDetalle(repository.ConsultarDetalles());
            }
            catch (Exception e) { return new ConsultaResponseDetalle($"Se preseto la siguiente Excepción: {e.Message}"); }
            finally
            {
                connection.Close();
            }

        }

        public RegistroResponseDetalle RegistroDetalle(double codigoDetalle)
        {
            try
            {
                connection.Open();
                return new RegistroResponseDetalle(repository.BuscarPorCodigoDetalle(codigoDetalle));
            }
            catch (Exception e) { return new RegistroResponseDetalle($"Se preseto la siguiente Excepción: {e.Message}"); }
            finally
            {
                connection.Close();
            }
        }

        public class ConsultaResponseDetalle
        {
            public List<Detalle> Detalles { get; set; }
            public string Mensaje { get; set; }
            public bool Error { get; set; }

            public ConsultaResponseDetalle(List<Detalle> detalles)
            {
                Detalles = detalles;
                Error = false;
            }

            public ConsultaResponseDetalle(string mensaje)
            {
                Mensaje = mensaje;
                Error = true;
            }
        }

        public class RegistroResponseDetalle
        {
            public Detalle Detalle { get; set; }
            public string Mensaje { get; set; }
            public bool Error { get; set; }

            public RegistroResponseDetalle(Detalle detalle)
            {
                Detalle = detalle;
                Error = false;
            }

            public RegistroResponseDetalle(string mensaje)
            {
                Mensaje = mensaje;
                Error = true;
            }
        }
    }

}

