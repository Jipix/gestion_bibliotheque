using System;
using System.Collections;

namespace biblio_dll
{
	public class TriAlphabetiqueBibliothequeParAuteur : IComparer
	{

		/// <summary>
		/// Tri les livres par Auteur.
		/// </summary>
		public int Compare(object bouquin1, object bouquin2)
		{
			Livre l1 = (Livre)bouquin1;
			Livre l2 = (Livre)bouquin2;
			int resultat = l1.NomAuteur.CompareTo (l2.NomAuteur);
			return resultat;
		}
	}
}

