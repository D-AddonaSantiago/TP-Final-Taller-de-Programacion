﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final_Taller_de_Programacion
{
    public class Persona
    {
        public int PersonaId { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public List<Telefono> Telefonos { get; set; }
    }
}
