using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using IFoster.View.DashBoardView;
using Xamarin.Forms;

namespace IFoster.ViewModel.DashBoardViewModel
{
    public class NotificationViewModel : BaseViewModel
    {
       

        private INavigation _navigation;


        public ICommand NotificationCommand { get; set; }

             



        public NotificationViewModel(INavigation navigation)
        {
            _navigation = navigation;

            NotificationCommand = new Command(OnNotificationClick);

        }


        #region Property

        private void OnNotificationClick()
        {
            _navigation.PushAsync(new NotificationPage());
        }

        #endregion


        
    }
}
