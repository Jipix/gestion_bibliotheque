using System;

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
		/// <value>The titre.</value>
		public string Titre { get; set;}
		/// <summary>
		/// Nom de l'auteur
		/// </summary>
		/// <value>The nom auteur.</value>
		public string NomAuteur { get; set;}
		/// <summary>
		/// Prenom de l'auteur
		/// </summary>
		/// <value>The prenom auteur.</value>
		public string PrenomAuteur { get; set;}
		/// <summary>
		/// Edition
		/// </summary>
		/// <value>The edit.</value>
		public string Edit { get; set;}
		/// <summary>
		/// Collection
		/// </summary>
		/// <value>The coll.</value>
		public string Coll { get; set;}
		/// <summary>
		/// Code ISBN
		/// </summary>
		/// <value><c>true</c> if this instance isbn; otherwise, <c>false</c>.</value>
		public string Isbn { get; set;}


		/// <summary>
		/// Ctor de l'objet livre.
		/// </summary>
		public Livre ()
		{
		}

		/// <summary>
		/// Création du nom complet de l'auteur.
		/// </summary>
		/// <returns>The complet auteur.</returns>
		public string NomCompletAuteur()
		{
			return string.Format ("Auteur : {0} {1}", PrenomAuteur, NomAuteur);
		}
	}
}