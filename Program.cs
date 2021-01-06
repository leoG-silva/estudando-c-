using System;
using System.Collections.Generic;
using estudando_c_.Modelos;

namespace estudando_c_
{
    class Program
    {
        static List<int> telefoneDosConvidados = new List<int>();

        private static Festa festa;
        private static string nomeUsuario;

        static void Main(string[] args)
        {
            festa = new Festa(
                "Reveillon 2021 - Micareta do Miranda",
                DateTime.Now,
                "Rua 25 de Junho, Champs Elyse, França");

            Introdução();
            Menu();
        }

        static void Introdução()
        {
            Console.WriteLine("Bem vindo ao realizador de festa!");
            Console.WriteLine("Primeiramente informe seu nome!");
            nomeUsuario = Console.ReadLine();
            Console.Clear();
        }

        static void Menu()
        {
            Console.WriteLine($"Olá {nomeUsuario}, Selecione uma das opções para continuar");
            Console.WriteLine("1 - Adicionar Convidado.");
            // Console.WriteLine("2 - Remover Convidado.");
            // Console.WriteLine("3 - Editar Convidado.");
            Console.WriteLine("4 - Listar Convidados pré-cadastrados.");
            // Console.WriteLine("5 - Acessar informações de seus convidado.");
            Console.WriteLine("6 - Fechar o Programa.");
            var menuSelecionado = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (menuSelecionado)
            {
                case 1:
                    AdicionarConvidados();
                    break;

                // case 2:
                //     RemoverConvidados(nomesDosConvidados);
                //     break;
                //
                // case 3:
                //     EditarConvidados(nomesDosConvidados, telefoneDosConvidados);
                //     break;

                case 4:
                    ListarConvidados();
                    break;

                // case 5:
                //     AcessarInfoDosConvidados(nomesDosConvidados, telefoneDosConvidados);
                //     break;

                case 6:
                    FinalizarPrograma();
                    break;

                default:
                    Console.Write("Você não digitou os parâmetros corretamente.");
                    Console.ReadKey();
                    break;
            }

            Menu();
        }

        static void AdicionarConvidados()
        {
            var continuarBloco = "s";

            while (continuarBloco == "s" || continuarBloco == "S")
            {
                Console.WriteLine("Informe o nome do seu convidado a ser adicionado na lista da festa.");
                var nome = Console.ReadLine();

                Console.WriteLine("Informe o telefone do seu convidado (sem ponto ou hífen) - EX: 900000000");
                var telefone = Convert.ToInt32(Console.ReadLine());

                var convidado = new Pessoa(nome, telefone);

                try
                {
                    festa.AdicionarConvidado(convidado);
                }
                catch (Exception erro)
                {
                    Console.WriteLine($"Ocorreu um erro: {erro.Message}.");
                    Console.ReadKey();
                    Console.Clear();
                }

                Console.WriteLine("Deseja adicionar mais algum convidado? (s/N)");
                continuarBloco = Console.ReadLine();
            }

            Console.Clear();
        }

        static void RemoverConvidados(List<string> nomesDosConvidados)
        {
            var ContinuarBloco = "s";

            while (ContinuarBloco == "s" || ContinuarBloco == "S")
            {
                Console.WriteLine("Informe o nome de um convidado a ser retirado da lista de sua festa!");
                var ConvidadoASerRemovido = Console.ReadLine();

                var PosicaoConvidado =
                    nomesDosConvidados.FindIndex(nomeConvidado => nomeConvidado == ConvidadoASerRemovido);
                nomesDosConvidados.RemoveAt(PosicaoConvidado);
                telefoneDosConvidados.RemoveAt(PosicaoConvidado);

                Console.WriteLine("Deseja remover mais algum convidado? (s/N)");
                ContinuarBloco = Console.ReadLine();
            }

            Console.Clear();
        }

        static void EditarConvidados(List<string> nomesDosConvidados, List<int> telefoneDosConvidados)
        {
            var ContinuarBloco = "s";

            while (ContinuarBloco == "s" || ContinuarBloco == "S")
            {
                Console.WriteLine("Informe o nome do convidado a ser editado!");
                var ConvidadoASerEditado = Console.ReadLine();

                var PosicaoConvidado =
                    nomesDosConvidados.FindIndex(nomeConvidado => nomeConvidado == ConvidadoASerEditado);

                Console.WriteLine("Você deseja editar o nome ou telefone?");
                var EdicaoDoConvidado = Console.ReadLine();

                if (EdicaoDoConvidado == "Nome" || EdicaoDoConvidado == "nome")
                {
                    Console.WriteLine("Digite o novo nome!");
                    var NovoNome = Console.ReadLine();
                    nomesDosConvidados[PosicaoConvidado] = NovoNome;
                }

                if (EdicaoDoConvidado == "Telefone" || EdicaoDoConvidado == "telefone")
                {
                    Console.WriteLine("Digite o novo telefone!");
                    var NovoTelefone = Console.ReadLine();
                    telefoneDosConvidados[PosicaoConvidado] = Convert.ToInt32(NovoTelefone);
                }

                Console.WriteLine("Deseja editar mais algum convidado? (s/N)");
                ContinuarBloco = Console.ReadLine();
            }

            Console.Clear();
        }

        static void ListarConvidados()
        {
            Console.WriteLine("Essas são as pessoas convidadas para a sua festa: ");
            foreach (Pessoa convidado in festa.Convidados)
            {
                Console.WriteLine(convidado.ObterDescricaoConvidado());
            }

            Console.WriteLine("Digite qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        static void AcessarInfoDosConvidados(List<string> nomesDosConvidados, List<int> telefoneDosConvidados)
        {
            Console.WriteLine("Essas são as pessoas convidadas para a sua festa: ");
            foreach (string nomeDoConvidado in nomesDosConvidados)
            {
                Console.WriteLine($"{nomeDoConvidado}");
            }

            var ContinuarBloco = "s";

            while (ContinuarBloco == "s" || ContinuarBloco == "S")
            {
                Console.WriteLine("Qual convidado você deseja acessar a informação do telefone?");
                var InformacaoDoConvidado = Console.ReadLine();

                var PosicaoConvidado =
                    nomesDosConvidados.FindIndex(nomeConvidado => nomeConvidado == InformacaoDoConvidado);
                Console.WriteLine(
                    $"O telefone do(a) {nomesDosConvidados[PosicaoConvidado]} é {telefoneDosConvidados[PosicaoConvidado]}");

                Console.WriteLine("Deseja verificar mais algum convidado? (s/N)");
                ContinuarBloco = Console.ReadLine();
            }

            Console.Clear();
        }

        static void FinalizarPrograma()
        {
            Console.WriteLine("Aperte qualquer tecla para finalizar o seu programa");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}