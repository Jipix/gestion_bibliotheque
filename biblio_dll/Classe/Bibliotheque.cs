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
		public List<Livre> bibli { get; set; }

		/// <summary>
		/// Ajout d'un livre dans la bibliotheque.
		/// </summary>
		public Bibliotheque ()
		{
			bibli = new List<Livre>();
			Console.WriteLine(bibli);
		}
	}
}