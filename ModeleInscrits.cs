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
    public class ModeleInscrits
    {
        public void chargerInscrit()
        {
            Controleur.VmodeleC.charger("Select * FROM inscrit ", Controleur.VmodeleC.DT[20]);
        }
        public void chargerInscrit_selonSe()
        {
            Controleur.VmodeleC.charger("Select NOM from inscrit natural join service ", Controleur.VmodeleC.DT[21]);
        }
        public void chargerIdInscrit_selonNom(string nomI)
        {
            Controleur.VmodeleC.charger("select IDINSCRIT from inscrit WHERE NOM like '" + nomI + "';", Controleur.VmodeleC.DT[22]);
        }



        public bool AjoutInscrit(string nom, string prenom, DateTime dateNais, string mail, int tel, string mdp, int credit, string etat ,int idDepartement, int idAr)
        {
            try
            {
                //appel du controleur pour effectuer la requète de suppresion de la formation.
                string requete = "insert into inscrit values (null, @nom, @prenom, @dateNais, @mail, @tel, @mdp, @credit,@etat, @idDepartement ,@idAr )";
                MySqlCommand command = Controleur.VmodeleC.MyConnection.CreateCommand();
                command.CommandText = requete;

                // mise à jour des paramètres de la requête préparée avec les infos passés en paramètre de la méthode
                command.Parameters.AddWithValue("nom", nom);
                command.Parameters.AddWithValue("prenom", prenom);
                command.Parameters.AddWithValue("dateNais", dateNais);
                command.Parameters.AddWithValue("mail", mail);
                command.Parameters.AddWithValue("tel", tel);
                command.Parameters.AddWithValue("mdp", mdp);
                command.Parameters.AddWithValue("credit", credit);
                command.Parameters.AddWithValue("etat", etat);
                command.Parameters.AddWithValue("idDepartement", idDepartement);
                command.Parameters.AddWithValue("idAr", idAr);
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
        public bool modificationInscrit(string nom, string prenom, DateTime dateNais, string mail, int tel, string mdp, int credit, string etat, int idDepartement, int idAr)
        {
            try
            {
                //appel du controleur pour effectuer la requète de suppresion de la formation.
                string requete = "UPDATE inscrit SET NOM = @nom, PRENOM = @prenom, DATENAISSANCE = @dateNais, EMAIL = @mail, TELEPHONE = @tel, MOTDEPASSE = @mdp, CREDIT = @credit, ETAT = @etat, IDDEPARTEMENT = @idDepartement, IDARRONDISSEMENT = @idAr ";
                MySqlCommand command = Controleur.VmodeleC.MyConnection.CreateCommand();
                command.CommandText = requete;

                // mise à jour des paramètres de la requête préparée avec les infos passés en paramètre de la méthode
                command.Parameters.AddWithValue("nom", nom);
                command.Parameters.AddWithValue("prenom", prenom);
                command.Parameters.AddWithValue("dateNais", dateNais);
                command.Parameters.AddWithValue("mail", mail);
                command.Parameters.AddWithValue("tel", tel);
                command.Parameters.AddWithValue("mdp", mdp);
                command.Parameters.AddWithValue("credit", credit);
                command.Parameters.AddWithValue("etat", etat);
                command.Parameters.AddWithValue("idDepartement", idDepartement);
                command.Parameters.AddWithValue("idAr", idAr);
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
