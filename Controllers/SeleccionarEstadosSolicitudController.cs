using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectComprasInventario.Models;

namespace ProjectComprasInventario.Controllers
{
    class SeleccionarEstadosSolicitudController
    {
        public bool estadosSolicitud(ComboBox cmb)
        {
            bool isSuccessful;
            try
            {
                using (Entity db = new Entity())
                {
                    var lst = db.SP_TipoSolicitudes().ToList();
                    cmb.DataSource = lst;
                    cmb.DisplayMember = "Estado";
                    cmb.ValueMember = "ID";
                    isSuccessful = true;
                }
            }
            catch (Exception)
            {
                isSuccessful = false;
                throw;
            }
            return isSuccessful;
        }
    }
}
