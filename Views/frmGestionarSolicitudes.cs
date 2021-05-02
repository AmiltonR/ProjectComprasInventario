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
    public partial class frmGestionarSolicitudes : Form
    {
        public frmGestionarSolicitudes()
        {
            InitializeComponent();
        }

        private void frmGestionarSolicitudes_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void dgvSolicitudes_DoubleClick(object sender, EventArgs e)
        {
            txtIdSolicitud.Text = dgvSolicitudes.Rows[dgvSolicitudes.CurrentRow.Index].Cells[0].Value.ToString();
            txtSuministro.Text = dgvSolicitudes.Rows[dgvSolicitudes.CurrentRow.Index].Cells[1].Value.ToString();
            txtCantidad.Text = dgvSolicitudes.Rows[dgvSolicitudes.CurrentRow.Index].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idSolicitud = int.Parse(txtIdSolicitud.Text);

            EliminarSolicitudController eliminar = new EliminarSolicitudController();
            eliminar.eliminarSolicitud(idSolicitud);

            fillGrid();

            //Limpiar los controles
            txtCantidad.Text = String.Empty;
            txtSuministro.Text = String.Empty;
            txtIdSolicitud.Text = String.Empty;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void fillGrid()
        {
            SolicitudesEmpleadoController solicitudesEmp = new SolicitudesEmpleadoController();
            solicitudesEmp.misSolicitudes(Session.id, dgvSolicitudes);
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            MostrarFormularioController mostrar = new MostrarFormularioController();
            mostrar.showOnMain(this,new frmCrearSolicitud());
        }
    }
}
