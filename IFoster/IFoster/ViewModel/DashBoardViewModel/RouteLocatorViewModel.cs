using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace IFoster.ViewModel.DashBoardViewModel
{
    class RouteLocatorViewModel : BaseViewModel
    {
        private INavigation _navigation;

        public RouteLocatorViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

       
    }
}
