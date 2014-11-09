using System;
using System.Collections;

namespace biblio_dll
{

	/// <summary>
	/// Objet bibliotheque.
	/// </summary>
	public class Bibliotheque						//Dans cette class l'object bouquin est utilisé comme Livre bouquin=new Livre
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

			for (int i = 0; i < Bibli.Count; i++) {
				Livre bouquin = (Livre)Bibli [i];
				bouquin.Affiche ();
				Console.WriteLine ();
			} 
		}
		
			
		/// <summary>
		/// Recherche un livre en fonction de son ???.
		/// </summary>
		public void ChercheUnLivre (object bouquin)
		{
			bool i=Bibli.Contains (bouquin);
			if (i == true) 
			{
				object s = Bibli [Bibli.IndexOf (bouquin)];
				Livre book = (Livre)s;		//Conversion explicite.
				book.Affiche ();
			} 
			else 
			{
				Console.WriteLine ("Le Livre recherché n'est pas présent dans la bibliothéque");
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
			foreach (Livre bouquin in Bibli) {
				bouquin.Affiche ();
				Console.WriteLine ();
			}
		}
	}
}