using System;
using System.Collections;

namespace biblio_dll
{

	/// <summary>
	/// Objet bibliotheque.
	/// </summary>
	public class Bibliotheque
	{
		public ArrayList Bibli = new ArrayList ();

		/// <summary>
		///  Ctor Ajout d'un livre dans la bibliotheque.
		/// </summary>
		public Bibliotheque ()
		{
		}

		/// <summary>
		/// Ajouter un livre.
		/// </summary>
		public void AjouterUnLivre (object bouquin)
		{
			bool i=Bibli.Contains (bouquin);
			if (i == false) 
			{
				Bibli.Add (bouquin);
			} 
			else 
			{
				Console.WriteLine ("Le Livre est déjà présent dans votre bibliothéque");
			}
		}

		/// <summary>
		/// Affiche ma bibli.
		/// </summary>
		public void AfficheMaBibliothéque ()
		{

			for (int i = 0; i < Bibli.Count; i++)
			{
				Livre bouquin = (Livre)Bibli [i];
				bouquin.Affiche ();
				Console.WriteLine ();
			} 
		}

		/// <summary>
		/// Efface un livre.
		/// </summary>
		public void EffaceUnLivre (object bouquin)
		{
			bool i=Bibli.Contains (bouquin);
			if (i == true) 
			{
				Bibli.Remove (bouquin);
			} 
			else 
			{
				Console.WriteLine ("Le Livre recherché n'est pas présent dans la bibliothéque");
			}
		}	
			
		/// <summary>
		/// Recherche un livre.
		/// </summary>
		public void RechercheUnLivre (object bouquin)
		{
			bool i=Bibli.Contains (bouquin);
			if (i == true) 
			{
				Livre bouquinRechercher=(Livre)bouquin;
				bouquinRechercher.Affiche ();
			} 
			else 
			{
				Console.WriteLine ("Le Livre n'est pas présent dans votre bibliothéque");
			}
		}

		/// <summary>
		/// Compte les livres
		/// </summary>
		public void NombreDeLivre()
		{
			Console.WriteLine ("Votre bibliothéque contient " + Bibli.Count + " Livres");
		}

		/// <summary>
		/// Tri les Livres par ordres alphabétiques d'auteur.
		/// </summary>
		public void TriParAuteurAlphabétique ()
		{
			Bibli.Sort (new TriAlphabetiqueBibliothequeParAuteur ());
			foreach (Livre bouquin in Bibli) 
			{
				bouquin.Affiche ();
				Console.WriteLine ();
			}
		}

		/// <summary>
		/// Tri les Livres par ordres alphabétiques inversé d'auteur.
		/// </summary>
		public void TriParAuteurAlphabétiqueInverse ()
		{
			Bibli.Sort (new TriAlphabetiqueBibliothequeParAuteur ());
			Bibli.Reverse ();
			foreach (Livre bouquin in Bibli)
			{
				bouquin.Affiche ();
				Console.WriteLine ();
			}
		}

		/// <summary>
		/// Tri les Livres par ordres alphabétiques de titre.
		/// </summary>
		public void TriParTitreAlphabétique ()
		{
			Bibli.Sort (new TriAlphabetiqueBibliothequeParTitre ());
			foreach (Livre bouquin in Bibli) 
			{
				bouquin.Affiche ();
				Console.WriteLine ();
			}
		}

		/// <summary>
		/// Tri les Livres par ordres alphabétiques inversé de titre.
		/// </summary>
		public void TriParTitreInverse ()
		{
			Bibli.Sort (new TriAlphabetiqueBibliothequeParTitre ());
			Bibli.Reverse ();
			foreach (Livre bouquin in Bibli) 
			{
				bouquin.Affiche ();
				Console.WriteLine ();
			}
		}

		/// <summary>
		/// Tri les Livres par ordres alphabétiques de Cycle.
		/// </summary>
		public void TriParCycleAlphabétique ()
		{
			Bibli.Sort (new TriAlphabetiqueBibliothequeParCycle ());
			foreach (Livre bouquin in Bibli) 
			{
				if (bouquin.Cycle != null)
				{
					bouquin.Affiche ();
					Console.WriteLine ();
				}
			}
		}

		/// <summary>
		/// Tri les Livres par ordres alphabétiques inversé de Cycle.
		/// </summary>
		public void TriParCycleInverse ()
		{
			Bibli.Sort (new TriAlphabetiqueBibliothequeParCycle ());
			Bibli.Reverse ();
			foreach (Livre bouquin in Bibli) 
			{
				if (bouquin.Cycle != null)
				{
					bouquin.Affiche ();
					Console.WriteLine ();
				}
			}
		}

