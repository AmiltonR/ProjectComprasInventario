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
    public partial class frmCrearSolicitud : Form
    {
        private int idSuministro;

        public int IdSuministro { get => idSuministro; set => idSuministro = value; }

        public frmCrearSolicitud()
        {
            InitializeComponent();
        }

        private void btnSeleccionarSuministro_Click(object sender, EventArgs e)
        {
            frmSeleccionarSuministro suministro = new frmSeleccionarSuministro();
            AddOwnedForm(suministro);
            suministro.Show();
        }

        private void frmCrearSolicitud_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGuardarSolicitud_Click(object sender, EventArgs e)
        {
            bool transactionState;
            frmNotificaciones notificacionWindow = new frmNotificaciones();

            if (txtSuministro.Text == String.Empty || numupdownCantidad.Value.Equals(0))
            {
                notificacionWindow.msg = "Llena ambos campos";
                notificacionWindow.Show();
            }
            else
            {
                int userID = Session.id;
                int id_suministro = IdSuministro;
                int cantidad = int.Parse(numupdownCantidad.Value.ToString());

                guardarSolicitudController guardar = new guardarSolicitudController();
                transactionState = guardar.guardarSolicitud(userID, id_suministro, cantidad);

                if (transactionState)
                {
                    notificacionWindow.msg = "Solicitud creada con éxito";
                    notificacionWindow.Show();

                    txtSuministro.Text = String.Empty;
                    numupdownCantidad.Value = 0;
                }
                else
                {
                    notificacionWindow.msg = "Upps :(";
                    notificacionWindow.Show();
                }
            }
        }

        private void btnMisSolicitudes_Click(object sender, EventArgs e)
        {
            showOnMain(new frmGestionarSolicitudes());
        }
        private void showOnMain(Form frm)
        {
            Control panel = this.Parent;

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panel.Controls.Add(frm);
            panel.Tag = frm;

            frm.BringToFront();
            frm.Show();
        }
    }
}
