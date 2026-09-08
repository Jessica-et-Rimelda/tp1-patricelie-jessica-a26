using Modeles.Interfaces;
using System.Globalization;
using System.Text;

namespace Modeles.Entites.Vaisseaux;

/// <summary>
/// Représente un vaisseau capable de communiquer de façon cryptée.
/// </summary>
public class CryptoVaisseau : Vaisseau, ICommunication
{
    private const string Alphabet =
        "abcdefghijklmnopqrstuvwxyz";

    private const string AlphabetCrypte =
        "cjdoywhktgvfzelxquapmbsnri";

    ///<summary> Initializes a new instance of the <see cref="CryptoVaisseau"/> class.
    /// Constructeur. 
    /// </summary>
    /// <param name="Nom">Le nom de l'entite.</param>/// 
    /// <param name="PositionX">La position sur l'axe des x.</param>/// 
    /// <param name="PositionY">La position sur l'axe des y.</param>/// 
    /// <param name="Vitesse">La luminosité de l'astre.</param>/// 
    public CryptoVaisseau(
        string Nom,
        int PositionX,
        int PositionY,
        int Vitesse = 3)
        : base(Nom, PositionX, PositionY, Vitesse)
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
                continue;

            var caractereCrypte = AlphabetCrypte[index];

            resultat[i] = char.IsUpper(caractere)
                ? char.ToUpper(caractereCrypte)
                : caractereCrypte;
        }

        return new string(resultat);
    }
}