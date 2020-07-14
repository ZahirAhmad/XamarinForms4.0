using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace IFoster.ViewModel.DashBoardViewModel
{
    public class ReportCardViewModel : BaseViewModel
    {
        private INavigation _navigation;

        public ReportCardViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        
    }
}
