using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectComprasInventario.Models;

namespace ProjectComprasInventario.Controllers
{
    class SolicitudesGlobalesController
    {
        public void solicitudesGlobales(DataGridView dgv)
        {
            using (Entity db = new Entity())
            {
                try
                {
                    var solicitudes = db.SP_SolicitudesGlobales().ToList();
                    dgv.DataSource = solicitudes;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

    }
}
