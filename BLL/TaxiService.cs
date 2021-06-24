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

        //public string RegistrarTaxi(Taxi taxi)
        //{
        //    try
        //    {
        //        if (repository.PlacaExistente(taxi.Placa) == null)
        //        {
        //            repository.GuardarTaxi(taxi);

        //            return $"SE REGISTRO SACTISFACTORIAMENTE";
        //        }
        //        return $"NO SE PUDO REALIZAR EL REGISTRO, ESTA PLACA YA SE ENCUENTRA REGISTRADA";
        //    }
        //    catch (Exception e) { return $"ERROR DE LA APLICACION: {e.Message}"; }
        //    finally
        //    { connection.Close(); }

        //}
    }
}
