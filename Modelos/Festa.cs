using System;
using System.Collections.Generic;

namespace estudando_c_.Modelos
{
    public class Festa
    {
        public List<Pessoa> Convidados { get; }
        private string _nome;
        private DateTime _horario;
        private string _local;

        public Festa(string nome, DateTime horario, string local)
        {
            _nome = nome;
            _horario = horario;
            _local = local;
            Convidados = new List<Pessoa>();
        }

        public void AdicionarConvidado(Pessoa novoConvidado)
        {
            ValidarConvidadoRepetido(novoConvidado);
            Convidados.Add(novoConvidado);
        }

        private void ValidarConvidadoRepetido(Pessoa convidadoParaValidar)
        {
            var convidadoRepetido = Convidados.FindLast(
                pessoa => pessoa.Nome == convidadoParaValidar.Nome || pessoa.Telefone == convidadoParaValidar.Telefone);
            if (convidadoRepetido != null)
                throw new Exception("Convidado repetido (nome ou telefone não podem repetir na lista)");
        }
    }
}