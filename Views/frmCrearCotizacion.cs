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
        public int[] arrayProveedores = new int[3];
        ExportarPDF exp = new ExportarPDF();
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

            //PARÁMETROS DE TOOLTIP
            this.toolTip1.SetToolTip(btnGuardar, "Esta acción enlaza y guarda la cotización con los proveedores. No envía la cotización a los proveedores");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
     
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            revisarChecked();
        }

        void DataGridViewCurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvProveedores.IsCurrentCellDirty)
            {
                dgvProveedores.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void revisarChecked()
        {
            /*if (dgvProveedores.Rows[0].Cells[0].Value != null || dgvProveedores.Rows[1].Cells[0].Value != null || dgvProveedores.Rows[2].Cells[0].Value != null)
            {*/
                for (int i = 0; i < dgvProveedores.Rows.Count; i++)
                {
                    bool? isCellChecked = (bool?)dgvProveedores.Rows[i].Cells[0].Value;

                    if (isCellChecked!=null)
                    {
                        if (isCellChecked==true)
                        {
                            arrayProveedores[i] = i + 1;
                        }
                    }
                    else
                     {
                        arrayProveedores[i] = 0;
                    }
                }

                exportar();
           /* }
            else
            { 
                MessageBox.Show("Debe seleccionar los proveedores");
            }*/
        }
            

           

            /*for (int i = 0; i < dgvProveedores.Rows.Count; i++)
            {
                Console.WriteLine(arrayProveedores[i]);
            }*/
        private void exportar()
        {
            exp.guardarPDFSO(dgvSolicitudes);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            exportar();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
