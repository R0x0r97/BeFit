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
        private Client selectedClient;
        public RelayCommand<string> AddEntryCommand { get; }

        public ManageEntriesVM()
        {
            AddEntryCommand = new RelayCommand<string>(AddEntryCommandExecute, AddEntryCommandCanExecute);
        }

        public List<Client> Clients
        {
            get
            {
                return Data.Controller.GetClients();
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
