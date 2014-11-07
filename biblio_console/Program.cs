using System;
using biblio_dll;

namespace biblio_console
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			Livre l1 = new Livre {Titre = "Les ailes de la nuit",NomAuteur = "Silverberg",PrenomAuteur = "Robert",Edit = "J'ai lu",Coll = "Science Fiction",DateDeParution = "1975"};
			Livre l2 = new Livre {Titre = "Operation pendule",NomAuteur = "Silverberg",PrenomAuteur = "Robert",Edit = "J'ai lu",Coll = "Science Fiction", Isbn="9782277230595",DateDeParution = "1991"};
			Bibliotheque bibli=new Bibliotheque();
			l1.Affiche();
			Console.WriteLine ();
			l2.Affiche();
			bibli.AjouterUnLivre (l1);
			bibli.AjouterUnLivre (l2);
			bibli.AfficheMaBibliothéque ();
			Console.ReadLine ();
		}
	}
}
