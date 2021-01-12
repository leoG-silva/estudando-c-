using System;

namespace estudando_c_.Modelo
{
  public class Elevador
  {
    public int TotalDeAndares { get; }
    public int AndarAtual { get; }
    public int CapacidadeMaxima { get; }
    public int QuantidadePessoasElevador { get; }
    public Elevador(int totalDeAndares, int andarAtual, int capacidadeMaxima, int quantidadePessoasElevador)
    {
      TotalDeAndares = totalDeAndares;
      AndarAtual = andarAtual;
      CapacidadeMaxima = capacidadeMaxima;
      QuantidadePessoasElevador = quantidadePessoasElevador;
    }
    public void SubirAndar(int andarAtual, int totalDeAndares)
    {
      if (andarAtual <= totalDeAndares)
      {
        andarAtual++;
        Console.WriteLine("Você subiu um andar");
      }
      else
      {
        Console.WriteLine("Você está no último andar do prédio");
      }
    }
    public void DescerAndar(int andarAtual)
    {
      if (andarAtual < 0)
      {
        andarAtual--;
        Console.WriteLine("Você desceu um andar");
      }
      else
      {
        Console.WriteLine("Você está no térreo");
      }      
    }
    public void EntrarPessoa(int quantidadePessoasElevador, int capacidadeMaxima)
    {
      if (quantidadePessoasElevador <= capacidadeMaxima)
      {
        quantidadePessoasElevador++;
        Console.WriteLine("Uma pessoa entrou no elevador");
      }
      else
      {
        Console.WriteLine("A capacidade máxima de pessoas no elevador foi atingida");
      }      
    }
    public void SairPessoa(int quantidadePessoasElevador)
    {
      if (quantidadePessoasElevador < 0)
      {
        quantidadePessoasElevador--;
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

