namespace AppConsole.Interactions;

/// <summary>
/// Gère le changement d'entité sélectionnée.
/// </summary>
public class SelectionEntite
{
    /// <summary>
    /// Passe à l'entité suivante.
    /// </summary>
    /// <param name="index">Index actuel.</param>
    /// <param name="nombreEntites">Nombre total d'entités.</param>
    /// <returns>Nouvel index.</returns>
    public int Suivante(int index, int nombreEntites) =>(index + 1) % nombreEntites;
}