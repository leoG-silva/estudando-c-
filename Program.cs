using System;
using System.Collections.Generic;

namespace estudando_c_
{
    class Program
    {

        static List<string> nomesDosConvidados = new List<string>();
        static List<int> telefoneDosConvidados = new List<int>();
        static void Main(string[] args) {   
            var nomeDoUsuario = Introdução();            
            Menu(nomeDoUsuario);                                
        }

        static string Introdução() {  
            Console.WriteLine("Bem vindo ao realizador de festa!");
            Console.WriteLine("Primeiramente informe seu nome!");
            string nomeDoUsuario = Console.ReadLine();
            Console.Clear(); 

            return nomeDoUsuario;           
        }

        static void Menu(string nomeDoUsuario) {     
                                                       
            Console.WriteLine($"Olá {nomeDoUsuario}, Selecione uma das opções para continuar");
            Console.WriteLine("1 - Adicionar Convidado.");
            Console.WriteLine("2 - Remover Convidado.");
            Console.WriteLine("3 - Editar Convidado.");
            Console.WriteLine("4 - Listar Convidados pré-cadastrados.");
            Console.WriteLine("5 - Acessar informações de seus convidado.");
            Console.WriteLine("6 - Fechar o Programa.");
            int MenuListaDeConvidados = Convert.ToInt32(Console.ReadLine()); 
            Console.Clear(); 
                                         
                    switch (MenuListaDeConvidados) {
                case 1:
                    AdicionarConvidados(nomesDosConvidados, telefoneDosConvidados);                                          
                    break;

                case 2:
                    RemoverConvidados(nomesDosConvidados);                                     
                    break;

                case 3:
                    EditarConvidados(nomesDosConvidados, telefoneDosConvidados);
                    break;

                case 4:
                    ListarConvidados(nomesDosConvidados);                    
                    break;

                case 5:
                    AcessarInfoDosConvidados(nomesDosConvidados, telefoneDosConvidados);
                    break;

                case 6:
                    FinalizarPrograma();
                    break; 

                default:
                    Console.Write("Você digitou nenhum dos parãmetros corretamente.");
                    Console.ReadKey();
                    break;                               
            }   
            
            Menu(nomeDoUsuario);                               
        }
        
        static void AdicionarConvidados(List<string> nomesDosConvidados, List<int> telefoneDosConvidados) {
            var ContinuarBloco = "s";               
                                   
            while (ContinuarBloco == "s" || ContinuarBloco == "S") {
                Console.WriteLine("Informe o nome de seus convidados a serem adicionados na lista da festa.");
                nomesDosConvidados.Add(Console.ReadLine());
                        
                Console.WriteLine("O telefone do seu usuário (sem ponto ou hífen) - EX: 900000000");
                telefoneDosConvidados.Add(Convert.ToInt32(Console.ReadLine()));                        

                Console.WriteLine("Deseja adicionar mais algum convidado? (s/N)");
                ContinuarBloco = Console.ReadLine();          
            }

            Console.Clear();                                    
        }

        static void RemoverConvidados(List<string> nomesDosConvidados) {
            var ContinuarBloco = "s";
            
            while (ContinuarBloco == "s" || ContinuarBloco == "S") {
            Console.WriteLine("Informe o nome de um convidado a ser retirado da lista de sua festa!");
            var ConvidadoASerRemovido = Console.ReadLine();             
            
            var PosicaoConvidado = nomesDosConvidados.FindIndex(nomeConvidado => nomeConvidado == ConvidadoASerRemovido);
            nomesDosConvidados.RemoveAt(PosicaoConvidado);
            telefoneDosConvidados.RemoveAt(PosicaoConvidado);

            Console.WriteLine("Deseja remover mais algum convidado? (s/N)");
            ContinuarBloco = Console.ReadLine();
            }

                Console.Clear();

        }
        
        static void EditarConvidados(List<string> nomesDosConvidados, List<int> telefoneDosConvidados) {
            var ContinuarBloco = "s";
            
            while (ContinuarBloco == "s" || ContinuarBloco == "S") {
                Console.WriteLine("Informe o nome do convidado a ser editado!");
                var ConvidadoASerEditado = Console.ReadLine();

                var PosicaoConvidado = nomesDosConvidados.FindIndex(nomeConvidado => nomeConvidado == ConvidadoASerEditado);

                Console.WriteLine("Você deseja editar o nome ou telefone?"); 
                var EdicaoDoConvidado = Console.ReadLine();

                if (EdicaoDoConvidado == "Nome" || EdicaoDoConvidado == "nome") {
                    Console.WriteLine("Digite o novo nome!");
                    var NovoNome = Console.ReadLine();
                    nomesDosConvidados[PosicaoConvidado] = NovoNome;                 

                } if (EdicaoDoConvidado == "Telefone" || EdicaoDoConvidado == "telefone") {
                    Console.WriteLine("Digite o novo telefone!");
                    var NovoTelefone = Console.ReadLine();
                    telefoneDosConvidados[PosicaoConvidado] = Convert.ToInt32(NovoTelefone);
                }

                Console.WriteLine("Deseja editar mais algum convidado? (s/N)");
                ContinuarBloco = Console.ReadLine();
            }

            Console.Clear();

        }   

        static void ListarConvidados(List<string> nomesDosConvidados) {
            Console.WriteLine("Essas são as pessoas convidadas para a sua festa: ");
            foreach(string nomeDoConvidado in nomesDosConvidados)  {
               Console.WriteLine($"{nomeDoConvidado}");                
            };
            Console.WriteLine("Digite qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        
        static void AcessarInfoDosConvidados(List<string> nomesDosConvidados, List<int> telefoneDosConvidados) {
            Console.WriteLine("Essas são as pessoas convidadas para a sua festa: ");
            foreach(string nomeDoConvidado in nomesDosConvidados) {
                Console.WriteLine($"{nomeDoConvidado}");
            }
                        
            var ContinuarBloco = "s";
            
            while (ContinuarBloco == "s" || ContinuarBloco == "S") {
                Console.WriteLine("Qual convidado você deseja acessar a informação do telefone?");
                var InformacaoDoConvidado = Console.ReadLine();

                var PosicaoConvidado = nomesDosConvidados.FindIndex(nomeConvidado => nomeConvidado == InformacaoDoConvidado);
                Console.WriteLine($"O telefone do(a) {nomesDosConvidados[PosicaoConvidado]} é {telefoneDosConvidados[PosicaoConvidado]}");
                
                Console.WriteLine("Deseja verificar mais algum convidado? (s/N)");
                ContinuarBloco = Console.ReadLine();                
            }

            Console.Clear();

        }

        static void FinalizarPrograma() {
            Console.WriteLine("Aperte qualquer tecla para finalizar o seu programa");
            Console.ReadKey();
            Environment.Exit(0);
        }     
    }
}