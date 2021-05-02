using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectComprasInventario.Models;

namespace ProjectComprasInventario.Controllers
{
    class EliminarSolicitudController
    {

        public bool eliminarSolicitud(int idSolicitud)
        {
            bool isSuccessful;
            using (Entity db = new Entity())
            {
                try
                {
                    db.SP_EliminarSolicitud(idSolicitud);
                    isSuccessful = true;
                }
                catch (Exception)
                {
                    isSuccessful = false;
                    throw;
                }
            }
            return isSuccessful;
        }
    }
}
