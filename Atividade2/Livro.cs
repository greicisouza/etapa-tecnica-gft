namespace Atividade2
{
    class Livro : Produto, IImposto
    {
        public string Autor {get; set; }
        public string Tema { get; set; }
        public int QtdPag { get; set; }

        //private IImposto _imposto;

        public Livro(string nome, double preco, int quantidade, string autor, string tema, int qtdPag) : base(nome, preco, quantidade)
        {
            Autor = autor;
            Tema = tema;
            QtdPag = qtdPag;
        }

        public Livro()
        {
        }

        public double CalculaImposto(double imp)
        {
            /*Se o livro for de tema = “educativo” não se deve cobrar imposto, retornar 0.
            • Caso seja de qualquer outro tema, calcular imposto de 10% sobre o preço
            do livro*/
            if (Tema != "educativo")
            {
                imp = Preco * 0.10;
                return imp;
            }
            else
            {
                imp = 0.0;
                return imp ;
            }
        }
    }
}
