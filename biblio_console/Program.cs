using System;
using biblio_dll;
using System.Collections;

namespace biblio_console
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			Livre l1 = new Livre {Page=213,Resume="Vaincus il y a de nombreuses années par la race humaine, les extraterrestres ont promis qu'ils se vengeraient et qu'un jour ils envahiraient la Terre. Le temps a passé, la civilisation humaine a périclité et n'est plus que l'ombre d'elle-même, mais la tradition maintient le souvenir d'une possible menace venant d'ailleurs.\nLe guetteur Wuelig est membre de la caste chargée de surveiller le ciel avec ses pouvoirs psychiques. Or, cette attente jusqu’alors toujours vaine, trouve un jour sa raison d'être.",Titre = "Les ailes de la nuit",PrenomTraducteur="Michel",NomTraducteur="Deutsch",Langue="Français",Genre="Science fiction",NationalitéAuteur="Americaine",DateDeParutionVO="1968",NomAuteur = "Silverberg",PrenomAuteur = "Robert",Edit = "J'ai lu",Coll = "Science Fiction",DateDeParutionVF = "1975",EditionOriginale="Oui",PrenomDessinateurCouv="Sergio",NomDessinateurCouv="Macedo"};
			Livre l2 = new Livre {Titre = "Operation pendule",NomAuteur = "Silverberg",PrenomAuteur = "Robert",Edit = "J'ai lu",Coll = "Science Fiction", Isbn="9782277230595",DateDeParutionVO = "1991"};
			Livre l3 = new Livre {Titre = "Les mangeurs d'argile",Cycle="Hommes sans futur",Genre="Science fiction", NationalitéAuteur="Française", NomAuteur = "Pelot",PrenomAuteur = "Pierre",Edit = "Presses Pocket",Coll = "Science Fiction", Isbn="2266010956",DateDeParutionVF = "1981"};
			Livre l4 = new Livre {Cycle="hommes sans futur",Titre = "Ce chasseur là",NomAuteur = "Pelot",PrenomAuteur = "Pierre",Edit = "Presses Pocket",Coll = "Science Fiction", Isbn="2266016164",DateDeParutionVF = "1985"};
			Livre l5 = null;
			Livre l6 = new Livre {Cycle="test",Titre = "test",NomAuteur = "test",PrenomAuteur = "test",Edit = "test",Coll = "test", Isbn="test",DateDeParutionVF = "test", PrenomDessinateurCouv="test", NomDessinateurCouv="test"};
			Bibliotheque bibli=new Bibliotheque();
			bibli.AjouterUnLivre (l1);
			bibli.AjouterUnLivre (l5);
			Console.WriteLine ();
			bibli.NombreDeLivre ();
			Console.ReadLine ();
		}
	}
}
