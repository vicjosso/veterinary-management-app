using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Helpers;

namespace PT4
{
    internal class DataBase
    {
        public readonly BD_pt4_S4A_eq1Entities database;
        private static DataBase singleton;
        /// <summary>
        /// Constructeur de la classe DataBase
        /// </summary>
        private DataBase()
        {
            database = new BD_pt4_S4A_eq1Entities();
        }

        /// <summary>
        /// Créateur du Singleton de la classe
        /// </summary>
        public static DataBase Instance
        {
            get
            {
                if (singleton == null)
                    singleton = new DataBase();
                return singleton;
            }
        }

        #region UserManagement
        /// <summary>
        /// Permet de récuperer un utilisateur
        /// </summary>
        /// <param name="login"> Identifiant de l'utilisateur </param>
        /// <returns></returns>
        public salarie getUser(string login)
        {
            var user = (from a in database.salarie
                        where a.login.Equals(login)
                        select a).First();

            return user;
        }

        /// <summary>
        /// Fonction permettant de créer un nouvel utilisateur
        /// </summary>
        /// <param name="user"> l'utilisateur à ajouter </param>
        public void createUser(salarie user)
        {
            checkUser(user.login);
            database.salarie.Add(user);
            database.SaveChanges();
        }

        /// <summary>
        /// Vérifie si l'identifiant est déjà pris
        /// </summary>
        /// <param name="login"> Identifiant de l'utilisateur </param>
        /// <exception cref="Exception">Exception levée lorsque le login d'utilisateur est déjà présent dans la DB</exception>
        public void checkUser(String login)
        {
            bool isAlreadyPresent = userAlreadyPresent(login);

            if (isAlreadyPresent)
                throw new Exception("Cette utilisateur est déjà présent dans la base de données");
        }

        /// <summary>
        /// Méthode permettant de vérifer la présence d'un utilisateur dans la base
        /// </summary>
        /// <param name="login">Identifiant</param>
        /// <returns>Vrai si l'utilisateur est présent, sinon faux</returns>
        public bool userAlreadyPresent(String login)
        {
            return (from a in database.salarie
                    where a.login.Equals(login)
                    select a).ToList().Count > 0;
        }

