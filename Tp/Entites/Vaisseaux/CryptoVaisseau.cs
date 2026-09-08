using Modeles.Interfaces;

namespace Modeles.Entites.Vaisseaux
{
    public class CryptoVaisseau:Vaisseau, ICommunication
    {
        public CryptoVaisseau(string Nom, int PositionX, int PositionY, int Vitesse) : base(Nom, PositionX, PositionY, Vitesse)
        {

        }

        public string Communiquer(string message)
        {
            string messageACommuniquer = "";
            return messageACommuniquer;
        }
    }
}
