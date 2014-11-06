using System;
//plop
namespace biblio_dll
{

	/// <summary>
	/// Objet livre.
	/// </summary>
	public class Livre
	{
		public string titre { get; set;}
		public string nomAuteur { get; set;}
		public string prenomAuteur { get; set;}
		public string edit { get; set;}
		public string coll { get; set;}
		public string isbn { get; set;}


		/// <summary>
		/// Ctor de l'objet livre.
		/// </summary>
		public Livre ()
		{
			Titre ();
			NomAuteur ();
			PrenomAteur ();
			Edition ();
			CollectionDuLivre ();
			Isbn ();
		}

		/// <summary>
		/// L'utilisateur rentre le titre d'un livre
		/// </summary>
		public string Titre()
		{
			Console.WriteLine ("titre du livre");
			titre=Console.ReadLine ();
			return titre;
		}

		/// <summary>
		/// L'utilisateur rentre le nom de l'auteur.
		/// </summary>
		public string NomAuteur()
		{
			Console.WriteLine ("Nom de l'auteur");
			nomAuteur=Console.ReadLine ();
			return nomAuteur;
		}

		/// <summary>
		/// L'utilisateur rentre le prénom de l'auteur.
		/// </summary>
		public string PrenomAteur()
		{
			Console.WriteLine ("Prénom de l'auteur");
			prenomAuteur=Console.ReadLine ();
			return prenomAuteur;
		}

		/// <summary>
		/// L'utilisateur rentre la collection du livre.
		/// </summary>
		public string CollectionDuLivre()
		{
			Console.WriteLine ("Collection");
			coll=Console.ReadLine ();
			return coll;
		}

		/// <summary>
		/// L'utilisateur rentre l'éditeur du livre.
		/// </summary>
		public string Edition()
		{
			Console.WriteLine ("Edition");
			edit=Console.ReadLine ();
			return edit;
		}


		/// <summary>
		/// L'utilisateur rentre le code isbn du livre.
		/// </summary>
		public string Isbn()
		{
			Console.WriteLine ("Code ISBN");
			isbn = Console.ReadLine ();
			return isbn;
		}
	}
}

