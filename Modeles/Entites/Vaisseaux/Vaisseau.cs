using Modeles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modeles.Entites.Vaisseaux
{
    public class Vaisseau : Entite, IDeplacement
    {
        private int _vitesseDeplacement;
        private int _deplacementX;
        private int _deplacementY;

        public Vaisseau(string Nom, int PositionX, int PositionY, TypeEntite Type, int VitesseDeplacement, int DeplacementX, int DeplacementY) : base(Nom, PositionX, PositionY, Type)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(VitesseDeplacement);
            _vitesseDeplacement = VitesseDeplacement;
            _deplacementX = DeplacementX;
            _deplacementY = DeplacementY;
        }

        public void Deplacement()
        {
            SetPositionX(_deplacementX * _vitesseDeplacement + GetPositionX);
            SetPositionY(_deplacementY * _vitesseDeplacement + GetPositionY);
        }
    }
}
