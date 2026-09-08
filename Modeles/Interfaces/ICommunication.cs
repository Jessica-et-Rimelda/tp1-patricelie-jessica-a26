namespace Modeles.Interfaces;

/// <summary>
/// Représente une entité capable de communiquer.
/// </summary>
public interface ICommunication
{
    /// <summary>
    /// Communique un message.
    /// </summary>
    /// <param name="message">Message à communiquer.</param>
    /// <returns>Message transformé.</returns>
    string Communiquer(string message);
}