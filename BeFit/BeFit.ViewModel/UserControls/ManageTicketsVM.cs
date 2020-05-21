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

        public RelayCommand<string> SellTicketCommand { get; }

        public ManageTicketsVM()
        {
            StartDate = DateTime.Now;
            SellTicketCommand = new RelayCommand<string>(SellTicketCommandExecute, SellTicketCommandCanExecute);
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
                if (client != null)
                {
                    CardId = client.CardId.ToString();
                }
                else
                {
                    CardId = "";
                }
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
            ResetUIData();
        }

        private bool SellTicketCommandCanExecute()
        {
            if (Client != null && TicketType != null)
            {
                return true;
            }
            return false;
        }

        private void ResetUIData()
        {
            Client = null;
            TicketType = null;
            StartDate = DateTime.Now;
        }
    }
}
