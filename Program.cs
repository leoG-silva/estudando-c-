using System;

namespace estudando_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! tudo bem? Ese programa irá realizar uma simulação do lançamento de um projétil de canhão com o objetivo de atingir determinado alvo!");
            Console.WriteLine("Espera-se que com esse programa, obtenha-se o alcance horizontal, o tempo do trajeto, a altura máxima atingida pela bala e se o projétil acertou o alvo!.");

            //velocidade inicial

            var velocidadeInicial = 0;

            while (velocidadeInicial <= 0) { 
                Console.WriteLine ("Informe a velocidade inicial do projétil! EX: 20, 80 (Valor em m/s)");
                velocidadeInicial = Convert.ToInt32(Console.ReadLine());
                if (velocidadeInicial <= 0) {
                    Console.WriteLine ("Você deve informar um valor maior que 0!");                
                };
            };

            // angulo de inclinação

            double angulo = 0;

            while ((angulo <= 0 || angulo > 90)) {
                Console.WriteLine("Informe o angulo de inclinação do canhão entre 0 e 90 graus! Ex: (30, 50))");
                angulo = (Convert.ToInt32(Console.ReadLine()));
                if ((angulo <= 0 || angulo > 90)) {   
                    Console.WriteLine("Informe novamente o angulo do disparo! (entre 0 e 90 graus)");
                };
            };      

            var anguloRadianos = (angulo*Math.PI) / (180) ;                              
                                     
            var aceleracao = 9.81;

            // formulas altura máxima, tempo de trajeto e alcance horizonal

            var alturaMaxima = (Math.Pow(velocidadeInicial, 2) * Math.Pow(Math.Sin(anguloRadianos), 2)) / (2 * aceleracao);
            var tempoTrajeto = (2 * velocidadeInicial * Math.Sin(anguloRadianos)) / aceleracao; 
            var alcanceHorizontal = (2 * Math.Pow(velocidadeInicial, 2)) * ((Math.Cos(anguloRadianos) * Math.Sin(anguloRadianos)) / aceleracao);
    
            // distancia do alvo!

            int distanciaAlvo = 0;
                        
            while (distanciaAlvo <= 0) {    
                Console.WriteLine("Agora informe a distância em que se encontra o alvo!");
                distanciaAlvo = Convert.ToInt32(Console.ReadLine());
                if (distanciaAlvo <= 0) {
                    Console.WriteLine("Informe uma distância maior que 0!");
                };
            };

            //tamanho do alvo!

            long tamanhoAlvo = 0;
            
            while ((tamanhoAlvo < 20 || tamanhoAlvo > 50)) {
                Console.WriteLine("Informe o tamanho do seu alvo, sendo o valor igual ou maior que 20, e igual ou menor que 50!");
                tamanhoAlvo = Convert.ToInt64(Console.ReadLine());
                if ((tamanhoAlvo < 20) || (tamanhoAlvo > 50)) {
                    Console.WriteLine("Informe um valor maior que 20 e menor que 50!");
                };
            };

            var alvoFinal = (distanciaAlvo + tamanhoAlvo);

            //respostas

            Console.WriteLine("A altura máxima do projétil foi de: " + alturaMaxima);
            Console.WriteLine("O tempo do trajeto do projétil foi de: " + tempoTrajeto);
            Console.WriteLine("O alcance horizontal do projétil foi de: " + alcanceHorizontal);
            Console.WriteLine("O alvo está à " + distanciaAlvo + " metros do canhão, com tamanho de " + tamanhoAlvo + " metros!");

            if (alcanceHorizontal > alvoFinal) { 
                Console.WriteLine ("O projétil caiu depois do alvo!");
            };

            if (alcanceHorizontal < distanciaAlvo) {
                Console.WriteLine ("O projétil caiu antes do alvo");
            };
            
            if ((alcanceHorizontal <= alvoFinal) && (alcanceHorizontal >= distanciaAlvo)) {
                 Console.WriteLine ("O projétil acertou o alvo!");                    
            }
        }
    }                                    
}

