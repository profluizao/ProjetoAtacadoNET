﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.POCO.IBGE
{
    public class EstadoPOCO
    {
        public int Codigo { get; set; }

        public string Descricao { get; set; }

        public string SiglaUF { get; set; }

        public string RegiaoBrasil { get; set; }
    }
}