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

	public class TriAlphabetiqueBibliothequeParTitre : IComparer
	{

		/// <summary>
		/// Tri les livres par titre.
		/// </summary>
		public int Compare(object bouquin1, object bouquin2)
		{
			Livre l1 = (Livre)bouquin1;
			Livre l2 = (Livre)bouquin2;
			int resultat = l1.Titre.CompareTo (l2.Titre);
			return resultat;
		}
	}

	public class TriAlphabetiqueBibliothequeParCycle : IComparer
	{

		/// <summary>
		/// Tri les livres par Cycle.
		/// </summary>
		public int Compare(object bouquin1, object bouquin2)
		{
			Livre l1 = (Livre)bouquin1;
			Livre l2 = (Livre)bouquin2;
			if (l1.Cycle != null&&l2.Cycle!=null) 
			{
				int resultat = l1.Cycle.CompareTo (l2.Cycle);
				return resultat;
			} 
			else
			{
				int resultat = l1.NomAuteur.CompareTo (l2.NomAuteur);
				return resultat;
			}
		}
		}
	}

