// <copyright file="CryptoVaisseau.cs" company="CSTJEAN">
// Jessica Karelle Fanguem Tchikapa
// Patricelie Rimelda Njoh Ngueng
// </copyright>

namespace Modeles.Entites.Vaisseaux;

using Modeles.Interfaces;
using System.Globalization;
using System.Text;

/// <summary>
/// Représente un vaisseau capable de communiquer de façon cryptée.
/// </summary>
public class CryptoVaisseau : Vaisseau, ICommunication
{
    private const string Alphabet =
        "abcdefghijklmnopqrstuvwxyz";

    private const string AlphabetCrypte =
        "cjdoywhktgvfzelxquapmbsnri";

    /// <summary> Initializes a new instance of the <see cref="CryptoVaisseau"/> class.
    /// Constructeur.
    /// </summary>
    /// <param name="nom">Le nom de l'entite.</param>///
    /// <param name="positionX">La position sur l'axe des x.</param>///
    /// <param name="positionY">La position sur l'axe des y.</param>///
    /// <param name="vitesse">La luminosité de l'astre.</param>///
    public CryptoVaisseau(
        string nom,
        int positionX,
        int positionY,
        int vitesse = 3)
        : base(nom, positionX, positionY, vitesse)
    {
    }

    /// <summary>
    /// Crypte le message.
    /// </summary>
    /// <param name="message">Message à crypter.</param>
    /// <returns>Message crypté.</returns>
    public string Communiquer(string message)
    {
        string messageSansAccent = new string(message.Normalize(NormalizationForm.FormD)
       .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
       .ToArray());

        var resultat = messageSansAccent.ToCharArray();

        for (var i = 0; i < resultat.Length; i++)
        {
            var caractere = resultat[i];
            var lettre = char.ToLower(caractere);

            var index = Alphabet.IndexOf(lettre);

            if (index == -1)
            {
                continue;
            }

            var caractereCrypte = AlphabetCrypte[index];

            resultat[i] = char.IsUpper(caractere)
                ? char.ToUpper(caractereCrypte)
                : caractereCrypte;
        }

        return new string(resultat);
    }
}