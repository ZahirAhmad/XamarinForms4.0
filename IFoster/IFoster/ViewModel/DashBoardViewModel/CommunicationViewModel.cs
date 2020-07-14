using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace IFoster.ViewModel.DashBoardViewModel
{
    class CommunicationViewModel : BaseViewModel
    {
        private INavigation _navigation;

        public CommunicationViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

       
    }
}
