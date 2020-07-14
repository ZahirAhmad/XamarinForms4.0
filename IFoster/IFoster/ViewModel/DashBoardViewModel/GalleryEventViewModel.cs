using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace IFoster.ViewModel.DashBoardViewModel
{
    public class GalleryEventViewModel : BaseViewModel
    {
        private INavigation _navigation;

        public GalleryEventViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

       
    }
}

