using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectComprasInventario.Models;

namespace ProjectComprasInventario.Controllers
{
    class GuardarPDF
    {
        public bool guardarArchivo(String name,byte[] file)
        {
            int idCotizacion = 0;
            bool isSuccesful = false;
            using (Entity db = new Entity())
            {
                try
                {
                    db.SP_GuardarCotizacion(name, file, Session.id);

                    var idCot = db.SP_IdArchivoCotizacion(name).ToList();

                    if (idCot.Any())
                    {
                        foreach (var obCotizacion in idCot)
                        {
                            idCotizacion = obCotizacion.ID_archivos_cotizaciones;
                        }
                    }

                    
                    var Cot = db.SP_IdCotizacion(idCotizacion).ToList();

                    if (Cot.Any())
                    {
                        foreach (var obCotizacion in Cot)
                        {
                            Session.idCotizacion = obCotizacion.ID_cotizacion;
                        }
                    }

                    isSuccesful = true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return isSuccesful;
        }
    }
}
