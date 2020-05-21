// ------------------------------------------------------------------------------------------------------------------


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

        public void AddEntry(int clientId)
        {
            var entry = new Entry
            {
                ClientId = clientId,
                Date = System.DateTime.Now,
                Id = GetLastEntryId() + 1
            };

            beFitDatabase.Entries.Add(entry);
        }

        public List<User> GetUsers()
        {
            return beFitDatabase.Users.ToList();
        }
    }
}
