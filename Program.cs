using System;

namespace estudando_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja realizar?");
            Console.WriteLine("Soma: '+' | Subtração: '-' | Multiplicação: '*' | Divisão : '/'");
            var operacao = Console.ReadLine();

            Console.WriteLine("Agora informe os dois números!");
            var numero1 = Convert.ToInt32(Console.ReadLine());
            var numero2 = Convert.ToInt32(Console.ReadLine());
            var resultado = 0;

            switch (operacao) {
                 case "+":
                 resultado = numero1 + numero2; 
                 break;

                 case "-":
                 resultado = numero1 - numero2;
                 break;

                 case "*":
                 resultado = numero1 * numero2;
                 break;

                 case "/":
                 resultado = numero1 / numero2;
                 break;       

                 default: 
                 Console.WriteLine("Você não selecionou as operações corretamente!");
                 break;
            };

            Console.WriteLine("O resultado da sua operação é: " + resultado);
            Console.ReadKey();
        }
    }
}
