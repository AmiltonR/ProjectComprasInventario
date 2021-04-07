using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectComprasInventario.Models;

namespace ProjectComprasInventario.Controllers
{
    class SeleccionarSuministroController
    {
       public void seleccionarSuministro(DataGridView dgv)
        {
            using (Entity db = new Entity())
            {
                var userList = db.SP_SeleccionarSuministros().ToList();
                dgv.DataSource = userList;
            }
        }
    }
}
