﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominios
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nombre { get; set; }


        public string Contraseña { get; set; }

        public string Apellido { get; set; }

        public string Email { get; set; }

        public string ImagenPerfil { get; set; }

        public bool Administrador { get; set; }


    }
}
