using System;
using System.Collections.Generic;

namespace biblio_dll
{
	/// <summary>
	/// Objet Auteur
	/// </summary>
	public class Auteur
	{
		public List<Livre> auteur { get; set; }

		/// <summary>
		/// ctor de l'objet auteur.
		/// </summary>
		public Auteur ()
		{
			auteur = new List<Livre>();
		}
	}
}

