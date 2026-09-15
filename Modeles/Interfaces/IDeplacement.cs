// <copyright file="IDeplacement.cs" company="PlaceholderCompany" author="Jessica Karelle Fanguem Tchikapa && Patricelie Rimelda Njoh Ngueng">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Modeles.Interfaces;

/// <summary>
/// Représente une entité capable de se déplacer.
/// </summary>
public interface IDeplacement
{
    /// <summary>
    /// Déplace l'entité selon les valeurs X et Y reçues.
    /// </summary>
    /// <param name="x">Déplacement horizontal.</param>
    /// <param name="y">Déplacement vertical.</param>
    void Deplacer(int x, int y);
}