		/// <summary>
		/// Tri les Livres par ordres alphabétiques de Dessinateur.
		/// </summary>
		public void TriParDessinateurAlphabétique ()
		{
			Bibli.Sort (new TriAlphabetiqueBibliothequeParDessinateur ());
			foreach (Livre bouquin in Bibli) 
			{
				if (bouquin.NomDessinateurCouv != null)
				{
					bouquin.Affiche ();
					Console.WriteLine ();
				}
			}
		}

		/// <summary>
		/// Tri les Livres par ordres alphabétiques inversé de Dessinateur.
		/// </summary>
		public void TriParDessinateurInverse ()
		{
			Bibli.Sort (new TriAlphabetiqueBibliothequeParDessinateur ());
			Bibli.Reverse ();
			foreach (Livre bouquin in Bibli) 
			{
				if (bouquin.NomDessinateurCouv != null)
				{
					bouquin.Affiche ();
					Console.WriteLine ();
				}
			}
		}

		/// <summary>
		/// Tri les Livres par ordres alphabétiques d'editeur.
		/// </summary>
		public void TriParEditeurAlphabétique ()
		{
			Bibli.Sort (new TriAlphabetiqueBibliothequeParEditeur ());
			foreach (Livre bouquin in Bibli) 
			{
				if (bouquin.Edit != null)
				{
					bouquin.Affiche ();
					Console.WriteLine ();
				}
			}
		}

		/// <summary>
		/// Tri les Livres par ordres alphabétiques inversé d'editeur.
		/// </summary>
		public void TriParEditeurInverse ()
		{
			Bibli.Sort (new TriAlphabetiqueBibliothequeParEditeur ());
			Bibli.Reverse ();
			foreach (Livre bouquin in Bibli) 
			{
				if (bouquin.Edit != null)
				{
					bouquin.Affiche ();
					Console.WriteLine ();
				}
			}
		}

		/// <summary>
		/// Tri les Livres par ordres alphabétiques de collection.
		/// </summary>
		public void TriParCollectionAlphabétique ()
		{
			Bibli.Sort (new TriAlphabetiqueBibliothequeParCollection ());
			foreach (Livre bouquin in Bibli) 
			{
				if (bouquin.Coll != null)
				{
					bouquin.Affiche ();
					Console.WriteLine ();
				}
			}
		}

		/// <summary>
		/// Tri les Livres par ordres alphabétiques inversé de collection.
		/// </summary>
		public void TriParCollectionInverse ()
		{
			Bibli.Sort (new TriAlphabetiqueBibliothequeParCollection ());
			Bibli.Reverse ();
			foreach (Livre bouquin in Bibli) 
			{
				if (bouquin.Coll != null)
				{
					bouquin.Affiche ();
					Console.WriteLine ();
				}
			}
		}

		/// <summary>
		/// Tri les Livres par ordres alphabétiques de traducteur.
		/// </summary>
		public void TriParTraducteurAlphabétique ()
		{
			Bibli.Sort (new TriAlphabetiqueBibliothequeParTraducteur ());
			foreach (Livre bouquin in Bibli) 
			{
				if (bouquin.NomTraducteur != null)
				{
					bouquin.Affiche ();
					Console.WriteLine ();
				}
			}
		}

		/// <summary>
		/// Tri les Livres par ordres alphabétiques inversé de traducteur.
		/// </summary>
		public void TriParTraducteurInverse ()
		{
			Bibli.Sort (new TriAlphabetiqueBibliothequeParTraducteur ());
			Bibli.Reverse ();
			foreach (Livre bouquin in Bibli) 
			{
				if (bouquin.NomTraducteur != null)
				{
					bouquin.Affiche ();
					Console.WriteLine ();
				}
			}
		}

		/// <summary>
		/// Tri les Livres par ordres alphabétiques de nationalité.
		/// </summary>
		public void TriParNationalitéAlphabétique ()
		{
			Bibli.Sort (new TriAlphabetiqueBibliothequeParNationalitéAuteur ());
			foreach (Livre bouquin in Bibli) 
			{
				if (bouquin.NationalitéAuteur != null)
				{
					bouquin.Affiche ();
					Console.WriteLine ();
				}
			}
		}

		/// <summary>
		/// Tri les Livres par ordres alphabétiques inversé da nationalité.
		/// </summary>
		public void TriParNaionalitéInverse ()
		{
			Bibli.Sort (new TriAlphabetiqueBibliothequeParNationalitéAuteur ());
			Bibli.Reverse ();
			foreach (Livre bouquin in Bibli) 
			{
				if (bouquin.NationalitéAuteur != null)
				{
					bouquin.Affiche ();
					Console.WriteLine ();
				}
			}
		}

