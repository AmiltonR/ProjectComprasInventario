using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectComprasInventario.Models;

namespace ProjectComprasInventario.Controllers
{
    class SeleccionarCotizacionController
    {
        public List<SP_SeleccionarCotizacion_Result> seleccionarCotizacion()
        {
            List<SP_SeleccionarCotizacion_Result> lista;
            bool b = true;
            try
            {
                using (Entity db = new Entity())
                {
                    lista = db.SP_SeleccionarCotizacion(Session.cotizacionDetalle).ToList();
                }
            }
            catch (Exception)
            {
                b = false;
                throw;
            }
            return lista;
        }
    }
}
