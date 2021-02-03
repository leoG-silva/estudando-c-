using System;


namespace estudando_c_.Modelo
{
    public class ControleRemoto 
    {
        public Televisao televisao;

        public ControleRemoto() {}

        public void SubirCanal()
        {
            if (televisao.CanalAtual < 10)
            {
                televisao.CanalAtual++;
                Console.WriteLine("Voc� subiu um canal");
            }
            else
            {
                Console.WriteLine("Voc� est� no canal de maior valor do seu pacote!");
            }
        }

        public void DescerCanal()
        {
            if (televisao.CanalAtual > 0)
            {
                televisao.CanalAtual--;
                Console.WriteLine("Voc� desceu um canal");
            }
            else
            {
                Console.WriteLine("Voc� est� no canal de menor valor!");
            }
        }

        public void AumentarVolume()
        {
            if (televisao.VolumeAtual < televisao.VolumeMaximo)
            {
                televisao.VolumeAtual++;
                Console.WriteLine("Voc� aumentou um ponto do volume!");
            }
            else
            {
                Console.WriteLine("VOLUME M�XIMO!");
            }
        }

        public void DiminuirVolume()
        {
            if (televisao.VolumeAtual > 0)
            {
                televisao.VolumeAtual--;
                Console.WriteLine("Voc� diminuiu um ponto do volume!");
            }
            else
            {
                Console.WriteLine("MUDO!");
            }
        }

        public string ConsultarInformacoes()
        {
            return $"Voc� est� no canal: {televisao.CanalAtual}, no volume {televisao.VolumeAtual}";
        }

        public void DesligarTelevisao()
        {
            Console.WriteLine("Aperto o bot�o POWER para desligar sua televis�o!");
            Console.ReadKey();
            Environment.Exit(0);
        }
    
    }
}    
