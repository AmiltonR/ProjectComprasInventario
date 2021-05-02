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
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
