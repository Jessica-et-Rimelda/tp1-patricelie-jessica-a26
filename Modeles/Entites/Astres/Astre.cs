using Modeles.Interfaces;

namespace Modeles.Entites.Astres
{
    public class Astre : Entite
    {
        public Astre(string Nom, int PositionX, int PositionY, TypeEntite Type) : base(Nom, PositionX, PositionY, Type)
        {
        }
    }
}
