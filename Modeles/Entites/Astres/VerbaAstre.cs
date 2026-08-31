using Modeles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modeles.Entites.Astres
{
    public class VerbaAstre : Astre, ICommunication
    {
        public VerbaAstre(string Nom, int PositionX, int PositionY, TypeEntite Type) : base(Nom, PositionX, PositionY, Type)
        {
        }

        public void Parler(string message)
        {
            string messageEmbellit = "✨🌟" + message + "✨🌟";
        }
    }
}