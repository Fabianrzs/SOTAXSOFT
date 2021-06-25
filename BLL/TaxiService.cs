using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class TaxiService
    {
        private readonly ConnectionManager connection;
        private readonly TaxiRepository repository;

        public TaxiService(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            repository = new TaxiRepository(connection);

        }

        public string Guardar (Taxi taxi)
        {
            try
            {   
                repository.GuardarTaxi(taxi);
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
