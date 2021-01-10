//1. Crie uma classe para representar uma pessoa, com os atributos privados de nome, data de nascimento e altura. Crie os métodos públicos para imprimir todos dados de uma pessoa e para calcular a idade da pessoa.

using System;
using estudando_c_.Modelo;

namespace estudando_c_
{
  class Program
  {
    private static Pessoa pessoa;
    private static string nomeUsuario;
                
    static void Main(string[] args)
    {       
      Introducao();
      Menu();       
      ImprimirDados();
    }  

    static void Introducao()
    {
      Console.WriteLine("Olá, seja bem vindo ao Exercício número 1!");
      Console.WriteLine("Primeiramente, digite seu nome completo.");
      nomeUsuario = Console.ReadLine();     
    }

    static void Menu()
    {
      
      Console.WriteLine($"Olá {nomeUsuario}, digite agora as informações solicitadas.");
      Console.WriteLine("Primeiro, digite a data do seu nascimento no formato DD/MM/AAAA. (EX: 05/05/1997)");
      var dataNascimento = Convert.ToDateTime(Console.ReadLine());
      Console.WriteLine("Agora digite a sua altura. (EX: 1.63)");
      var altura = Convert.ToDouble(Console.ReadLine());

      pessoa = new Pessoa(nomeUsuario, altura, dataNascimento);            
    }
        
    static void ImprimirDados()
    { 
      Console.WriteLine(pessoa.ImprimirDados());
      Console.WriteLine("Clique para finalizar o programa.");
      Console.ReadKey();
    }
  }
}
