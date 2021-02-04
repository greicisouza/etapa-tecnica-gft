using System;

namespace EtapaTecnicaGFT
{
    class Program
    {
        /*1) Leia 3 números de ponto flutuante. Depois, imprima as raízes da fórmula de
        bhaskara. Se for impossível calcular as raízes devido a uma divisão por zero ou
        raiz quadrada de um número negativo, apresente a mensagem “Impossível
        calcular”. Imprima o resultado com 5 dígitos após o ponto decimal.
        */
        static void Main(string[] args)
        {
            Calcula calcula = new Calcula();
            Console.Write("Insira o valor de A: ");
            calcula.A = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor de B: ");
            calcula.B = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor de C: ");
            calcula.C = double.Parse(Console.ReadLine());

            calcula.ImprimeValores();
            Console.ReadKey();
        }
    }
}
