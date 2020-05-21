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
        public ManageTicketsVM()
        {
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

        public Client Client { get; set; }
        public TicketType TicketType { get; set; }
        public DateTime Date { get; set; }
    }
}
