//1. Crie uma classe para representar uma pessoa, com os atributos privados de nome, data de nascimento e altura. Crie os métodos públicos para imprimir todos dados de uma pessoa e para calcular a idade da pessoa.

using System;
using estudando_c_.Modelo;

namespace estudando_c_
{
  class Program
  {
    private static Pessoa pessoa;
    private static string nomeUsuario;
    private static DateTime dataNascimento;
            
    static void Main(string[] args)
    { 
      pessoa = new Pessoa();
      Introducao();
      Menu();       
      ImprimirDados();
    }  

    static void Introducao()
    {
      Console.WriteLine("Olá, seja bem vindo ao Exercício número 1!");
      Console.WriteLine("Primeiramente, digite seu nome completo.");
      var nomeUsuario = Console.ReadLine();
      var nome = nomeUsuario;
    }

    static void Menu()
    {
      Console.WriteLine($"Olá {nomeUsuario}, digite agora as informações solicitadas.");
      Console.WriteLine("Primeiro, digite a data do seu nascimento no formato MM/DD/AAAA. (EX: 05/20/1997)");
      var dataNascimento = DateTime.Parse(Console.ReadLine());
      Console.WriteLine("Agora digite a sua altura. (EX: 1.63)");
      var altura = Console.ReadLine();
      
      CalcularIdade();
    }
    
    static void CalcularIdade()
    {
      var idade = DateTime.Today.Year - dataNascimento.Year; 
    }

    static void ImprimirDados()
    { 
      Console.WriteLine($"Seu nome completo é {Pessoa.Nome}, você nasceu em {Pessoa.DataNascimento} ({idade} anos), e possui {altura} de altura!");
      Console.WriteLine("Clique para finalizar o programa.");
      Console.ReadKey();
    }
  }
}
