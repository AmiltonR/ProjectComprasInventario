using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectComprasInventario.Models;

namespace ProjectComprasInventario.Controllers
{
    class SeleccionarProveedoresController
    {
        public void seleccionarProveedor(DataGridView dgv)
        {
            using (Entity db = new Entity())
            {
                try
                {
                    var proveedoresList = db.SP_SeleccionarProveedores().ToList();
                    dgv.DataSource = proveedoresList;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
