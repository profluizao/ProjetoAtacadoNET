using Atacado.Modelo.Ancestral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Modelo.Estoque
{
    public class Produto : BaseCampoPadronizado02
    {
        private int codigoCategoria;

        private int codigoSubcategoria;

        public int CodigoCategoria
        { 
            get { return codigoCategoria; }
            set { codigoCategoria = value; }
        }

        public int CodigoSubcategoria
        { 
            get { return this.codigoSubcategoria; }
            set { this.codigoSubcategoria = value; }
        }

        public Produto(int codigo, string descricao, int codCategoria, int codSubcategoria) 
            : base(codigo, descricao)
        {
            this.codigoCategoria = codCategoria;
            this.codigoSubcategoria = codSubcategoria;
        }
    }
}
