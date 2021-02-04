using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade2
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Qtd { get; set; }

        public Produto()
        {

        }
        public Produto(string nome, double preco, int qtd)
        {
            Nome = nome;
            Preco = preco;
            Qtd = qtd;
        }
    }
}
