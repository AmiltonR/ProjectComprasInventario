using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectComprasInventario.Controllers;

namespace ProjectComprasInventario.Views
{
    public partial class frmDetalleCotizacion : Form
    {
        DataGridViewButtonColumn btnFile = new DataGridViewButtonColumn();
        SeleccionarCotizacionController cotizacion = new SeleccionarCotizacionController();
        String fileName;
        int id;
        int estado= 0;

        public frmDetalleCotizacion()
        {
            InitializeComponent();
        }

        private void frmDetalleCotizacion_Load(object sender, EventArgs e)
        {
            //COLOCAMOS EL TEXTO POR DEFECTO DE LOS CONTROLES
            lblId.Text = Session.cotizacionDetalle.ToString();

            var list = cotizacion.seleccionarCotizacion();
            foreach (var ob in list)
            {
                lblFecha.Text = ob.fecha.ToString();
                lblUsuario.Text = ob.id_usuario.ToString();
                estado = ob.id_estado;
            }

            actualizarGrid();



            btnFile.Name = "ADJUNTAR ARCHIVO";
            btnFile.Text = "ADJUNTAR ARCHIVO";
            btnFile.UseColumnTextForButtonValue = true;
            dgvProveedores.Columns.Add(btnFile);
            //dgvProveedores.Columns[2].Visible = false;
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProveedores.Columns[e.ColumnIndex].HeaderText== "ADJUNTAR ARCHIVO")
            {
               id = int.Parse(dgvProveedores.Rows[dgvProveedores.CurrentRow.Index].Cells[1].Value.ToString());
               openFile();
            }
        }
        
        private void openFile()
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter="Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = "Cotizacion_Recibida" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
                byte[] file = null;
                Stream myStream = openFileDialog1.OpenFile();
                using (MemoryStream ms = new MemoryStream())
                {
                    myStream.CopyTo(ms);
                    file = ms.ToArray();
                }

                GuardarPDFRecibido guardar = new GuardarPDFRecibido();

                if (guardar.Guardar(fileName, file, id))
                {
                    frmNotificaciones not = new frmNotificaciones();
                    not.msg = "Good";
                    actualizarGrid();
                }
            }

           
        }

        private void actualizarGrid()
        {
            SelecProvCotizacionController prov = new SelecProvCotizacionController();
            prov.seleccionarProveedores(dgvProveedores, this.cmbProveedores);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarFormularioController mostrar = new MostrarFormularioController();
            mostrar.showOnMain(this,new frmGestionarCotizacion());
        }

        private void linklblLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirPDF abrir = new AbrirPDF();
            abrir.abrir(Session.cotizacionDetalle);
        }
    }
}
