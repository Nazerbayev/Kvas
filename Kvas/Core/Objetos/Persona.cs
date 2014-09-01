﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Kvas.Core.Objetos
{

    [Serializable]
    public class Persona
    {
        public String Nombre { get; set; }
        public String Imagen { get; set; }
        public String Merito { get; set; }
    }
}