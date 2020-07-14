using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace IFoster.ViewModel.DashBoardViewModel
{
    class MedicalIdViewModel : BaseViewModel
    {
        private INavigation _navigation;

        public MedicalIdViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

       
    }
}
