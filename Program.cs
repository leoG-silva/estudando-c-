using System;
using estudando_c_.Modelo;

namespace estudando_c_
{
  class Program
  {
    private static Televisao televisao;
    private static ControleRemoto controleRemoto;
    private static string nomeUsuario;
    private static int pacoteTelevisao;
    
    static void Main(string[] args)    
    { 
      Introducao();
      ReterInformacoes();
      Menu();      
    }    

    static void Introducao()
    {
      Console.WriteLine("Seja bem-vindo ao exercício 3.");
      Console.WriteLine("O exercício é um exemplo de iteração de uma televisão com um controle remoto.");
      Console.WriteLine("Durante a execução do programa, você poderá: alterar o volume e o canal, como consultar ambas as informações.");  
      Console.WriteLine("Para iniciar o programa, informe primeiramente o seu nome:");
      nomeUsuario = Console.ReadLine();
    }

    static void ReterInformacoes()
    {
       
      Console.WriteLine($"Olá {nomeUsuario}, vamos iniciar?");
      Console.WriteLine("Por padrão, sua TV é fabricada com uma variação de volume, de 0 (mudo) a 10 (volume máximo)");
      Console.WriteLine("Já a quantidade de canais de sua televisão depende do plano contratado, sendo eles: Untitled Básico e Untitled Deluxe!");   
      Console.WriteLine("O Untitled Básico possue 5 canais, enquanto o Untitled Deluxe possue incríveis 10 canais!");
      Console.WriteLine("Poderia me informar qual seu plano de televisão? (Digite 1 para Untitled Basico e 2 para o Untitled Deluxe");
      int pacoteTelevisao = Convert.ToInt32(Console.ReadLine());

      if (pacoteTelevisao == 1)
      {
         quantidadeMaximaDeCanais = 5;
      } 
      else if (pacoteTelevisao == 2)
      {
         quantidadeMaximaDeCanais = 10;
      }

      int volumeMaximo = 10;

      televisao = new Televisao(quantidadeMaximaDeCanais, volumeMaximo);  
      contoleRemoto = new ContoleRemoto();
    }

    static void Menu()
    {
      Console.WriteLine("Selecione uma das opções:");
      Console.WriteLine("1 - Subir um canal");
      Console.WriteLine("2 - Descer um canal");
      Console.WriteLine("3 - Aumentar volume");
      Console.WriteLine("4 - Diminuir volume");
      Console.WriteLine("5 - Consultar informação atuais de volume de canal");
      Console.WriteLine("6 - Desligar TV - (Fechar o programa");
      int menuControleRemoto = Convert.ToInt32(Console.ReadLine());

      switch (menuControleRemoto)
      {
        case 1:
          controleRemoto.SubirCanal();
           break;

        case 2: 
          controleRemoto.DescerCanal();
          break;

        case 3: 
          controleRemoto.AumentarVolume();
          break;

        case 4: 
          controleRemoto.DiminuirVolume();
          break;

        case 5: 
          Console.WriteLine(controleRemoto.ConsultarInformacoes());
          break;

        case 6: 
          controleRemoto.DesligarTelevisao();
          break;

        default: 
          Console.Write("Você digitou nenhuma opção válida... Aperte qualquer botão para continuar.");
          Console.ReadKey(); 
          break;
      }
            
     Menu();
    }
  }
}
