using System;
using System.Collections;

namespace biblio_dll
{

	/// <summary>
	/// Objet livre.
	/// </summary>
	public class Livre
	{
		/// <summary>
		/// Titre du livre.
		/// </summary>
		public string Titre { get; set;}
		/// <summary>
		/// Nom de l'auteur
		/// </summary>
		public string NomAuteur { get; set;}
		/// <summary>
		/// Prenom de l'auteur
		/// </summary>
		public string PrenomAuteur { get; set;}
		/// <summary>
		/// Edition
		/// </summary>
		public string Edit { get; set;}
		/// <summary>
		/// Collection
		/// </summary>
		public string Coll { get; set;}
		/// <summary>
		/// Code ISBN
		/// </summary>
		public string Isbn { get; set;}
		/// <summary>
		/// Date de parution du Livre.
		/// </summary>
		public string DateDeParution { get; set; }


		/// <summary>
		/// Ctor de l'objet livre.
		/// </summary>
		public Livre ()
		{
		}

		/// <summary>
		/// Création du nom complet de l'auteur.
		/// </summary>
		public string NomCompletAuteur()
		{
			return string.Format ("Auteur : {0} {1}", NomAuteur, PrenomAuteur);
		}

		/// <summary>
		/// Affiche les attributs du livre en string.
		/// </summary>
		public void Affiche()
		{
			Console.WriteLine ("Titre : " + Titre);
			Console.WriteLine (NomCompletAuteur().ToString());
			Console.WriteLine ("Editeur : " + Edit);
			Console.WriteLine ("Collection : " + Coll);
			Console.WriteLine ("Code ISBN : " + Isbn);
			Console.WriteLine ("Date de parution : " + DateDeParution);
		}
	}
}