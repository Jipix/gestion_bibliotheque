using System;
using System.Collections;

namespace biblio_dll
{

	public class Livre
	{
		/// <summary>
		/// Titre du livre.
		/// </summary>
		public string Titre { get; set;}
		/// <summary>
		/// Cycle du livre.
		/// </summary>
		public string Cycle { get; set; }
		/// <summary>
		/// Nom de l'auteur
		/// </summary>
		public string NomAuteur { get; set;}
		/// <summary>
		/// Prenom de l'auteur
		/// </summary>
		public string PrenomAuteur { get; set;}
		/// <summary>
		/// Prenom du dessinateur.
		/// </summary>
		public string PrenomDessinateurCouv { get; set; }
		/// <summary>
		/// Nom du dessinateur.
		/// </summary>
		public string NomDessinateurCouv { get; set; }
		/// <summary>
		/// Edition
		/// </summary>
		public string Edit { get; set;}
		/// <summary>
		/// Collection
		/// </summary>
		public string Coll { get; set;}
		/// <summary>
		/// Code ISBN
		/// </summary>
		public string Isbn { get; set;}
		/// <summary>
		/// Date de parution du Livre VO.
		/// </summary>
		public string DateDeParutionVO { get; set; }
		/// <summary>
		/// Date de parution du Livre VF.
		/// </summary>
		public string DateDeParutionVF { get; set; }
		/// <summary>
		/// Nom du traducteur.
		/// </summary>
		public string NomTraducteur { get; set; }
		/// <summary>
		/// Prenom du traducteur.
		/// </summary>
		public string PrenomTraducteur { get; set; }
		/// <summary>
		/// Nationalité de l'auteur.
		/// </summary>
		public string NationalitéAuteur { get; set; }
		/// <summary>
		/// Genre du livre.
		/// </summary>
		public string Genre { get; set; }
		/// <summary>
		/// Langue.
		/// </summary>
		public string Langue { get; set; }
		/// <summary>
		/// Edition originale.
		/// </summary>
		public string EditionOriginale { get; set; }
		/// <summary>
		/// Résumé du livre.
		/// </summary>
		public string Resume { get; set; }
		/// <summary>
		/// Nombre de pages.
		/// </summary>
		public int Page { get; set;}


		/// <summary>
		/// Ctor de l'objet livre.
		/// </summary>
		public Livre ()
		{
		}

		/// <summary>
		/// Création du nom complet de l'auteur.
		/// </summary>
		public string NomCompletAuteur()
		{
			return string.Format ("Auteur : {0} {1}", NomAuteur, PrenomAuteur);
		}

		/// <summary>
		/// Création du nom complet du traducteur.
		/// </summary>
		public string NomCompletTraducteur()
		{
			return string.Format ("Traducteur : {0} {1}", NomTraducteur, PrenomTraducteur);
		}

		/// <summary>
		/// Création du nom complet du dessinateur.
		/// </summary>
		public string NomCompletDessinateur()
		{
			return string.Format ("Dessinateur : {0} {1}", NomDessinateurCouv, PrenomDessinateurCouv);
		}

		/// <summary>
		/// Affiche les attributs du livre en string.
		/// </summary>
		public void Affiche()
		{
			Console.WriteLine ("Titre : " + Titre);
			if (Cycle!=" ")
				Console.WriteLine ("Cycle : " + Cycle);
			Console.WriteLine (NomCompletAuteur().ToString());
			if(NationalitéAuteur!=null)
			Console.WriteLine ("Nationalité de l'auteur : " + NationalitéAuteur);
			if(Edit!=null)
			Console.WriteLine ("Editeur : " + Edit);
			if(Coll!=null)
			Console.WriteLine ("Collection : " + Coll);
			if(Genre!=null)
			Console.WriteLine ("Genre : " + Genre);
			if (Isbn!=null)			
				Console.WriteLine ("Code ISBN : " + Isbn);
			if(Langue!=null)
			Console.WriteLine ("Langue : " + Langue);
			if(DateDeParutionVF!=null)
			Console.WriteLine ("Date de parution version française : " + DateDeParutionVF);
			if(EditionOriginale!=null)
			Console.WriteLine ("Edition originale : " + EditionOriginale);
			if (NationalitéAuteur != "France" || NationalitéAuteur != "france" || NationalitéAuteur != "Française" || NationalitéAuteur != "française" || NationalitéAuteur != null ||DateDeParutionVO !=null) 
			{
				Console.WriteLine ("Date de parution version originale : " + DateDeParutionVO);
				Console.WriteLine (NomCompletTraducteur ().ToString ());
			}
			if (NomDessinateurCouv!=null)
				Console.WriteLine (NomCompletDessinateur().ToString());
			if (Page!=0)
				Console.WriteLine ("Nombre de pages : " + Page.ToString());
			if (Resume!=null)
				Console.WriteLine ("Résumé du livre : "+Resume);
		}
	}
}