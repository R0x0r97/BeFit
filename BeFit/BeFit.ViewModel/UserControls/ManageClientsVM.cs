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
    public class ManageClientsVM : ViewModelBase
    {
        public RelayCommand<string> AddClientCommand { get; }
        public RelayCommand<string> RemoveClientCommand { get; }

        public string nameInput;
        public string phoneNumberInput;
        public string emailInput;
        public DateTime birthdayInput;
        public List<Client> clients;
        public Client selectedClientToDelete;

        public ManageClientsVM()
        {
            birthdayInput = DateTime.Now;
            AddClientCommand = new RelayCommand<string>(AddClientCommandExecute, AddClientCommandCanExecute);
            RemoveClientCommand = new RelayCommand<string>(RemoveClientCommandExecute);
        }

        public DateTime BirthdayInput
        {
            get
            {
                return birthdayInput;
            }
            set
            {
                birthdayInput = value;
                RaisePropertyChanged();
            }
        }

        public string NameInput
        {
            get
            {
                return nameInput;
            }
            set
            {
                nameInput = value;
                RaisePropertyChanged();
            }
        }

        public Client SelectedClientToDelete
        {
            get
            {
                return selectedClientToDelete;
            }
            set
            {
                selectedClientToDelete = value;
                RaisePropertyChanged();
            }
        }

        public List<Client> Clients
        {
            get
            {
                return Data.Controller.GetClients();
            }
            set
            {
                clients = value;
                RaisePropertyChanged();
            }
        }

        public string PhoneNumberInput
        {
            get
            {
                return phoneNumberInput;
            }
            set
            {
                phoneNumberInput = value;
                RaisePropertyChanged();
            }
        }

        public string EmailInput
        {
            get
            {
                return emailInput;
            }
            set
            {
                emailInput = value;
                RaisePropertyChanged();
            }
        }

        public void AddClientCommandExecute(string obj)
        {
            Data.Controller.AddClient(NameInput, PhoneNumberInput, EmailInput, BirthdayInput);
            ResetInput();
        }

        public void RemoveClientCommandExecute(string obj)
        {
            Data.Controller.DeleteClient(SelectedClientToDelete);
        }

        public bool AddClientCommandCanExecute()
        {
            //Verify Client validity
            return true;
        }

        public void ResetInput()
        {
            NameInput = "";
            EmailInput = "";
            PhoneNumberInput = "";
            BirthdayInput = DateTime.Now;
        }
    }
}
