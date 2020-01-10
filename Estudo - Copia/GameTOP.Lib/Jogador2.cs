using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Samuel esta chutando \n";
        }

        public string Corre()
        {
            return "Samuel esta correndo \n";
        }

        public string Passe()
        {
            return "Samuel esta passando \n";
        }
    }
}