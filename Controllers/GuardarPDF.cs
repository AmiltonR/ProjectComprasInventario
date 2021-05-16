using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectComprasInventario.Models;

namespace ProjectComprasInventario.Controllers
{
    class GuardarPDF
    {
        public bool guardarArchivo(String name,byte[] file)
        {
            bool isSuccesful = false;
            using (Entity db = new Entity())
            {
                try
                {
                    db.SP_GuardarCotizacion(name, file);
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
