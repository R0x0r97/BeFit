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
    public class ManageEntriesVM : ViewModelBase
    {
        private List<Client> clients;
        private int clientId;
        public RelayCommand<string> AddEntryCommand { get; }

        public ManageEntriesVM()
        {
            Clients = Data.Controller.GetClients();
            AddEntryCommand = new RelayCommand<string>(AddEntryCommandExecute, AddEntryCommandCanExecute);
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

        public int ClientId
        {
            get
            {
                return clientId;
            }
            set
            {
                clientId = value;
                RaisePropertyChanged();
            }
        }

        public void AddEntryCommandExecute(string obj)
        {
            Data.Controller.AddEntry(ClientId);
        }

        public bool AddEntryCommandCanExecute()
        {
            //Verify Card validity
            return true;
        }
    }
}
