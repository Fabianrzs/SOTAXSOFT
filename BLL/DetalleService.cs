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

        public string Guardar (Detalle detalle)
        {
            try
            {
                connection.Open();
                repository.Guardar (detalle);
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
