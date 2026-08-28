using System;
using System.Collections.Generic;
using System.Text;

namespace AppConsole.Modele
{
    public enum TypeEntite  {Astre, Vaisseau};
    public abstract class Entite
    {
        private string _nom;
        private int _positionX;
        private int _positionY;
        private TypeEntite _type;

        public Entite(string Nom, int PositionX, int PositionY, TypeEntite Type)
        {
            ArgumentNullException.ThrowIfNullOrWhiteSpace(Nom);
            _nom = Nom;
            _positionX = PositionX;
            _positionY = PositionY;
            _type = Type;

        }

        protected string getNom => _nom;
        protected int getPositionX => _positionX;
        protected int getPositionY => _positionY;

        protected void setPositionX(string PositionX)
        {
            try
            {
                int.TryParse(PositionX, out int resutat);
                _positionX = resutat;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
