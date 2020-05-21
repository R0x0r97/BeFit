﻿using BeFit.Common.MVVM;
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
        private List<Ticket> selectedClientTickets;
        private Ticket selectedTicket;
        private string errorMessage;
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

        public List<Ticket> SelectedClientTickets {
            get
            {
                return selectedClientTickets;
            }
            set
            {
                selectedClientTickets = value;
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
                SelectedClientTickets = Data.Controller.GetTicketsForClientId(selectedClient.Id);
                RaisePropertyChanged();
            }
        }

        public Ticket SelectedTicket
        {
            get
            {
                return selectedTicket;
            }
            set
            {
                selectedTicket = value;
                RaisePropertyChanged();
            }
        }

        public string ErrorMessage
        {
            get
            {
                return errorMessage;
            }
            set
            {
                errorMessage = value;
                RaisePropertyChanged();
            }
        }

        public void AddEntryCommandExecute(string obj)
        {
            Data.Controller.AddEntry(SelectedClient);
        }

        public bool AddEntryCommandCanExecute()
        {
            if(selectedTicket.RemainingEntries != null)
            {
                if(selectedTicket.RemainingEntries > 0)
                {
                    selectedTicket.RemainingEntries--;
                    return true;
                }
                ErrorMessage = "There are no remaining entry points on this ticket!";
                return false;
            }
            else
            {
                if(selectedTicket.End > DateTime.Now)
                {
                    return true;
                }
                else
                {
                    ErrorMessage = "This ticket is expired!";
                    return false;
                }
            }
        }
    }
}
