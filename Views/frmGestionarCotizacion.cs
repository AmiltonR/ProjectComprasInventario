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
    public partial class frmGestionarCotizacion : Form
    {
        GestionarCotizacionesController cotizaciones = new GestionarCotizacionesController();
        int id = 0;
       
        public frmGestionarCotizacion()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmGestionarCotizacion_Load(object sender, EventArgs e)
        {
            cotizaciones.GestionarCotizaciones(dgvCotizaciones);
        }

        private void dgvCotizaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCotizaciones_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(dgvCotizaciones.Rows[dgvCotizaciones.CurrentRow.Index].Cells[0].Value.ToString());
            //suministro = dgvCotizaciones.Rows[dgvCotizaciones.CurrentRow.Index].Cells[1].Value.ToString();
            lblID.Text = id.ToString();
        }

        private void linkLblEnviado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirPDF abrir = new AbrirPDF();
            if (id!=0)
            {
                abrir.abrir(id);
            }
            else
            {
                frmNotificaciones not = new frmNotificaciones();
                not.msg = "Seleccione una Cotización haciendo doble click";
                not.Show();
            }
        }

        private void linklblDetalle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (id!=0)
            {
               Session.cotizacionDetalle = id;
                MostrarFormularioController mostrar = new MostrarFormularioController();
                mostrar.showOnMain(this,new frmDetalleCotizacion());
            }
        }
    }
}
