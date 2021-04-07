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
        public String Login(String user){
           
            String usuario = String.Empty;
            int id,rol;
             
            using (Entity db = new Entity())
            {
                var userList = db.SP_Login(user).ToList();
                foreach (var obUser in userList){
                    usuario = obUser.usuario;
                }
            }
            return usuario;
        }
    }
}
