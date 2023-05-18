namespace Client.Service.Data
{
    public class ClientMockDataService
    {
        public static List<Models.Client> Clients = new List<Models.Client>()
        {
            new Models.Client{Id = 101, ClientName = "Jake", ClientCompany = "Hemas", ClientEmail = "jake@hemas.com", ClientPhone = "0771235678"},
            new Models.Client{Id  = 102, ClientName = "Paul", ClientCompany = "Abans", ClientEmail = "paul@abans.com", ClientPhone = "0745678901"},
            new Models.Client{Id  = 103, ClientName = "Tony", ClientCompany = "Singer", ClientEmail = "tony@singer.com", ClientPhone = "0770987654"},
            new Models.Client{Id  = 104, ClientName = "Steve", ClientCompany = "Idealz", ClientEmail = "steve@idealz.com", ClientPhone = "0712245678"},
            new Models.Client{Id  = 105, ClientName = "Barnes", ClientCompany = "Damro", ClientEmail = "barnes@damro.com", ClientPhone = "0771234215"},
            new Models.Client{Id  = 106, ClientName = "Scarlett", ClientCompany = "Softlogic", ClientEmail = "scarlett@softlogic.com", ClientPhone = "0775790678"},
        };
    }
}
