using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectComprasInventario.Models;
using ProjectComprasInventario.Views;

namespace ProjectComprasInventario.Controllers
{
    class LoginController
    {
        public int Login(String user, String pass){
            int bandera = 0;
             
            using (Entity db = new Entity())
            {
                var userList = db.SP_Login(user,pass).ToList();
                if (userList.Any())
                {
                    bandera = 1;
                    foreach (var obUser in userList)
                    {
                        Session.id = obUser.ID_usuario;
                        Session.nombres = obUser.nombres;
                        Session.usuario = obUser.usuario;
                        Session.rol = obUser.id_rol;
                        Session.departamento = obUser.id_departamento;
                        Session.apellidos = obUser.apellidos;
                    }
                }
               
            }
            return bandera;
        }
    }
}
