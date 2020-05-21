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
        private Client selectedClient;
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

        public Client SelectedClient
        {
            get
            {
                return selectedClient;
            }
            set
            {
                selectedClient = value;
                RaisePropertyChanged();
            }
        }

        public void AddEntryCommandExecute(string obj)
        {
            Data.Controller.AddEntry(SelectedClient);
        }

        public bool AddEntryCommandCanExecute()
        {
            //Verify Card validity
            return true;
        }
    }
}
