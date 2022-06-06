using Atacado.DAL.Estoque;
using Atacado.Domain.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAtacadoDAL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Informe o código da Categoria: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            ApresentarCategoria(codigo);
            Console.ReadLine();
        }

        private static void ApresentarCategoria(int id)
        {
            CategoriaDAO dao = new CategoriaDAO();
            Categoria cat = dao.Read(id);
            Imprimir(cat);
        }

        private static void Imprimir(Categoria cat)
        {
            Console.Write("Código: {0} - ", cat.Codigo);
            Console.Write("Nome: {0} - ", cat.Descricao);
            Console.WriteLine("Situacao: {0}", cat.Situacao);
        }
    }
}
