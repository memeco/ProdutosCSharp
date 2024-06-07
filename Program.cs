using System;

namespace CadastroDeProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            var cadastro = new CadastroDeProdutos();

            while (true)
            {
                Console.WriteLine("1 - Adicionar produto");
                Console.WriteLine("2 - Listar produtos");
                Console.WriteLine("3 - Buscar produto por ID");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Digite o ID do produto: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Digite o nome do produto: ");
                        string nome = Console.ReadLine();
                        Console.Write("Digite o preço do produto: ");
                        decimal preco = decimal.Parse(Console.ReadLine());
                        Console.Write("Digite a quantidade do produto: ");
                        int quantidade = int.Parse(Console.ReadLine());

                        var produto = new Produto(id, nome, preco, quantidade);
                        cadastro.AdicionarProduto(produto);
                        Console.WriteLine("Produto adicionado com sucesso.");
                        break;

                    case "2":
                        cadastro.ListarProdutos();
                        break;

                    case "3":
                        Console.Write("Digite o ID do produto para buscar: ");
                        int idBusca = int.Parse(Console.ReadLine());
                        var produtoBusca = cadastro.BuscarProdutoPorId(idBusca);

                        if (produtoBusca != null)
                        {
                            Console.WriteLine(produtoBusca.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Produto não encontrado.");
                        }
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}
