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
        GuardarCotizacionXProveedor cotxProv = new GuardarCotizacionXProveedor();
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
            guardarCotizacion();
        }

        void DataGridViewCurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvProveedores.IsCurrentCellDirty)
            {
                dgvProveedores.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void guardarCotizacion()
        {
            
                for (int i = 0; i < dgvProveedores.Rows.Count; i++)
                {
                    bool? isCellChecked = (bool?)dgvProveedores.Rows[i].Cells[0].Value;

                    if (isCellChecked!=null)
                    {
                        if (isCellChecked==true)
                        {
                            arrayProveedores[i] = i + 1;
                        }
                        else
                        {
                        arrayProveedores[i] = 0;
                        }
                    }
                    else
                     {
                        arrayProveedores[i] = 0;
                    }
                }

            
            bool bandera = false;

            foreach (int i in arrayProveedores)
            {
                if (i != 0)
                {
                    bandera = true;
                } 
            }

            if (bandera)
            {
                exp.guardarPDFBD(dgvSolicitudes);
                foreach (int i in arrayProveedores)
                {
                    if (i != 0)
                    {
                        bool b = cotxProv.guardarCotizacionxProveedor(i);
                        if (b)
                        {
                            frmNotificaciones not = new frmNotificaciones();
                            not.msg = "REGISTRO DE COTIZACION A PROVEEDORES REALIZADA CON ÉXITO";
                            not.Show();
                        }
                    }
                }
            }
            else
            {
                frmNotificaciones not = new frmNotificaciones();
                not.msg = "DEBE SELECCIONAR AL MENOS UN PROVEEDOR";
                not.Show();
            }

        }
            
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

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            MostrarFormularioController mostrar = new MostrarFormularioController();
            mostrar.showOnMain(this, new frmGestionarCotizacion());
        }
    }
}
