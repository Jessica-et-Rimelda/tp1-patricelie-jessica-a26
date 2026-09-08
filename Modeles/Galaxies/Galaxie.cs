using Modeles.Entites;

namespace Modeles.Galaxies;

/// <summary>
/// Représente une galaxie contenant différentes entités.
/// </summary>
public class Galaxie<T> where T : Entite
{
    /// <summary>La Liste des entités de la galaxie.</summary>
    public List<T> Entites { get; set; } = new();


    /// <summary>
    /// Ajoute une entité dans la galaxie.
    /// </summary>
    /// <param name="entite">Entité à ajouter.</param>
    public void AjouterEntite(T entite) =>
        Entites.Add(entite);

    /// <summary>
    /// Trouve l'entité la plus proche selon la distance de Manhattan.
    /// </summary>
    /// <param name="reference">Entité utilisée comme point de référence.</param>
    /// <returns>L'entité la plus proche.</returns>
    public T? TrouverEntitePlusProche(T reference)
    {
        T? plusProche = null;
        var plusPetiteDistance = int.MaxValue;

        foreach (var entite in Entites)
        {
            if (entite == reference)
                continue;

            var distance =  Math.Abs(entite.PositionX - reference.PositionX) + Math.Abs(entite.PositionY - reference.PositionY);

            if (distance >= plusPetiteDistance)
                continue;

            plusPetiteDistance = distance;
            plusProche = entite;
        }

        return plusProche;
    }
}
