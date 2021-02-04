using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade2
{
    class Loja
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }

        List<Livro> livros { get; set; }

        List<VideoGame> videoGames { get; set; }

        Loja()
        {
        }

        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
        {
            Nome = nome;
            Cnpj = cnpj;
            this.livros = livros;
            this.videoGames = videoGames;
        }

        public void ListaLivros()
        {

        }
        public void ListaVideoGames()
        {

        }
        //public double CalculaPatrimonio()
        //{

        //}
    }
}
