﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Imagen
    {
        public int Idarticulo { get; set; }

        public int Id { get; set; }

        public string URLImagen { get; set; }

        public override string ToString()
        {
            return URLImagen;
        }
    }
}
