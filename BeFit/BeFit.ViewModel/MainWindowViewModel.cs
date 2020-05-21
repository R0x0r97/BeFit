// ------------------------------------------------------------------------------------------------------------------
// <copyright file="MainWindowViewModel.cs" company="DVSE GmbH">
//   Copyright (c) by DVSE Gesellschaft für Datenverarbeitung, Service und Entwicklung mbH. All rights reserved.
// </copyright>
// <author>Szilveszter Gorgicze</author>
// ------------------------------------------------------------------------------------------------------------------

namespace BeFit.ViewModel
{
    using BeFit.Common.MVVM;
    using BeFit.ViewModel.UserControls;
    using System.Collections.Generic;

    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            ManageClientsVM = new ManageClientsVM();
            ManageEntriesVM = new ManageEntriesVM();
            CloseCommand = new RelayCommand<string>(CloseCommandExecute, CloseCommandCanExecute);
        }
        public ManageClientsVM ManageClientsVM { get; }
        public ManageEntriesVM ManageEntriesVM { get; }

        public RelayCommand<string> CloseCommand { get; }

        public void CloseCommandExecute(string obj)
        {
            ViewService.CloseDialog(this);
        }

        public bool CloseCommandCanExecute()
        {
            return true;
        }
    }
}
