// <copyright file="ICommunication.cs" company="CSTJEAN">
// Jessica Karelle Fanguem Tchikapa
// Patricelie Rimelda Njoh Ngueng
// </copyright>

namespace Modeles.Interfaces;

/// <summary>
/// Représente la capacité de communiquer d'une entité.
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
