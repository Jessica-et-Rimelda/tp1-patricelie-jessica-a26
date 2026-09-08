namespace Modeles.Entites
{
    public abstract class Entite
    {
        public string Nom { get; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public Entite(string Nom, int PositionX, int PositionY)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(Nom);
            this.Nom = Nom;
            this.PositionX = PositionX;
            this.PositionY = PositionY;
        }
    }
}
