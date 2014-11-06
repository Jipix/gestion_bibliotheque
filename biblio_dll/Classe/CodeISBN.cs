using System;
using System.Collections.Generic;

namespace biblio_dll
{
	/// <summary>
	/// objet CodeISBN
	/// </summary>
	public class CodeISBN
	{
		public List<Livre> codeIsbn { get; set; }

		/// <summary>
		/// ctor de l'objet CodeISBN
		/// </summary>
		public CodeISBN ()
		{
			codeIsbn = new List<Livre>();
		}
	}
}

