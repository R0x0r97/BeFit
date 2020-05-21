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
        private Client client;
        private string cardId;

        public TicketType TicketType { get; set; }
        public DateTime StartDate { get; set; }

        private RelayCommand<string> SellTicket;

        public ManageTicketsVM()
        {
            SellTicket = new RelayCommand<string>(SellTicketCommandExecute);
        }

        public List<Client> Clients
        {
            get
            {
                //return clients;
                return Data.Controller.GetClients();
            }
        }
        public List<TicketType> TicketTypes
        {
            get
            {
                return Data.Controller.GetTicketTypes();
            }
        }

        public Client Client
        {
            get
            {
                return client;
            }
            set
            {
                client = value;
                CardId = client.CardId.ToString();
                //CardId = client.Name;
            }
        }

        public string CardId
        {
            get
            {
                return cardId;
            }
            set
            {
                cardId = value;
                RaisePropertyChanged();
            }
        }

        private void SellTicketCommandExecute(string obj)
        {
            Data.Controller.AddTicket(Client, TicketType, StartDate);
        }
    }
}
