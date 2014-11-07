using System;
using System.Collections;
//plop
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
			Bibli.Add (bouquin);
		}

		/// <summary>
		/// Affiche ma bibli.
		/// </summary>
		public void AfficheMaBibliothéque ()
		{
			foreach (object Livre in Bibli) 
			{
				Console.WriteLine (Bibli.ToString());
			} 
		}
	}
}