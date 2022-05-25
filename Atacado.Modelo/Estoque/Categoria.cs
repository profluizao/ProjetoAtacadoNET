using Atacado.Modelo.Ancestral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Modelo.Estoque
{
    public class Categoria : BaseCampoPadronizado02
    {
        private List<Subcategoria> subcategorias;

        public List<Subcategoria> Subcategorias
        {
            get { return this.subcategorias; }
            set { this.subcategorias = value; }
        }

        public Categoria(int codigo, string descricao) 
            : base(codigo, descricao)
        {
        }
    }
}
