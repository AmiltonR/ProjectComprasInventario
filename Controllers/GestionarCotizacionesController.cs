using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectComprasInventario.Models;

namespace ProjectComprasInventario.Controllers
{
    class GestionarCotizacionesController
    {
        public bool  GestionarCotizaciones(DataGridView dgv)
        {
            bool b = true;
            try
            {
                using (Entity db = new Entity())
                {
                    var list = db.SP_SeleccionarCotizaciones().ToList();
                    dgv.DataSource = list;  
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
