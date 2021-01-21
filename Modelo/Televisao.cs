using System;

namespace estudando_c_.Modelo
{
    public class Televisao
    {
        public int CanalAtual;
        public int QuantidadeMaximaDeCanais;
        public int VolumeAtual;
        public int VolumeMaximo;


        public Televisao(int quantidadeMaximaDeCanais, int volumeMaximo)
        {
            QuantidadeMaximaDeCanais = quantidadeMaximaDeCanais;
            VolumeMaximo = volumeMaximo;
        }
    }
}