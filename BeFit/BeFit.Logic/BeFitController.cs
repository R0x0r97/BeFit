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

        public int GetLastTicketId()
        {
            var sale = beFitDatabase.Sales.Last();
            if (sale == null)
            {
                return -1;
            }
            else
            {
                return sale.Id;
            }
        }

        public void AddTicket(Client client, TicketType ticketType, DateTime? startDate = null)
        {
            var ticket = new Ticket
            {
                BuyDate = DateTime.Now,
                Client = client,
                Id = GetLastTicketId() + 1,
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
    }
}
