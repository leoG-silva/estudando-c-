using System;

namespace estudando_c_
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Olá, Somos da ViTintas");
            Console.WriteLine("Nesse programa, voce irá descobrir saber a quantidade de tintas e seu valor para pintar a sua residência");
            Console.WriteLine("Quantos metros quadrados de parede você deseja pintar em sua residência?");
            var metrosQuadrados = Convert.ToInt32(Console.ReadLine());

            
            var lataTinta = 18;
            var valorTinta = 80;
            var quantidadeLitros = metrosQuadrados / 3;
            var quantidadeTinta = quantidadeLitros / lataTinta;

            var valorFinal = quantidadeTinta * valorTinta;

            Console.WriteLine($"Você deverá comprar {quantidadeTinta} latas de tinta, sendo o valor total de R${valorFinal}!");
        }
    }                                    
}

