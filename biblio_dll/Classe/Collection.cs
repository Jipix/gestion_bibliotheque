using System;
using System.Collections.Generic;
//plop
namespace biblio_dll
{
	/// <summary>
	/// Objet collection
	/// </summary>
	public class Collection
	{
		public List<Livre> collection { get; set; }

		/// <summary>
		/// ctor de l'objet collection
		/// </summary>
		public Collection ()
		{
			collection = new List<Livre>();
		}
	}
}

