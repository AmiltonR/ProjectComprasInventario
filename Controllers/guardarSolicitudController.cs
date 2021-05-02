using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectComprasInventario.Models;

namespace ProjectComprasInventario.Controllers
{
    class guardarSolicitudController
    {
        public bool guardarSolicitud(int user, int suministro, int cantidad)
        {
            bool isSuccessful;
            using (Entity db = new Entity())
            {
                try
                {
                    db.SP_GuardarSolicitud(user, suministro, cantidad,1);
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
