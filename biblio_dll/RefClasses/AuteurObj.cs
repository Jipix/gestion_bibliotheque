using System;

namespace biblio_dll
{
	/// <summary>
	/// Représente l'auteur d'un livre
	/// </summary>
	public class AuteurObj
	{
		/// <summary>
		/// Nom de l'auteur
		/// </summary>
		private string _nom;
		/// <summary>
		/// Prénom de l'auteur
		/// </summary>
		private string _prenom;

		/// <summary>
		/// Properties Nom de l'auteur
		/// </summary>
		/// <value>Nom de l'auteur.</value>
		public string Nom 
		{
			get { return _nom; }
			set { _nom = value;}
		}

		/// <summary>
		/// Properties Prenom de l'auteur
		/// </summary>
		/// <value>Prenom de l'auteur.</value>
		public string Prenom 
		{
			get { return _prenom; }
			set { _prenom = value;}
		}

		/// <summary>
		/// Constructeur
		/// </summary>
		public AuteurObj ()
		{
		}
	}
}

