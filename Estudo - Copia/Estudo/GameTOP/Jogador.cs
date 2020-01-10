using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFoda 
    {
        private readonly iJogador _jogadorA;
        private readonly iJogador _jogadorB;
        public JogoFoda (iJogador JogadorA, iJogador jogadorB)
        {
            _jogadorA = JogadorA;
            _jogadorB = jogadorB;
        }

        public iJogador JogadorA => _jogadorA;

        public void IniciarJogo()
        {
            System.Console.Write (JogadorA.Corre() );
            System.Console.Write (JogadorA.Chuta() );
            System.Console.Write (JogadorA.Passe() );
            //
            System.Console.Write("\n PRÓXIMO JOGADOR \n");
            //
            System.Console.Write (_jogadorB.Corre() );
            System.Console.Write (_jogadorB.Chuta() );
            System.Console.Write (_jogadorB.Passe() );
        }
    } 
}