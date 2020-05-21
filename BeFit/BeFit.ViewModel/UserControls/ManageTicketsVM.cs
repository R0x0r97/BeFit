using BeFit.Common.MVVM;
using BeFit.Logic;
using BeFit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit.ViewModel.UserControls
{
    public class ManageTicketsVM : ViewModelBase
    {
        private List<Client> clients;
        private List<TicketType> ticketTypes;

        public ManageTicketsVM()
        {
            Clients = Data.Controller.GetClients();
            TicketTypes = Data.Controller.GetTicketTypes();
        }

        public List<Client> Clients
        {
            get
            {
                return clients;
            }
            set
            {
                clients = value;
                RaisePropertyChanged();
            }
        }
        public List<TicketType> TicketTypes
        {
            get
            {
                return ticketTypes;
            }
            set
            {
                ticketTypes = value;
                RaisePropertyChanged();
            }
        }

        public Client Client { get; set; }
        public TicketType TicketType { get; set; }
        public DateTime Date { get; set; }
    }
}
