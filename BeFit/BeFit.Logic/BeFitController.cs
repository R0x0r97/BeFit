namespace BeFit.Logic
{
    using System.Collections.Generic;
    using System.Linq;
    using BeFit.Model;
    using BeFit.Model.DBContext;

    public class BeFitController
    {
        private BeFitDB beFitDatabase;

        public BeFitController()
        {
            this.beFitDatabase = new BeFitDB();
        }

        public List<Client> GetClients()
        {
            return beFitDatabase.Clients.ToList();
        }

        public int GetLastEntryId()
        {
            var entry = beFitDatabase.Entries.Last();
            if (entry == null)
            {
                return -1;
            }
            else
            {
                return entry.Id;
            }
        }

        public void AddEntry(Client client)
        {
            Entry entry = new Entry
            {
                Client = client,
                Date = System.DateTime.Now,
                Id = GetLastEntryId() + 1
            };

            beFitDatabase.Entries.Add(entry);
        }

        public int GetLastClientId()
        {
            var entry = beFitDatabase.Entries.Last();
            if (entry == null)
            {
                return 999999;
            }
            else
            {
                return entry.Id;
            }
        }

        public void AddClient(Client newClient)
        {
            Client client = new Client
            {
                BirthDate = newClient.BirthDate,
                Email = newClient.Email,
                IsDeleted = false,
                Name = newClient.Name,
                PhoneNumber = newClient.Name,
                Picture = newClient.Picture,
                Id = GetLastClientId() + 1
            };

            beFitDatabase.Clients.Add(client);
        }

        public List<User> GetUsers()
        {
            return beFitDatabase.Users.ToList();
        }
    }
}
