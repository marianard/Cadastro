using Cadastro.Models;
using System.Collections.Generic;
using System.Linq;

namespace Cadastro.Repositories
{
    public class ClientRepository
    {
        private readonly IList<Client> Clients;

        public ClientRepository()
        {
            Clients = new List<Client>();
        }

        public Client Add(Client client)
        {
            var id = Clients.Select(x => x.Id).DefaultIfEmpty(0).Max() + 1;
            client.Id = id;
            Clients.Add(client);
            return client;
        }

        public Client Update(int id, Client client)
        {
            var oldClient = Get(id);
            if (oldClient is null)
                return Add(client);

            var index = Clients.IndexOf(oldClient);
            Clients[index] = client;
            return client;
        }

        public void Delete(int id)
        {
            var deleteClient = Get(id);
            if (deleteClient is null)
                return;

            Clients.Remove(deleteClient);
        }

        public Client Get(int id)
        {
            return Clients.FirstOrDefault(x => x.Id == id);
        }

        public Client GetByCpf(string cpf)
        {
            return Clients.FirstOrDefault(x => x.Cpf == cpf);
        }

        public IList<Client> List()
        {
            return Clients.ToList();
        }
    }
}
