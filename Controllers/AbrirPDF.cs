using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectComprasInventario.Models;

namespace ProjectComprasInventario.Controllers
{
    class AbrirPDF
    {
        public void abrir(int id)
        {
            using (Entity db = new Entity())
            {
                var oDocument = db.archivos_cotizaciones.Find(id);

                string path = AppDomain.CurrentDomain.BaseDirectory;
                string folder = path + "/temp/";
                string fullFilePath = folder + oDocument.nombreArchivo;

                File.WriteAllBytes(fullFilePath, oDocument.archivo);

                Process.Start(fullFilePath);
            }
        }
    }
}
