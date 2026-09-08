using Modeles.Interfaces;

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
        //* Chaque caractère est traité une seule fois.

        var resultat = message.ToCharArray();

        for (var i = 0; i < resultat.Length; i++)
        {
            var caractere = resultat[i];
            var lettre = char.ToLower(caractere);

            var index = lettre == 'à'
                ? 0
                : Alphabet.IndexOf(lettre);

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