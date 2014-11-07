using System;
using biblio_dll;

namespace biblio_console
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			Livre l = new Livre ();
			l.PrenomAuteur = "Philip";
			l.NomAuteur = "K.Dick";
			Console.WriteLine (l.NomCompletAuteur());
			Console.ReadLine ();
		}
	}
}
