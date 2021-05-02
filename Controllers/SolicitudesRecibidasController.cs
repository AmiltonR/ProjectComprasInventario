using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectComprasInventario.Models;

namespace ProjectComprasInventario.Controllers
{
    class SolicitudesRecibidasController
    {
        public bool seleccionarSolicitudesRecibidas(int dep, int tipo, DataGridView dgv)
        {
            bool isSuccessful;
            using (Entity db = new Entity())
            {
                try
                {
                    var solicitudes = db.SP_AprobarSolicitudes(dep,tipo);
                    dgv.DataSource = solicitudes;
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
