namespace estudando_c_.Modelos
{
    public class Pessoa
    {
        public string Nome { get; }
        public int Telefone { get; }

        public Pessoa(string nome, int telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }

        public string ObterDescricaoConvidado()
        {
            return $"Nome do convidado: {Nome} com telefone: {Telefone}";
        }
    }
}