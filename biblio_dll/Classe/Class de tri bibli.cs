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

	public class TriAlphabetiqueBibliothequeParDessinateur : IComparer
	{

		/// <summary>
		/// Tri les livres par dessinateur.
		/// </summary>
		public int Compare(object bouquin1, object bouquin2)
		{
			Livre l1 = (Livre)bouquin1;
			Livre l2 = (Livre)bouquin2;
			if (l1.NomDessinateurCouv != null&&l2.NomDessinateurCouv!=null) 
			{
				int resultat = l1.NomDessinateurCouv.CompareTo (l2.NomDessinateurCouv);
				return resultat;
			} 
			else
			{
				int resultat = l1.NomAuteur.CompareTo (l2.NomAuteur);
				return resultat;
			}
		}
	}

	public class TriAlphabetiqueBibliothequeParEditeur : IComparer
	{

		/// <summary>
		/// Tri les livres par Editeur.
		/// </summary>
		public int Compare(object bouquin1, object bouquin2)
		{
			Livre l1 = (Livre)bouquin1;
			Livre l2 = (Livre)bouquin2;
			if (l1.Edit != null&&l2.Edit!=null) 
			{
				int resultat = l1.Edit.CompareTo (l2.Edit);
				return resultat;
			} 
			else
			{
				int resultat = l1.NomAuteur.CompareTo (l2.NomAuteur);
				return resultat;
			}
		}
	}

	public class TriAlphabetiqueBibliothequeParCollection : IComparer
	{

		/// <summary>
		/// Tri les livres par Collection.
		/// </summary>
		public int Compare(object bouquin1, object bouquin2)
		{
			Livre l1 = (Livre)bouquin1;
			Livre l2 = (Livre)bouquin2;
			if (l1.Coll != null && l2.Coll !=null) 
			{
				int resultat = l1.Coll.CompareTo (l2.Coll);
				return resultat;
			} 
			else
			{
				int resultat = l1.NomAuteur.CompareTo (l2.NomAuteur);
				return resultat;
			}
		}
	}

	public class TriAlphabetiqueBibliothequeParTraducteur : IComparer
	{

		/// <summary>
		/// Tri les livres par Traducteur.
		/// </summary>
		public int Compare(object bouquin1, object bouquin2)
		{
			Livre l1 = (Livre)bouquin1;
			Livre l2 = (Livre)bouquin2;
			if (l1.NomTraducteur != null && l2.NomTraducteur !=null) 
			{
				int resultat = l1.NomTraducteur.CompareTo (l2.NomTraducteur);
				return resultat;
			} 
			else
			{
				int resultat = l1.NomAuteur.CompareTo (l2.NomAuteur);
				return resultat;
			}
		}
	}

	public class TriAlphabetiqueBibliothequeParNationalitéAuteur : IComparer
	{

		/// <summary>
		/// Tri les livres par Nationalité d'auteur.
		/// </summary>
		public int Compare(object bouquin1, object bouquin2)
		{
			Livre l1 = (Livre)bouquin1;
			Livre l2 = (Livre)bouquin2;
			if (l1.NationalitéAuteur != null && l2.NationalitéAuteur !=null) 
			{
				int resultat = l1.NationalitéAuteur.CompareTo (l2.NationalitéAuteur);
				return resultat;
			} 
			else
			{
				int resultat = l1.NomAuteur.CompareTo (l2.NomAuteur);
				return resultat;
			}
		}
	}

	public class TriAlphabetiqueBibliothequeParGenre : IComparer
	{

		/// <summary>
		/// Tri les livres par Cycle.
		/// </summary>
		public int Compare(object bouquin1, object bouquin2)
		{
			Livre l1 = (Livre)bouquin1;
			Livre l2 = (Livre)bouquin2;
			if (l1.Genre != null&&l2.Genre!=null) 
			{
				int resultat = l1.Genre.CompareTo (l2.Genre);
				return resultat;
			} 
			else
			{
				int resultat = l1.NomAuteur.CompareTo (l2.NomAuteur);
				return resultat;
			}
		}
	}

	public class TriAlphabetiqueBibliothequeParLangue : IComparer
	{

		/// <summary>
		/// Tri les livres par Cycle.
		/// </summary>
		public int Compare(object bouquin1, object bouquin2)
		{
			Livre l1 = (Livre)bouquin1;
			Livre l2 = (Livre)bouquin2;
			if (l1.Langue != null && l2.Langue !=null) 
			{
				int resultat = l1.Langue.CompareTo (l2.Langue);
				return resultat;
			} 
			else
			{
				int resultat = l1.NomAuteur.CompareTo (l2.NomAuteur);
				return resultat;
			}
		}
	}

	public class TriAlphabetiqueBibliothequeParEditionOriginale : IComparer
	{

		/// <summary>
		/// Tri les livres par edition orignale.
		/// </summary>
		public int Compare(object bouquin1, object bouquin2)
		{
			Livre l1 = (Livre)bouquin1;
			Livre l2 = (Livre)bouquin2;
			if (l1.EditionOriginale != null && l2.EditionOriginale !=null) 
			{
				int resultat = l1.NomAuteur.CompareTo (l2.NomAuteur);
				return resultat;
			} 
			else
			{
				int resultat = l1.NomAuteur.CompareTo (l2.NomAuteur);
				return resultat;
			}
		}
	}

	public class TriChronologiqueBibliothequeParDateDeParutionVF : IComparer
	{

		/// <summary>
		/// Tri les livres par Date de parution VF.
		/// </summary>
		public int Compare(object bouquin1, object bouquin2)
		{
			Livre l1 = (Livre)bouquin1;
			Livre l2 = (Livre)bouquin2;
			if (l1.DateDeParutionVF != null && l2.DateDeParutionVF !=null) 
			{
				int resultat = l1.DateDeParutionVF.CompareTo (l2.DateDeParutionVF);
				return resultat;
			} 
			else
			{
				int resultat = l1.NomAuteur.CompareTo (l2.NomAuteur);
				return resultat;
			}
		}
	}

	public class TriChronologiqueBibliothequeParDateDeParutionVO : IComparer
	{

		/// <summary>
		/// Tri les livres par Date de parution VO.
		/// </summary>
		public int Compare(object bouquin1, object bouquin2)
		{
			Livre l1 = (Livre)bouquin1;
			Livre l2 = (Livre)bouquin2;
			if (l1.DateDeParutionVO != null && l2.DateDeParutionVO !=null) 
			{
				int resultat = l1.DateDeParutionVF.CompareTo (l2.DateDeParutionVF);
				return resultat;
			} 
			if (l1.DateDeParutionVO != null && l2.DateDeParutionVF !=null) 
			{
				int resultat = l1.DateDeParutionVO.CompareTo (l2.DateDeParutionVF);
				return resultat;
			} 
			if (l1.DateDeParutionVF != null && l2.DateDeParutionVF !=null) 
			{
				int resultat = l1.DateDeParutionVF.CompareTo (l2.DateDeParutionVF);
				return resultat;
			} 
			if (l1.DateDeParutionVF != null && l2.DateDeParutionVO !=null) 
			{
				int resultat = l1.DateDeParutionVF.CompareTo (l2.DateDeParutionVO);
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

