﻿using Atacado.Modelo.Ancestral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Modelo.Estoque
{
    public class Subcategoria : BaseCampoPadronizado02
    {
        private int codigoCategoria;

        private List<Produto> produtos;

        public int CodigoCategoria { get => codigoCategoria; set => codigoCategoria = value; }

        public List<Produto> Produtos { get => produtos; set => produtos = value; }

        public Subcategoria(int codigo, string descricao, int codigoCategoria) 
            : base(codigo, descricao)
        {
            this.codigoCategoria = codigoCategoria;
        }
    }
}
