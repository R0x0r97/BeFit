using BeFit.Common.MVVM;
using BeFit.ViewModel.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit.ViewModel.Pages
{
    public class MainPageVM : ViewModelBase
    {
        public MainPageVM(int userId)
        {

            ManageClientsVM = new ManageClientsVM();
            ManageTicketsVM = new ManageTicketsVM();
            ManageEntriesVM = new ManageEntriesVM();
        }

        public ManageClientsVM ManageClientsVM { get; }
        public ManageTicketsVM ManageTicketsVM { get; }
        public ManageEntriesVM ManageEntriesVM { get; }
    }
}
