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
                    // EditarConvidados();
                    break;

                case 4:
                    ListarConvidados(nomesDosConvidados);                    
                    break;

                case 5:
                    // AcessarInfoDosConvidados();
                    break;

                case 6:
                    FinalizarPrograma();
                    break; 

                default:
                    Console.Write("Você não digitou nenhum dos parãmetros corretamente.");
                    Console.ReadKey();
                    break;                               
            }   
            
            Menu(nomeDoUsuario);                               
        }

        static void MenuPrograma (string nomeDoUsuario) {}

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
            nomesDosConvidados.Remove(Console.ReadLine());
            
            Console.WriteLine("Deseja remover mais algum convidado? (s/N)");
            ContinuarBloco = Console.ReadLine();
            }
        }
        
        // EditarConvidados();   

        static void ListarConvidados(List<string> nomesDosConvidados) {
            Console.WriteLine("Essas são as pessoas convidadas para a sua festa: ");
            foreach(string nomeDoConvidado in nomesDosConvidados)  {
               Console.WriteLine($"{nomeDoConvidado}");                
            };
            Console.WriteLine("Digite qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        
        //AcessarInfoDosConvidados

        static void FinalizarPrograma() {
            Console.WriteLine("Aperte qualquer tecla para finalizar o seu programa");
            Console.ReadKey();
            Environment.Exit(0);
        }     
    }
}