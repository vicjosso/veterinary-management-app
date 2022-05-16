namespace PT4
{
    class PageManager
    {
        public static Connexion connexion = new Connexion();
        public readonly static Overview overview = new Overview();
        public readonly static Sale sale = new Sale();
        public readonly static create_account create_Account = new create_account();
        public readonly static Stock stock = new Stock();
        public readonly static Clients clients = new Clients();
        public readonly static User user = new User();
        public static salarie salarie = null;
        public static Home home = new Home();

    }
}
