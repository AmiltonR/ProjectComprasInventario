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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
            submenus();
            lblUserInfo.Text = Session.usuario;
            btnSolicitud.Focus();
        }

        private void btnCloseinMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form activeForm = null;
        private void showChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
       
        }

        private void btnSolicitud_Click(object sender, EventArgs e)
        {
            mostrarPaneles(panelMisSolicitudes);
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showChildForm(new frmAprobarSolicitudes());
        }

        private void submenus()
        {
            panelCotizaciones.Visible = false;
            panelMisSolicitudes.Visible = false;
            panelUsuarios.Visible = false;
        }

        private void ocultarPanels()
        {
            if (panelCotizaciones.Visible == true)
            {
                panelCotizaciones.Visible = false;
            }
            if (panelMisSolicitudes.Visible == true)
            {
                panelMisSolicitudes.Visible = false;
            }
            if (panelUsuarios.Visible == true)
            {
                panelUsuarios.Visible = false;
            }
        }

        private void mostrarPaneles(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarPanels();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            showChildForm(new frmCrearSolicitud());
            ocultarPanels();
        }

        private void btnMisSolicitudes_Click(object sender, EventArgs e)
        {
            showChildForm(new frmGestionarSolicitudes());
            ocultarPanels();
        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            mostrarPaneles(panelCotizaciones);
        }

        private void btnSolicitudesAprobadas_Click(object sender, EventArgs e)
        {
            ocultarPanels();
        }

        private void btnRealizarCotizacion_Click(object sender, EventArgs e)
        {
            showChildForm(new frmCrearCotizacion());
            ocultarPanels();
        }

        private void btnGestionarCotizaciones_Click(object sender, EventArgs e)
        {
            ocultarPanels();
        }

        private void btnSolicitudesRecibidas_Click(object sender, EventArgs e)
        {
            showChildForm(new frmAprobarSolicitudes());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            mostrarPaneles(panelUsuarios);
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            ocultarPanels();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ocultarPanels();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
