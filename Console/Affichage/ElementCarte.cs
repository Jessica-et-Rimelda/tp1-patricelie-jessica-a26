using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace AppConsole.Affichage
{
    public class ElementCarte
    {
        public string Nom { get; }
        public string Symbole { get; }
        public int X { get; set; }
        public int Y { get; set; }

        public ElementCarte(string Nom, string Symbole, int X, int Y)
        {
            ArgumentNullException.ThrowIfNullOrWhiteSpace(Nom);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(Symbole);
            this.Nom = Nom;
            this.Symbole = Symbole;
            this.X = X;
            this.Y = Y;
        }
    }
}
