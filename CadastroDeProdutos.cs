using System;
using System.Collections.Generic;

namespace CadastroDeProdutos
{
    class CadastroDeProdutos
    {
        private List<Produto> produtos = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public void ListarProdutos()
        {
            foreach (var produto in produtos)
            {
                Console.WriteLine(produto.ToString());
            }
        }

        public Produto BuscarProdutoPorId(int id)
        {
            return produtos.Find(p => p.Id == id);
        }
    }
}
