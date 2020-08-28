using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginOperaciones
    {
        public static string validarRol(int cedula, string contraseña)
        {
            string rol="";
            try
            {
                using (var ctx = new FeriaDBcontext())
                {

                    if (ctx.CLIENTE.Find(cedula) != null)
                    {
                        rol = "cliente";
                    }
                    else if (ctx.VENDEDOR.Find(cedula) != null)
                    {
                        rol = "vendedor";
                    } else if (ctx.ADMINISTRADOR.Find(cedula) != null)
                    {
                        rol = "administrador";
                    } else if (ctx.TRANSPORTISTA.Find(cedula) != null) 
                    {
                        rol = "transportista";
                    }
                }
            }
            catch (Exception)
            {
            }
            return  rol;
            ;
        }
    }
}
