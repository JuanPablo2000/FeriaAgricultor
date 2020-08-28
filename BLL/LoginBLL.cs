using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginBLL
    {
        public static string validarRol(int cedula, string contraseña) 
        {
            return LoginOperaciones.validarRol(cedula,contraseña);
        }
    }
}
