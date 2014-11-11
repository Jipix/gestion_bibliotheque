using System;
using System.Collections.Generic;

namespace biblio_dll
{
	/// <summary>
	/// Représente un livre
	/// </summary>
	public class LivreObj
	{
		/// <summary>
		/// Titre du livre
		/// </summary>
		private string _titre;
		/// <summary>
		/// Auteurs du livre
		/// </summary>
		private List<AuteurObj> _auteurs;

		/// <summary>
		/// Properties du titre
		/// </summary>
		/// <value>Le titre du livre</value>
		public string Titre {
			get { return _titre; }
			set { _titre = value;}
		}

		/// <summary>
		/// Properties de la liste des auteurs du livre
		/// </summary>
		/// <value>le(s) auteur(s) du livre.</value>
		public List<AuteurObj> Auteurs
		{
			get 
			{
				if (_auteurs == null) 
				{
					// la liste n'est pas encore instanciée. On va donc le faire avec de la renvoyer (pour éviter un null exception)
					_auteurs = new List<AuteurObj> ();
				}

				return _auteurs;
			}

			set 
			{
				_auteurs = value;
			}
		}

		/// <summary>
		/// Constructeur
		/// </summary>
		public LivreObj ()
		{
		}
	}
}

