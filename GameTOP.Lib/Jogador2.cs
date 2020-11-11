using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradona está a chutar  \n";
        }

        public string Corre()
        {
            return "Maradona está a correr  \n";
        }

        public string Passe()
        {
            return "Maradona está a passar  \n";
        }
    }
}
