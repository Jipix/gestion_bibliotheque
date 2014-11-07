using System;
using System.Collections.Generic;
//plop
namespace biblio_dll
{
	/// <summary>
	/// Objet bibliotheque.
	/// </summary>
	public class Bibliotheque
	{
		public List<Livre> Bibli { get; set; }

		/// <summary>
		/// Ajout d'un livre dans la bibliotheque.
		/// </summary>
		public Bibliotheque ()
		{
			Bibli = new List<Livre>();
		}
	}
}