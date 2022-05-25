﻿using Atacado.Modelo.Ancestral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Modelo.IBGE
{
    public class Regiao : BaseCampoPadronizado02
    {
        private List<Estado> estados;

        public List<Estado> Estados { get { return estados; } set { estados = value; } }

        public Regiao(int codigo, string descricao) 
            : base(codigo, descricao)
        {
        }
    }
}
