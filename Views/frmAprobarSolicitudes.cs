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
    public partial class frmAprobarSolicitudes : Form
    {

        SolicitudesRecibidasController solicitudesRecibidas = new SolicitudesRecibidasController();
        SeleccionarEstadosSolicitudController estadosSolicitud = new SeleccionarEstadosSolicitudController();
        CambiarEstadoSolicitudController changeState = new CambiarEstadoSolicitudController();
        DataGridViewButtonColumn btnAprobar = new DataGridViewButtonColumn();
        DataGridViewButtonColumn btnDenegar = new DataGridViewButtonColumn();
        int id;

        public frmAprobarSolicitudes()
        {
            InitializeComponent();
        }

        private void frmAprobarSolicitudes_Load(object sender, EventArgs e)
        {
            lblDepartamento.Text = "Departamento de "+Session.depart;
            //PROPIEDADES DE LAS COLUMNAS DE CONTROLES
            
            btnAprobar.Name = "APROBAR";
            btnAprobar.Text = "APROBAR";
            btnAprobar.UseColumnTextForButtonValue = true;

            btnDenegar.Name = "DENEGAR";
            btnDenegar.Text = "DENEGAR";
            btnDenegar.UseColumnTextForButtonValue = true;

            actualizarGrid(1);
            llenarCombobox();
            AddColumn(1);
        }

        private void dgvSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSolicitudes.Columns.Contains("APROBAR") && dgvSolicitudes.Columns.Contains("DENEGAR"))
            {
                id = int.Parse(dgvSolicitudes.CurrentRow.Cells[2].Value.ToString());
                lblDepartamento.Text = dgvSolicitudes.CurrentRow.Cells[2].Value.ToString();
                if (this.dgvSolicitudes.Columns[e.ColumnIndex].Name == "APROBAR")
                {
                    changeState.cambiarEstadoSolicitud(id, 2);
                    actualizarGrid(1);
                }

                if (this.dgvSolicitudes.Columns[e.ColumnIndex].Name == "DENEGAR")
                {
                    changeState.cambiarEstadoSolicitud(id, 3);
                    actualizarTipoSolicitudes();
                }
            }
            else if (dgvSolicitudes.Columns.Contains("APROBAR") || dgvSolicitudes.Columns.Contains("DENEGAR"))
            {
                id = int.Parse(dgvSolicitudes.CurrentRow.Cells[0].Value.ToString());
                if (this.dgvSolicitudes.Columns[e.ColumnIndex].Name == "APROBAR")
                {
                    changeState.cambiarEstadoSolicitud(id, 2);
                    actualizarTipoSolicitudes();
                }

                if (this.dgvSolicitudes.Columns[e.ColumnIndex].Name == "DENEGAR")
                {
                    changeState.cambiarEstadoSolicitud(id, 3);
                    actualizarTipoSolicitudes();
                }
            }
  
        }

        private void actualizarGrid(int tipo)
        {
            solicitudesRecibidas.seleccionarSolicitudesRecibidas(Session.departamento,tipo, dgvSolicitudes);
        }

        private void llenarCombobox()
        {
            estadosSolicitud.estadosSolicitud(this.cmbTipoSolicitud);
        }

        private void actualizarTipoSolicitudes()
        {
            if (cmbTipoSolicitud.SelectedValue.Equals(1))
            {
                actualizarGrid(1);
                AddColumn(1);
            }
            else if(cmbTipoSolicitud.SelectedValue.Equals(2)){
                actualizarGrid(2);
                AddColumn(2);
            }
            else if(cmbTipoSolicitud.SelectedValue.Equals(3))
            {
                actualizarGrid(3);
                AddColumn(3);
            }
            else if (cmbTipoSolicitud.SelectedValue.Equals(4))
            {
                actualizarGrid(4);
            }
            else
            {
                actualizarGrid(5);
            }
        }

        private void cmbTipoSolicitud_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbTipoSolicitud_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            actualizarTipoSolicitudes();
        }

        private void AddColumn(int b)
        {
            if (b == 1)
            {
                //Agregamos ambas columnas
                removeColumns();

                dgvSolicitudes.Columns.Add(btnAprobar);
                dgvSolicitudes.Columns.Add(btnDenegar);
            }
            else if (b == 2)
            {
                removeColumns();
                //AGREGAMOS SOLO LA COLUMNA DENEGADO
                dgvSolicitudes.Columns.Add(btnDenegar);
            }
            else if (b ==3)
            {
                removeColumns();
                //AGREGAMOS SOLO LA COLUMNA APROBADO
                dgvSolicitudes.Columns.Add(btnAprobar);
            }

        }

        private void removeColumns()
        {
            if (dgvSolicitudes.Columns.Contains("APROBAR"))
            {
                dgvSolicitudes.Columns.Remove("APROBAR");
            }

            if (dgvSolicitudes.Columns.Contains("DENEGAR"))
            {
                dgvSolicitudes.Columns.Remove("DENEGAR");
            }
        }
    }
}
