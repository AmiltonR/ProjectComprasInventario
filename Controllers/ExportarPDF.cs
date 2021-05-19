using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace ProjectComprasInventario.Controllers
{
    class ExportarPDF
    {
        byte[] file = null;
        
        public void exportToPdf(DataGridView dgv)
        {
            //CONFIGURACIONES GENERALES
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //CREANDO UN ENCABEZADO DE ARCHIVÓ
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font ftnHead = new Font(bfntHead, 16,1, BaseColor.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk("COTIZACIÓN",ftnHead));

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //Agregar Encabezado
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240,240,240);
                pdfTable.AddCell(cell);
            }

            //Agregar datarow
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(new Phrase(cell.Value.ToString(),text));
                }
            }

            //CON EL MEMORYSTREAM OBTENDREMOS LOS BYTES PARA ALMACENAR EN LA BD
            using (MemoryStream ms = new MemoryStream())
            {
                using (Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f))
                {
                    PdfWriter.GetInstance(pdfdoc, ms);
                    pdfdoc.Open();
                    pdfdoc.Add(prgHeading);
                    pdfdoc.Add(new Chunk("\n",ftnHead));
                    pdfdoc.Add(pdfTable);
                }

                //ALMACENAMOS EL MS EN UN ARRAY
                file = ms.ToArray();
  
            }
        }

        public void guardarPDFSO(DataGridView dgv)
        {
            string fileName = "Cotizacion" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
            exportToPdf(dgv);
            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = fileName;
            savefiledialoge.DefaultExt = ".pdf";
            //GUARDAMOS UNA COPIA DEL ARCHIVO EN LA UBICACIÓN DETERMINADA POR EL USUARIO
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create, FileAccess.ReadWrite))
                {
                    //ESCRIBIMOS EL ARCHIVO A PARTIR DEL ARRAY DE BYTES
                    stream.Write(file, 0, file.Length);
                }
            }
        }//guardarPDFSO

        public void guardarPDFBD(DataGridView dgv)
        {
            string fileName = "Cotizacion" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
            exportToPdf(dgv);
            //GUARDAMOS EL ARCHIVO EN LA BASE DE DATOS
            GuardarPDF guardarPdf = new GuardarPDF();
            guardarPdf.guardarArchivo(fileName, file);

            /*AbrirPDF abrirPdf = new AbrirPDF();
            abrirPdf.abrir(1);*/
        }
      
    }
}
