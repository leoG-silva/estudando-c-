using System;

namespace estudando_c_.Modelo
{
    public class Elevador
    {
        public int TotalDeAndares;
        public int AndarAtual;
        public int CapacidadeMaxima;
        public int QuantidadePessoasElevador;

        public Elevador(int totalDeAndares, int capacidadeMaxima)
        {
            TotalDeAndares = totalDeAndares;
            CapacidadeMaxima = capacidadeMaxima;
        }

        public void SubirAndar()
        {
            if (AndarAtual < TotalDeAndares)
            {
                AndarAtual++;
                Console.WriteLine("Você subiu um andar");
            }
            else
            {
                Console.WriteLine("Você está no último andar do prédio");
            }
        }

        public void DescerAndar()
        {
            if (AndarAtual > 0)
            {
                AndarAtual--;
                Console.WriteLine("Você desceu um andar");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Você está no térreo");
            }
        }

        public void EntrarPessoa()
        {
            if (QuantidadePessoasElevador < CapacidadeMaxima)
            {
                QuantidadePessoasElevador++;
                Console.WriteLine("Uma pessoa entrou no elevador");
            }
            else
            {
                Console.WriteLine("A capacidade máxima de pessoas no elevador foi atingida");
            }
        }

        public void SairPessoa()
        {
            if (QuantidadePessoasElevador > 0)
            {
                QuantidadePessoasElevador--;
                Console.WriteLine("Uma pessoa saiu do elevador");
            }
            else
            {
                Console.WriteLine("Não há pessoas no elevador");
            }
        }

        public string EmpinarERebolar()
        {
            return "Toda delícia, toda gostosa.";
        }
    }
}