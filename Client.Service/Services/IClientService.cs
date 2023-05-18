namespace Client.Service.Services
{
    public interface IClientService
    {
        List<Models.Client> GetClients();
        Models.Client? GetClient(int id);
        Models.Client? AddClient(Models.Client client);
        Models.Client? UpdateClient(Models.Client client);
        bool? DeleteClient(int id);
    }
}
