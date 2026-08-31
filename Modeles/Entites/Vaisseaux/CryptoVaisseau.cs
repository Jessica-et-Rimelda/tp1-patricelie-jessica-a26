using Modeles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modeles.Entites.Vaisseaux
{
    public class CryptoVaisseau : Vaisseau, ICommunication
    {
        char[] lettres = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        char[] codes = { 'c', 'j', 'd', 'o', 'y', 'w', 'h', 'k', 't', 'g', 'v', 'f', 'z', 'e', 'l', 'x', 'q', 'u', 'a', 'p', 'm', 'b', 's', 'n', 'r', 'i' };
        public CryptoVaisseau(string Nom, int PositionX, int PositionY, TypeEntite Type, int VitesseDeplacement = 3, int DeplacementX, int DeplacementY) :
            base(Nom, PositionX, PositionY, Type, VitesseDeplacement, DeplacementX, DeplacementY)
        {
        }

        public void Parler(string message)
        {
            string messageCode = "";
            foreach (char lettre in message)
            {
                for (int i = 0; i < lettres.Length; i++)
                {
                    if (lettres[i] == lettre.tolower())
                    {
                        messageCode += lettre;
                    }
                }

            }
        }
    }
}
