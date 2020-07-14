using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace IFoster.ViewModel.DashBoardViewModel
{
    class FeeViewModel : BaseViewModel
    {
        private INavigation _navigation;

        public FeeViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        
    }
}
