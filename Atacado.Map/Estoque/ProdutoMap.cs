using Atacado.Domain.Estoque;
using Atacado.POCO.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Map.Estoque
{
    public static class ProdutoMap
    {
        public static ProdutoPOCO ConverterParaPoco(Produto domain)
        {
            return new ProdutoPOCO()
            {
                Codigo = domain.Codigo,
                CodigoSubcategoria = domain.CodigoSubcategoria,
                CodigoCategoria = domain.CodigoCategoria,
                Descricao = domain.Descricao,
                Situacao = domain.Situacao
            };
        }

        public static Produto ConverterParaDomain(ProdutoPOCO poco)
        {
            return new Produto(poco.Codigo, poco.CodigoSubcategoria, poco.CodigoCategoria, poco.Descricao, poco.Situacao);
        }
    }
}