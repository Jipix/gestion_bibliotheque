using System;
using biblio_dll;
//plop
namespace biblio_console
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			Livre l = new Livre ();
			Console.WriteLine(l);
			Console.ReadLine ();
		}
	}
}
