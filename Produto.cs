using System;

namespace CadastroDeProdutos
{
    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(int id, string nome, decimal preco, int quantidade)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Nome: {Nome}, Preço: {Preco}, Quantidade: {Quantidade}";
        }
    }
}
