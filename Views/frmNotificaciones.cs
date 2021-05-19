using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectComprasInventario.Views
{
    public partial class frmNotificaciones : Form
    {
        public String msg;
        public frmNotificaciones()
        {
            InitializeComponent();
        }

        private void frmNotificaciones_Load(object sender, EventArgs e)
        {
            lblMsg.Text = msg;
            int x = 0;

            //un poco de matematicas, restando los anchos y dividiendo entre 2
            x = (this.Width / 2) - (lblMsg.Width / 2);

            //asignamos la nueva ubicación
            lblMsg.Location = new System.Drawing.Point(x, lblMsg.Location.Y);
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
