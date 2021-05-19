using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectComprasInventario.Models;

namespace ProjectComprasInventario.Controllers
{
    class GuardarCotizacionXProveedor
    {
        public bool guardarCotizacionxProveedor( int proveedor)
        {
            bool isSuccesful = false;
            using (Entity db = new Entity())
            {
                try
                {
                    db.SP_CotizacionXProveedor(Session.idCotizacion, proveedor);
                    isSuccesful = true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return isSuccesful;
        }
    }
}
