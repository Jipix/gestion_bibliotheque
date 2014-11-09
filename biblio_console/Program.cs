using System;
using biblio_dll;
using System.Collections;

namespace biblio_console
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			Livre l1 = new Livre {Titre = "Les ailes de la nuit",NomAuteur = "Silverberg",PrenomAuteur = "Robert",Edit = "J'ai lu",Coll = "Science Fiction",DateDeParution = "1975"};
			Livre l2 = new Livre {Titre = "Operation pendule",NomAuteur = "Silverberg",PrenomAuteur = "Robert",Edit = "J'ai lu",Coll = "Science Fiction", Isbn="9782277230595",DateDeParution = "1991"};
			Livre l3 = new Livre {Titre = "Les mangeurs d'argile",NomAuteur = "Pelot",PrenomAuteur = "Pierre",Edit = "Presses Pocket",Coll = "Science Fiction", Isbn="2266010956",DateDeParution = "1981"};
			Livre l4 = new Livre {Titre = "Ce chasseur là",NomAuteur = "Pelot",PrenomAuteur = "Pierre",Edit = "Presses Pocket",Coll = "Science Fiction", Isbn="2266016164",DateDeParution = "1985"};
			Livre l5 = null;
			Bibliotheque bibli=new Bibliotheque();
			bibli.AjouterUnLivre (l1);
			bibli.AjouterUnLivre (l2);
			bibli.AjouterUnLivre (l3);
			bibli.AjouterUnLivre (l4);
			bibli.TriParAuteurAlphabétiqueInverse ();
			//bibli.AjouterUnLivre (l5); //plantage appli, il faut regler ça, execption ?
			Console.ReadLine ();
		}
	}
}
