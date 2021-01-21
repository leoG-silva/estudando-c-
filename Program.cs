using System;
using estudando_c_.Modelo;

namespace estudando_c_
{
  class Program
  {
    private static Elevador elevador;
    private static string nomeUsuario;
    private static int andarAtual;
    private static int totalDeAndares;
    private static int quantidadePessoasElevador;
    private static int capacidadeMaxima;
    static void Main(string[] args)
    
    {         
      Introducao();
      elevador = new Elevador(totalDeAndares, andarAtual, capacidadeMaxima, quantidadePessoasElevador);
      ReterInformacoes();      
      Menu();
    }

    static void Introducao()
    {
      Console.WriteLine("Olá, seja bem-vindo ao Execício 2!");
      Console.WriteLine("Primeiramente, qual seu nome?");
      nomeUsuario = Console.ReadLine();
    }

    static void ReterInformacoes()
    {
      Console.WriteLine($"Olá {nomeUsuario}, seja bem vindo");
      Console.WriteLine("O Exercício trata-se de um exemplo de elevador");
      Console.WriteLine("Informe a quantidade total de andares que o prédio possue. EX: 3");
      int totalDeAndares = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Agora informe a quantidade máxima de pessoas no elevador. EX: 5");
      int capacidadeMaxima = Convert.ToInt32(Console.ReadLine());
      Console.Clear();

      Console.WriteLine($"O elevador possue {totalDeAndares} andares, com capacidade máxima de {capacidadeMaxima} pessoas!");
      Console.WriteLine("O elevador começa no térreo, sem pessoas no momento inicial");
      Console.WriteLine("Aperte qualquer botão para continuar!");
      Console.ReadKey();  
    }    

    static void Menu() 
    {
      Console.WriteLine("Selecione uma das opções:");
      Console.WriteLine("1 - Subir um andar");
      Console.WriteLine("2 - Descer um andar");
      Console.WriteLine("3 - Entrar uma pessoa no elevador");
      Console.WriteLine("4 - Sair uma pessoa no elevador");
      Console.WriteLine("5 - Finalizar programa!");
      Console.WriteLine("6 - Empina e rebola? ...");
      Console.WriteLine($"Você está no {andarAtual}° andar, com {quantidadePessoasElevador} de pessoa(s) no elevador");
      int menuElevador = Convert.ToInt32(Console.ReadLine());

      switch (menuElevador)
      {
        case 1:
          elevador.SubirAndar(andarAtual, totalDeAndares);
          break;

        case 2:
          elevador.DescerAndar(andarAtual);
          break;

        case 3:
          elevador.EntrarPessoa(quantidadePessoasElevador, capacidadeMaxima);
          break;

        case 4:
          elevador.SairPessoa(quantidadePessoasElevador);
          break;

        case 5:
          FinalizarPrograma();
          break;

        case 6:
          elevador.EmpinarERebolar();
          break;

        default:
          Console.Write("Você digitou nenhum dos parãmetros corretamente.");
          Console.ReadKey();
          break;
      }

      Menu();
    }
          
    static void FinalizarPrograma()
    {
      Console.WriteLine("Aperte qualquer botão para finalizar o programa!");
      Console.ReadKey();
      Environment.Exit(0);
    }
  }
}
