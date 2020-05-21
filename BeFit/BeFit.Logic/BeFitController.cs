namespace BeFit.Logic
{
    using System;
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

        public List<User> GetUsers()
        {
            return beFitDatabase.Users.ToList();
        }

        public List<TicketType> GetTicketTypes()
        {
            return beFitDatabase.Types.ToList();
        }

        public void AddEntry(Client client)
        {
            Entry entry = new Entry
            {
                Client = client,
                Date = System.DateTime.Now,
            };

            beFitDatabase.Entries.Add(entry);
        }

        public void AddTicket(Client client, TicketType ticketType, DateTime? startDate = null)
        {
            var ticket = new Ticket
            {
                BuyDate = DateTime.Now,
                Client = client,
                RemainingEntries = ticketType.TimesUsable.Value,
                Type = ticketType
            };

            if (startDate != null)
            {
                ticket.Start = startDate.Value;
                ticket.End = startDate.Value.AddDays(ticketType.LengthInDays.Value);
            }

            beFitDatabase.Sales.Add(ticket);
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
            };

            beFitDatabase.Clients.Add(client);
            beFitDatabase.SaveChanges();
        }
    }
}
