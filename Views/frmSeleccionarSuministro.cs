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
        int id;
        String suministro;
        public frmSeleccionarSuministro()
        {
            InitializeComponent();
        }

        private void frmSeleccionarSuministro_Load(object sender, EventArgs e)
        {
            SeleccionarSuministroController seleccionarSum = new SeleccionarSuministroController();
            seleccionarSum.seleccionarSuministro(dgvSuministros);
        }

        private void dgvSuministros_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(dgvSuministros.Rows[dgvSuministros.CurrentRow.Index].Cells[0].Value.ToString());
            suministro = dgvSuministros.Rows[dgvSuministros.CurrentRow.Index].Cells[1].Value.ToString();

            txtSuministro.Text = suministro;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            frmCrearSolicitud frm = Owner as frmCrearSolicitud;
            frm.txtSuministro.Text = suministro;
            frm.IdSuministro = id;
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
