using System;

namespace estudando_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, bem vindo a Fruteiras Cangaiba");
            Console.WriteLine("Quantos Kg de morango você deseja?");
            var quantidadeMorango = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Agora, qual a quantidade de maça que você deseja?");
            var quantidadeMaca = Convert.ToDouble(Console.ReadLine());   

            double valorMorango = 0;
            double valorMaca = 0;
                     
            if (quantidadeMorango <= 5) {
                valorMorango = (quantidadeMorango * 2.50);
            } else {
                valorMorango = (quantidadeMorango * 2.20);
            };

            if (quantidadeMaca <= 5) {
                valorMaca = (quantidadeMaca * 1.80);
            } else {
                valorMaca = (quantidadeMaca * 1.50);
            };

            var quantidadeTotal = quantidadeMorango + quantidadeMaca;
            var valorTotal = Math.Round((valorMorango + valorMaca), 2);            
            
            if ((quantidadeTotal > 8) || (valorTotal > 25)) {
                valorTotal = Math.Round(Convert.ToDouble(valorTotal * 0.90), 2);
            };

            Console.WriteLine ($"Você comprou {quantidadeTotal} kg de frutas, totalizando o valor de R${valorTotal}.");
        }
    }                                    
}

