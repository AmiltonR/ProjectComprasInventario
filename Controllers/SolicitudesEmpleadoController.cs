using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectComprasInventario.Models;

namespace ProjectComprasInventario.Controllers
{
    class SolicitudesEmpleadoController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        public void misSolicitudes(int userId, DataGridView dgv)
        {
            using (Entity db = new Entity())
            {
                try
                {
                    var solicitudes = db.SP_SolicitudesUsuario(userId).ToList();
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
