using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectComprasInventario.Models;

namespace ProjectComprasInventario.Controllers
{
    class SelecProvCotizacionController
    {
        public bool seleccionarProveedores(DataGridView dgv, ComboBox cmb)
        {
            bool b = true;
            try
            {
                using (Entity db = new Entity())
                {
                    var list = db.SP_SeleccionarProveedoresCotizaciones(Session.cotizacionDetalle).ToList();
                    dgv.DataSource = list;
                    cmb.DataSource = list;
                    cmb.DisplayMember = "PROVEEDOR";
                    cmb.ValueMember = "ID_PROVEEDOR";
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
