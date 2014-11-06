using System;
using System.Collections.Generic;

namespace biblio_dll
{
	/// <summary>
	/// Objet editeur
	/// </summary>
	public class Editeur
	{
		public List<Livre> editionDuLivre { get; set; }

		/// <summary>
		/// ctor de l'objet Editeur
		/// </summary>
		public Editeur ()
		{
			editionDuLivre = new List<Livre>();
		}
	}
}