		/// <summary>
		/// Tri les Livres par ordres alphabétiques de genre.
		/// </summary>
		public void TriParGenreAlphabétique ()
		{
			Bibli.Sort (new TriAlphabetiqueBibliothequeParGenre ());
			foreach (Livre bouquin in Bibli) 
			{
				if (bouquin.Genre != null)
				{
					bouquin.Affiche ();
					Console.WriteLine ();
				}
			}
		}

		/// <summary>
		/// Tri les Livres par ordres alphabétiques inversé de genre.
		/// </summary>
		public void TriParGenreInverse ()
		{
			Bibli.Sort (new TriAlphabetiqueBibliothequeParGenre ());
			Bibli.Reverse ();
			foreach (Livre bouquin in Bibli) 
			{
				if (bouquin.Genre != null)
				{
					bouquin.Affiche ();
					Console.WriteLine ();
				}
			}
		}

		/// <summary>
		/// Tri les Livres par ordres alphabétiques de Langue.
		/// </summary>
		public void TriParLangueAlphabétique ()
		{
			Bibli.Sort (new TriAlphabetiqueBibliothequeParLangue ());
			foreach (Livre bouquin in Bibli) 
			{
				if (bouquin.Langue != null)
				{
					bouquin.Affiche ();
					Console.WriteLine ();
				}
			}
		}

		/// <summary>
		/// Tri les Livres par ordres alphabétiques inversé de Langue.
		/// </summary>
		public void TriParLangueInverse ()
		{
			Bibli.Sort (new TriAlphabetiqueBibliothequeParLangue ());
			Bibli.Reverse ();
			foreach (Livre bouquin in Bibli) 
			{
				if (bouquin.Langue != null)
				{
					bouquin.Affiche ();
					Console.WriteLine ();
				}
			}
		}

		/// <summary>
		/// Tri les Livres par ordres alphabétiques d'edition orignale.
		/// </summary>
		public void TriParEditionOriginaleAlphabétique ()
		{
			Bibli.Sort (new TriAlphabetiqueBibliothequeParEditionOriginale ());
			foreach (Livre bouquin in Bibli) 
			{
				if (bouquin.EditionOriginale != null)
				{
					bouquin.Affiche ();
					Console.WriteLine ();
				}
			}
		}

		/// <summary>
		/// Tri les Livres par ordres alphabétiques inversé d'edition Originale.
		/// </summary>
		public void TriParEditionOriginaleInverse ()
		{
			Bibli.Sort (new TriAlphabetiqueBibliothequeParEditionOriginale ());
			Bibli.Reverse ();
			foreach (Livre bouquin in Bibli) 
			{
				if (bouquin.EditionOriginale != null)
				{
					bouquin.Affiche ();
					Console.WriteLine ();
				}
			}
		}

		/// <summary>
		/// Tri les Livres par ordres Chronologies de date de parution VF.
		/// </summary>
		public void TriParDateDeParutionVFChronologique ()
		{
			Bibli.Sort (new TriChronologiqueBibliothequeParDateDeParutionVF ());
			foreach (Livre bouquin in Bibli) 
			{
				if (bouquin.DateDeParutionVF != null)
				{
					bouquin.Affiche ();
					Console.WriteLine ();
				}
			}
		}

		/// <summary>
		/// Tri les Livres par ordres alphabétiques inversé de date de parution VF.
		/// </summary>
		public void TriParDateDeParutionVFChronologiqueInverse ()
		{
			Bibli.Sort (new TriChronologiqueBibliothequeParDateDeParutionVF ());
			Bibli.Reverse ();
			foreach (Livre bouquin in Bibli) 
			{
				if (bouquin.DateDeParutionVF != null)
				{
					bouquin.Affiche ();
					Console.WriteLine ();
				}
			}
		}

		/// <summary>
		/// Tri les Livres par ordres Chronologies de date de parution VO.
		/// </summary>
		public void TriParDateDeParutionVOChronologique ()
		{
			Bibli.Sort (new TriChronologiqueBibliothequeParDateDeParutionVO ());
			foreach (Livre bouquin in Bibli) 
			{
				if (bouquin.DateDeParutionVO != null || bouquin.DateDeParutionVF != null)
				{
					bouquin.Affiche ();
					Console.WriteLine ();
				}
			}
		}

		/// <summary>
		/// Tri les Livres par ordres alphabétiques inversé de date de parution VO.
		/// </summary>
		public void TriParDateDeParutionVOChronologiqueInverse ()
		{
			Bibli.Sort (new TriChronologiqueBibliothequeParDateDeParutionVO ());
			Bibli.Reverse ();
			foreach (Livre bouquin in Bibli) 
			{
				if (bouquin.DateDeParutionVO != null || bouquin.DateDeParutionVF != null)
				{
					bouquin.Affiche ();
					Console.WriteLine ();
				}
			}
		}
	}
}