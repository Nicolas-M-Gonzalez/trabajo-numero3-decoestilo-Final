using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominios;

namespace AccesoaDatosArticulo
{
    public class Seguridad
    {
        public static bool SesionActiva(object User) //objetc recibo un objeto generico
        {
            Usuario Usuario = User != null ? (Usuario)User : null; //le digo que es un usuario y valido.

            if (Usuario != null && Usuario.Id != 0) //vuelvo a validar.
                return true;
            else
                 return false;
        }

        public static bool EsAdmin(object user)
        {
            Usuario Usuario = user != null ? (Usuario)user : null;
            return Usuario != null ? Usuario.Administrador : false;
        }

    }
}
