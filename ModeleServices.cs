using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Lebonfrancais.service
{
    public class ModeleServices
    {
        public void charger_Service()
        {
            Controleur.VmodeleC.charger("select * from service;", Controleur.VmodeleC.DT[1]);
        }
        public void charger_ArrondissementSelonDepartement(int idDe)
        {
            Controleur.VmodeleC.charger("select D.IDDEPARTEMENT, A.IDARRONDISSEMENT, A.NOM from arrondissement A INNER JOIN departement D ON A.IDDEPARTEMENT = D.IDDEPARTEMENT WHERE A.IDDEPARTEMENT = " + idDe + ";", Controleur.VmodeleC.DT[2]);
        }

        public void chargerIdDe_selonNom(string nomDe)
        {
            Controleur.VmodeleC.charger("select IDDEPARTEMENT from departement WHERE NOM LIKE '" + nomDe + "';", Controleur.VmodeleC.DT[3]);
        }

        public void chargerIdAr_selonNom(string nomAr)
        {
            Controleur.VmodeleC.charger("select IDARRONDISSEMENT from arrondissement WHERE NOM Like '" + nomAr + "';", Controleur.VmodeleC.DT[4]);
        }
        public void charger_Departement()
        {
            Controleur.VmodeleC.charger("select * from departement;", Controleur.VmodeleC.DT[5]);
        }













        public bool ValiderService(int id)
        {
            try
            {
                //appel du controleur pour effectuer la requète de changement 
                string requete = "Update service set PUBLIQUE = 0 where IDSERVICE = @id ";
                MySqlCommand command = Controleur.VmodeleC.MyConnection.CreateCommand();
                command.CommandText = requete;

                // mise à jour des paramètres de la requête préparée avec les infos passés en paramètre de la méthode
                command.Parameters.AddWithValue("id", id);

                // Exécution de la requête
                int i = command.ExecuteNonQuery();

                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }

            catch
            {
                return false;
            }
        }

        public bool PasValiderService(int id)
        {
            try
            {
                //appel du controleur pour effectuer la requète de changement 
                string requete = "Update service set PUBLIQUE = 1 where IDSERVICE = @id ";
                MySqlCommand command = Controleur.VmodeleC.MyConnection.CreateCommand();
                command.CommandText = requete;

                // mise à jour des paramètres de la requête préparée avec les infos passés en paramètre de la méthode
                command.Parameters.AddWithValue("id", id);

                // Exécution de la requête
                int i = command.ExecuteNonQuery();

                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }

            catch
            {
                return false;
            }
        }
        public bool AjoutService(string libelle, string description, bool recherche, bool visible, int idInscrit, int idDepartement, int idArrondissement)
        {
            try
            {
                //appel du controleur pour effectuer la requète de suppresion de la formation.
                string requete = "insert into service values (null, @libelle, @description, @recherche, @visible, @idInscrit, @idDepartement, @idArrondissement)";
                MySqlCommand command = Controleur.VmodeleC.MyConnection.CreateCommand();
                command.CommandText = requete;

                // mise à jour des paramètres de la requête préparée avec les infos passés en paramètre de la méthode
                command.Parameters.AddWithValue("libelle", libelle);
                command.Parameters.AddWithValue("description", description);
                command.Parameters.AddWithValue("recherche", recherche);
                command.Parameters.AddWithValue("visible", visible);
                command.Parameters.AddWithValue("idInscrit", idInscrit);
                command.Parameters.AddWithValue("idDepartement", idDepartement);
                command.Parameters.AddWithValue("idArrondissement", idArrondissement);
                // Exécution de la requête
                int i = command.ExecuteNonQuery();

                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }
            catch
            {
                return false;
            }
        }
        public bool modificationService(string libelle, string description,bool recherche, bool visible, int idInscrit, int idDepartement, int idArrondissement)
        {
            try
            {
                //appel du controleur pour effectuer la requète de suppresion de la formation.
                string requete = "UPDATE service SET LIBELLE = @libelle, DESCRIPTION = @description, RECHERCHE	 = @recherche, PUBLIQUE = @visible, IDINSCRIT = @idInscrit, IDDEPARTEMENT = @idDepartement IDARRONDISSEMENT = @idArrondissement ";
                MySqlCommand command = Controleur.VmodeleC.MyConnection.CreateCommand();
                command.CommandText = requete;

                // mise à jour des paramètres de la requête préparée avec les infos passés en paramètre de la méthode
                command.Parameters.AddWithValue("libelle", libelle);
                command.Parameters.AddWithValue("description", description);
                command.Parameters.AddWithValue("recherche", recherche);
                command.Parameters.AddWithValue("visible", visible);
                command.Parameters.AddWithValue("idInscrit", idInscrit);
                command.Parameters.AddWithValue("idDepartement", idDepartement);
                command.Parameters.AddWithValue("idArrondissement", idArrondissement);               
                // Exécution de la requête
                int i = command.ExecuteNonQuery();

                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }

            catch
            {
                return false;
            }
        }
        public bool supprimerFormation(int id)
        {
            try
            {
                //appel du controleur pour effectuer la requète de suppresion de la formation.
                string requete = "Delete from service where IDSERVICE = @id ";
                MySqlCommand command = Controleur.VmodeleC.MyConnection.CreateCommand();
                command.CommandText = requete;

                // mise à jour des paramètres de la requête préparée avec les infos passés en paramètre de la méthode
                command.Parameters.AddWithValue("id", id);

                // Exécution de la requête
                int i = command.ExecuteNonQuery();

                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }

            catch
            {
                return false;
            }
        }
    }
}
