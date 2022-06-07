using Atacado.DAL.Estoque;
using Atacado.Domain.Estoque;
using Atacado.Map.Estoque;
using Atacado.POCO.Estoque;
using Atacado.Service.Ancestral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Service.Estoque
{
    public class ProdutoService :
        IAcaoAdicionarSrv<ProdutoPOCO>,
        IAcaoAlterarSrv<ProdutoPOCO>,
        IAcaoExcluirSrv<ProdutoPOCO>,
        IAcaoListarSrv<ProdutoPOCO>,
        IAcaoSelecionarSrv<ProdutoPOCO>
    {
        private ProdutoDAO dao;

        public ProdutoService()
        {
            this.dao = new ProdutoDAO();
        }

        public ProdutoPOCO Adicionar(ProdutoPOCO obj)
        {
            Produto dom = ProdutoMap.ConverterParaDomain(obj);
            Produto criado = this.dao.Create(dom);
            return ProdutoMap.ConverterParaPoco(criado);
        }

        public ProdutoPOCO Alterar(ProdutoPOCO obj)
        {
            Produto dom = ProdutoMap.ConverterParaDomain(obj);
            Produto alterado = this.dao.Update(dom);
            return ProdutoMap.ConverterParaPoco(alterado);
        }

        public ProdutoPOCO Excluir(ProdutoPOCO obj)
        {
            Produto dom = ProdutoMap.ConverterParaDomain(obj);
            Produto deletado = this.dao.Delete(dom);
            return ProdutoMap.ConverterParaPoco(deletado);
        }

        public List<ProdutoPOCO> Listar()
        {
            List<ProdutoPOCO> listPOCO = this.dao.ReadAll().Select(prod => new ProdutoPOCO()
            {
                Codigo = prod.Codigo,
                CodigoCategoria = prod.CodigoCategoria,
                CodigoSubcategoria = prod.CodigoSubcategoria,
                Descricao = prod.Descricao,
                Situacao = prod.Situacao
            }).ToList();
            return listPOCO;
        }

        public ProdutoPOCO Selecionar(int id)
        {
            Produto dom = this.dao.Read(id);
            if (dom != null)
                return ProdutoMap.ConverterParaPoco(dom);
            else
                return null;
        }
    }
}
