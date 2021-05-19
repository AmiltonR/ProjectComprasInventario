using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectComprasInventario.Models;

namespace ProjectComprasInventario.Controllers
{
    class GuardarPDFRecibido
    {
        public bool Guardar(String nombre, byte[] file, int cot)
        {
            bool b;
            try
            {
                using (Entity db = new Entity())
                {
                    db.SP_GuardarCotizacionRecibida(nombre, file, cot);
                    b = true;
                }
            }
            catch (Exception)
            {
                b = false;
                throw;
            }
            return b;
        }
    }
}
