using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectComprasInventario.Models;

namespace ProjectComprasInventario.Controllers
{
    class CambiarEstadoSolicitudController
    {
        public bool cambiarEstadoSolicitud(int id, int estado)
        {
            bool isSuccessful; 
            try
            {
                using (Entity db = new Entity())
                {
                    db.SP_CambiarEstadoSolicitud(id,estado);
                    isSuccessful = true;
                }
            }
            catch (Exception)
            {
                isSuccessful = false;
                throw;
            }
            return isSuccessful;
        }
    }
}
