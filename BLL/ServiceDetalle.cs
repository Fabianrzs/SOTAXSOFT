using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class ServiceDetalle
    {
        private readonly ConnectionManager connection;
        private readonly RepositoryDetalle repository;

        public ServiceDetalle(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            repository = new RepositoryDetalle(connection);

        }

        public string RegistrarDetalle(Detalle detalle)
        {
            try
            {
                connection.Open();

                do{
                    detalle.GenerarCodigoDetalle();
                }while (repository.ExistenCodigoDetalle(detalle.CodigoDetalle) != null) ;

                repository.GuardarDetalle(detalle);

                return $"SE REGISTRO SACTISFACTORIAMENTE";

            }
            catch (Exception e) { return $"ERROR DE LA APLICACION: {e.Message}"; }
            finally
            { connection.Close(); }

        }

    }
}
