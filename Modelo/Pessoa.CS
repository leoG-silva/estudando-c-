using System;

namespace estudando_c_.Modelo
{
  public class Pessoa
  {
    internal object nomeUsuario;

    private string _nome { get; set; }
    private double _altura { get; set; }
    private DateTime _dataNascimento { get; set; }

    public string Nome(string nome) => _nome = nome;

    public DateTime DataNascimento(DateTime dataNascimento) => _dataNascimento = dataNascimento;

    public double Altura(double altura) => _altura = altura;
  }
}

