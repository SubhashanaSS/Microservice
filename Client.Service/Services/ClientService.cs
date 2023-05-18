using Client.Service.Data;

namespace Client.Service.Services
{
    public class ClientService : IClientService
    {
        public Models.Client? AddClient(Models.Client client)
        {
            ClientMockDataService.Clients.Add(client);
            return client;
        }

        public bool? DeleteClient(int id)
        {
            Models.Client selectedClient = ClientMockDataService.Clients.FirstOrDefault(c => c.Id == id);
            if (selectedClient != null)
            {
                ClientMockDataService.Clients.Remove(selectedClient);
                return true;
            }
            return false;
        }

        public Models.Client? GetClient(int id)
        {
            return ClientMockDataService.Clients.FirstOrDefault(c =>c.Id == id);
        }

        public List<Models.Client> GetClients()
        {
            return ClientMockDataService.Clients;
        }

        public Models.Client? UpdateClient(Models.Client client)
        {
            Models.Client selectedClient = ClientMockDataService.Clients.FirstOrDefault(c => c.Id == client.Id);
            if (selectedClient != null)
            {
                selectedClient.ClientName = client.ClientName;
                selectedClient.ClientPhone = client.ClientPhone;
                selectedClient.ClientEmail = client.ClientEmail;    
                selectedClient.ClientPhone = client.ClientPhone;
            }
            return selectedClient;
        }
    }
}