        /// <summary>
        /// Méthode permettant de vérifier l'utilisateur lors de sa connexion
        /// </summary>
        /// <param name="login">Identifiant</param>
        /// <param name="pass">Mot de passe</param>
        /// <returns>Vrai si le mot de passe correspond à l'identifiant lié, sinon faux</returns>
        public bool verifUser(string login, string pass)
        {
            if (!userAlreadyPresent(login)) { return false; }

            salarie s = getUser(login);

            if (Crypto.VerifyHashedPassword(s.mdp, pass) && s.login.Equals(login))
            {
                PageManager.salarie = s;
                return true;
            }

            return false;

        }
        /// <summary>
        /// Change le mot de passe de l'utilisateur
        /// </summary>
        /// <param name="user">L'utilisateur à qui le mot de passe sera changé</param>
        /// <param name="previousPassword">Le mot de passe précedent</param>
        /// <param name="newPassword">Le nouveau mot de passe</param>
        /// <returns></returns>
        public bool changeUserPassword(salarie user, String previousPassword, String newPassword)
        {
            salarie s = getUser(user.login);

            if (Crypto.VerifyHashedPassword(s.mdp, previousPassword))
            {
                s.mdp = Crypto.HashPassword(newPassword);
                database.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
        #endregion

        #region Client Management & Animal Management
        /// <summary>
        /// Méthode permettant de créer un client
        /// </summary>
        /// <param name="client">client</param>
        public void createClient(client client)
        {
            database.client.Add(client);
            database.SaveChanges();
        }

        /// <summary>
        /// Méthode permettant d'obtenir un client
        /// </summary>
        /// <param name="name">Nom</param>
        /// <param name="lastname">Nom de famille</param>
        /// <returns>Un client</returns>
        public client getClient(String name, String lastname)
        {
            return (from a in database.client
                    where a.nomClient.Equals(name)
                    && a.prenomClient.Equals(lastname)
                    select a).First();
        }

        /// <summary>
        /// Méthode permettant la liste des clients à partir d'un morceaux de nom
        /// </summary>
        /// <param name="name">Partie du nom</param>
        /// <returns>Une liste de client</returns>
        public List<client> getClients(String name)
        {
            return (from a in database.client
                    where a.nomClient.Contains(name)
                    select a).ToList();
        }

        /// <summary>
        /// Méthode mettant à jour un client
        /// </summary>
        /// <param name="c">Client</param>
        public void updateClient(client c)
        {
            var client = database.client.Find(c.idClient);
            client.prenomClient = c.prenomClient;
            client.nomClient = c.nomClient;
            client.numeroClient = c.numeroClient;
            database.SaveChanges();
        }

        /// <summary>
        /// Méthode permettant de supprimer un client
        /// </summary>
        /// <param name="id">Identifiant</param>
        public void removeClient(int id)
        {
            database.client.Remove(database.client.Find(id));
            database.SaveChanges();
        }
        /// <summary>
        /// Méthode créant un animal
        /// </summary>
        /// <param name="animal">Animal</param>
        public void createAnimal(animal animal)
        {
            database.animal.Add(animal);
            database.SaveChanges();
        }

        /// <summary>
        /// Méthode mettant à jour un animal
        /// </summary>
        /// <param name="a">Animal</param>
        public void updateAnimal(animal a)
        {
            var animal = database.animal.Find(a.idAnimal);
            animal.nomAnimal = a.nomAnimal;
            animal.nomEspece = a.nomEspece;
            animal.nomRace = a.nomRace;
            animal.poids = a.poids;
            animal.taille = a.taille;
            animal.dateNaissance = a.dateNaissance;
            database.SaveChanges();
        }

        /// <summary>
        /// Méthode permettant de supprimer un animal
        /// </summary>
        /// <param name="id">Identifiant</param>
        public void removeAnimal(int id)
        {
            database.animal.Remove((
                from a in database.animal
                where a.idAnimal.Equals(id)
                select a).First());
            database.SaveChanges();
        }

        #endregion

        #region Stocks Management

        /// <summary>
        /// Retourne une produit en fonction de son id
        /// </summary>
        /// <param name="id">Identifiant du produit</param>
        /// <returns>Le produit demandé</returns>
        public produit getProductByID(int id)
        {
            return database.produit.Find(id);
        }

        /// <summary>
        /// Retourne une liste de produit contenant les caractères rentrés
        /// </summary>
        /// <param name="name">Nom ou partie du nom</param>
        /// <returns>Liste des produits obtenus</returns>
        public List<produit> getProducts(String name)
        {
            return (from a in database.produit
                    where a.nomProduit.Contains(name)
                    select a).ToList();
        }

        /// <summary>
        /// Méthode permettant de créer un nouveau produit dans la BD
        /// </summary>
        /// <param name="produit">le produit à ajouter</param>
        public void createProduct(produit produit)
        {
            database.produit.Add(produit);
            database.SaveChanges();
        }

        /// <summary>
        /// Méthode permettant de supprimer un produit
        /// </summary>
        /// <param name="id">Identifiant</param>
        public void removeProduct(int id)
        {
            database.produit.Remove(getProductByID(id));
            database.SaveChanges();
        }

        /// <summary>
        /// Méthode permettant de mettre à jour une produit
        /// </summary>
        /// <param name="p">le produit à mettre à jour</param>
        public void updateProduct(produit p)
        {
            var product = database.produit.Find(p.idProduit);

            product.quantiteStock = p.quantiteStock;
            product.nomProduit = p.nomProduit;
            product.prixVenteClient = p.prixVenteClient;
            product.prixAchat = p.prixAchat;
            product.description = p.description;

            database.SaveChanges();
        }

        #endregion

        #region Sale Management

        /// <summary>
        /// Méthode créant une vente
        /// </summary>
        /// <param name="f">Facture partiellement complète</param>
        /// <param name="products">Ensemble de produits liés à la facture</param>
        public void createSale(facture_produit f, List<produit> products)
        {
            createInvoice(f);
            foreach (produit prod in products)
            {
                createSoldProduct(prod.quantiteStock, getProductByID(prod.idProduit));
            }
        }

        /// <summary>
        /// Méthode créant une facture
        /// </summary>
        /// <param name="f">Facture partiellement complète</param>
        private void createInvoice(facture_produit f)
        {
            database.facture_produit.Add(f);
            database.SaveChanges();
        }

        /// <summary>
        /// Méthode créant le produit vendu et mettant à jour le produit
        /// </summary>
        /// <param name="nbSold">Nombre de produit vendu</param>
        /// <param name="p">Produit fourni</param>
        private void createSoldProduct(int nbSold, produit p)
        {
            p.quantiteStock = p.quantiteStock - nbSold;
            updateProduct(p);
        }

        #endregion

        #region Appointment Management

        /// <summary>
        /// Méthode permettant d'obtenir les rdv
        /// </summary>
        /// <returns>Liste des rendez-vous</returns>
        public List<rendez_vous> getAppointments()
        {
            return (from a in database.rendez_vous
                    select a).ToList();
        }

        /// <summary>
        /// Méthode de création de rdv
        /// </summary>
        /// <param name="appointment">Le rendez-vous</param>
        public void CreateAppointment(rendez_vous appointment)
        {
            database.rendez_vous.Add(appointment);
            database.SaveChanges();
        }

        /// <summary>
        /// Méthode de mis à jour du rdv
        /// </summary>
        /// <param name="rdv">Le rendez-vous</param>
        public void updateAppointment(rendez_vous rdv)
        {
            var rendez_vous = database.rendez_vous.Find(rdv.idRDV);
            rendez_vous.dateDebut = rdv.dateDebut;
            rendez_vous.dateFin = rdv.dateFin;
            rendez_vous.raison = rdv.raison;
            database.SaveChanges();
        }

        /// <summary>
        /// Méthode permettant de supprimer un rdv
        /// </summary>
        /// <param name="rdvID">Identifiant du rdv</param>
        public void removeAppointment(int rdvID)
        {
            database.rendez_vous.Remove((
            from a in database.rendez_vous
            where a.idRDV.Equals(rdvID)
            select a).First());
            database.SaveChanges();
        }
        #endregion

    }
}