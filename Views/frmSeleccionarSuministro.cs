using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectComprasInventario.Controllers;

namespace ProjectComprasInventario.Views
{
    public partial class frmSeleccionarSuministro : Form
    {
        public frmSeleccionarSuministro()
        {
            InitializeComponent();
        }

        private void frmSeleccionarSuministro_Load(object sender, EventArgs e)
        {
            SeleccionarSuministroController seleccionarSum = new SeleccionarSuministroController();
            seleccionarSum.seleccionarSuministro(dgvSuministros);
        }
    }
}
