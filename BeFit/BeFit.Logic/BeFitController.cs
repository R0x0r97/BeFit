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

        public User GetSeller()
        {
            return beFitDatabase.Users.ToList().FirstOrDefault();
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

        public List<Ticket> GetTicketsForClientId(int clientId)
        {
            return beFitDatabase.Tickets.Where(t => t.ClientId == clientId).ToList();
        }

        public void AddEntry(Client client)
        {
            Entry entry = new Entry
            {
                ClientId = client.Id,
                Date = System.DateTime.Now,
            };

            beFitDatabase.Entries.Add(entry);
            beFitDatabase.SaveChanges();
        }

        public void AddTicket(Client client, TicketType ticketType, DateTime? startDate = null)
        {
            var ticket = new Ticket
            {
                BuyDate = DateTime.Now,
                ClientId = client.Id,
                RemainingEntries = ticketType.TimesUsable,
                TicketTypeId = ticketType.Id,
                UserId = GetSeller().Id
            };

            if (startDate != null && ticketType.LengthInDays != null)
            {
                ticket.Start = startDate.Value;
                ticket.End = startDate.Value.AddDays(ticketType.LengthInDays.Value);
            }

            beFitDatabase.Tickets.Add(ticket);
            beFitDatabase.SaveChanges();
        }

        public int GetLastCardId ()
        {
            if (beFitDatabase.Clients.ToList().Count != 0)
            {
                return beFitDatabase.Clients.ToList().Last().CardId;
            }
            else
            {
                return 999999;
            }
        }

        public void AddClient(string newName, string newPhone, string newEmail, DateTime newBirthdate)
        {
            Client client = new Client
            {
                BirthDate = newBirthdate,
                Email = newEmail,
                IsDeleted = false,
                Name = newName,
                PhoneNumber = newPhone,
                Picture = ".",
                CardId = GetLastCardId() + 1
            };

            beFitDatabase.Clients.Add(client);
            beFitDatabase.SaveChanges();
        }

        public void DeleteClient(Client clientToDelete)
        {
            beFitDatabase.Clients.Remove(clientToDelete);
        }
    }
}
