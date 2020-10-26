using System;

namespace estudando_c_
{
    class Program
    {
        static void Main(string[] args)
        {   
            var soma = 0;            
            for (int i = 1; i < 21; i++){
                if(i % 3 == 0) {
                    soma = soma + i;
                };
            };

            Console.WriteLine($"A soma é de {soma}");
        }
    }                                    
}

