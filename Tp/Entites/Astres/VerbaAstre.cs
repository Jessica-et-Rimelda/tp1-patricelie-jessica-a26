using Modeles.Interfaces;

namespace Modeles.Entites.Astres
{
    public class VerbaAstre:Astre, ICommunication
    {
        public VerbaAstre(string Nom, int PositionX, int PositionY) : base(Nom, PositionX, PositionY)
        {

        }

        public string Communiquer(string message)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            string messageACommuniquer = $"✨� {message} 🌟✨";
            return messageACommuniquer;
        }
    }
}
