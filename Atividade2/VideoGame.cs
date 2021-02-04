namespace Atividade2
{
    class VideoGame : Produto, IImposto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool isUsado { get; set; }

        VideoGame()
        {
        }

        public VideoGame(string nome, double preco, int quantidade, string marca, string modelo, bool isUsado):base(nome, preco, quantidade)
        {
            Marca = marca;
            Modelo = modelo;
            this.isUsado = isUsado;
        }

        public double CalculaImposto(double imp)
        {
            /*• Se o vídeo game for usado, calcular imposto de 25% sobre o preço do
            videogame.
            • Se o vídeo game não for usado, calcular imposto de 45% sobre o preço do
            videogame.*/

            if (isUsado)
            {
                imp = Preco * 0.25;
                return imp;
            }
            else
            {
                imp = Preco * 0.45;
                return imp; 
            }
        }
    }
}
