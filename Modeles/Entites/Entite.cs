using System;
using System.Collections.Generic;
using System.Text;

public enum TypeEntite { Astre, Vaisseau };

namespace Modeles.Entites
{
    public class Entite
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

        protected string GetNom => _nom;
        public int GetPositionX => _positionX;
        public int GetPositionY => _positionY;
        public void SetPositionX(int PositionX)
        {
            _positionX = positionX;
        }
        public void SetPositionY(int PositionY)
        {
            _positionY = positionY;
        }
    }
}
