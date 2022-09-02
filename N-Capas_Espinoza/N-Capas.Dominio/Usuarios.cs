﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Capas.Dominio
{
    public class Usuarios
    {
        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public bool Estado { get; set; }
        public string Observacion { get; set; }
        public string NombreCompleto
        {
            get
            {
                return this.Nombres + " " + this.Apellidos;
            }
        }
    }
}
