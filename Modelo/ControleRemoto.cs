using System;


namespace estudando_c_.Modelo
{
    public class ControleRemoto 
    {
        public Televisao televisao;

        public ControleRemoto(Televisao televisao) 
        {
            this.televisao = televisao;
        }

        public void SubirCanal()
        {
            if (televisao.CanalAtual < televisao.QuantidadeMaximaDeCanais)
            {
                televisao.CanalAtual++;
                Console.WriteLine("Você subiu um canal");
            }
            else
            {
                Console.WriteLine("Você está no canal de maior valor do seu pacote!");
            }
        }

        public void DescerCanal()
        {
            if (televisao.CanalAtual > 0)
            {
                televisao.CanalAtual--;
                Console.WriteLine("Você desceu um canal");
            }
            else
            {
                Console.WriteLine("Você está no canal de menor valor!");
            }
        }

        public void AumentarVolume()
        {
            if (televisao.VolumeAtual < televisao.VolumeMaximo)
            {
                televisao.VolumeAtual++;
                Console.WriteLine("Você aumentou um ponto do volume!");
            }
            else
            {
                Console.WriteLine("VOLUME MÁXIMO!");
            }
        }

        public void DiminuirVolume()
        {
            if (televisao.VolumeAtual > 0)
            {
                televisao.VolumeAtual--;
                Console.WriteLine("Você diminuiu um ponto do volume!");
            }
            else
            {
                Console.WriteLine("MUDO!");
            }
        }

        public string ConsultarInformacoes()
        {
            return $"Você está no canal: {televisao.CanalAtual}, no volume {televisao.VolumeAtual}";
        }

        public void DesligarTelevisao()
        {
            Console.WriteLine("Aperto o botão POWER para desligar sua televisão!");
            Console.ReadKey();
            Environment.Exit(0);
        }
    
    }
}    
