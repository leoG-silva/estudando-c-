using System;

namespace estudando_c_.Modelo
{
  public class Pessoa
  {
    private string _nome { get; }
    private double _altura { get; }
    private DateTime _dataNascimento { get; }

    public Pessoa(string nome, double altura, DateTime dataNascimento) 
    { 
        _nome = nome;
        _altura = altura;
        _dataNascimento = dataNascimento;
    }

    private int CalcularIdade()
    {
        return DateTime.Today.Year - _dataNascimento.Year;
    }
    public string ImprimirDados() 
    {
        return $"Seu nome completo é {_nome}, você nasceu em {_dataNascimento.ToString("dd/MM/yyyy")} ({CalcularIdade()} anos), e possui {_altura.ToString("#.##")} de altura!";
    }
  }
}

