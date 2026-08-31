using Modeles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modeles.Entites.Astres
{
    public class NovaSolara : Astre, IDeplacement
    {
        const int VitesseDeplacement = 1;
        private double _luminosite;
        private int _deplacementX;
        private int _deplacementY;
        //public static int NbDeplacement { get; private set; }

        public NovaSolara(string Nom, int PositionX, int PositionY, TypeEntite Type, double Luminosite, int DeplacementX, int DeplacementY) : base(Nom, PositionX, PositionY, Type)
        {
            _deplacementX = DeplacementX;
            _deplacementY = DeplacementY;
            _luminosite = Luminosite;
        }
        public double GetLuminosite => _luminosite;

        public void SetLuminosite(double Luminosite)
        {
            _luminosite = Luminosite;
        }

       /* public void Deplacement()
        {
            if(GetLuminosite < 1)
            {
                return;
            }
            else
            {
                NbDeplacement++;
                SetPositionX(_deplacementX * _vitesseDeplacement + GetPositionX);
                SetPositionY(_deplacementY * _vitesseDeplacement + GetPositionY);
                if (NbDeplacement % 3 == 0)
                {
                    SetLuminosite(GetLuminosite * 0.2 + GetLuminosite);
                }
            }
        }*/
    }
}
