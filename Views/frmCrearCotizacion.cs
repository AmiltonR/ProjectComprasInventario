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
    
    public partial class frmCrearCotizacion : Form
    {
        SolicitudesGlobalesController solicitudesGlob = new SolicitudesGlobalesController();
        SeleccionarProveedoresController proveedores = new SeleccionarProveedoresController();
        DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
        public int[] arrayProveedores = new int[5];
        public frmCrearCotizacion()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCrearCotizacion_Load(object sender, EventArgs e)
        {
            proveedores.seleccionarProveedor(dgvProveedores);
            solicitudesGlob.solicitudesGlobales(dgvSolicitudes);
            chk.HeaderText = "Seleccionar";
            chk.Name = "chk";
            dgvProveedores.Columns.Add(chk);   
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void revisarChecked()
        {
            int i = 0;
            foreach (DataGridViewRow row in dgvProveedores.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[2];
                if (chk.Selected == true)
                {
                    arrayProveedores[i] = 1;
                    i++;
                }
            }
        }
    }
}
