using Atacado.Domain.Estoque;
using Atacado.POCO.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Map.Estoque
{
    public static class SubcategoriaMap
    {
        public static SubcategoriaPOCO ConverterParaPoco(Subcategoria domain)
        {
            return new SubcategoriaPOCO()
            {
                Codigo = domain.Codigo,
                CodigoCategoria = domain.CodigoCategoria,
                Descricao = domain.Descricao,
                Situacao = domain.Situacao
            };
        }

        public static Subcategoria ConverterParaDomain(SubcategoriaPOCO poco)
        {
            return new Subcategoria(poco.Codigo, poco.CodigoCategoria, poco.Descricao, poco.Situacao);
        }
    }
}