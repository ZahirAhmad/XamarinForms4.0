using System;
using System.Collections.Generic;
using IFoster.ViewModel.DashBoardViewModel;
using Xamarin.Forms;

namespace IFoster.View.DashBoardView
{
    public partial class NotificationPage : ContentPage
    {
        private NotificationViewModel _notificationViewModel;

        public NotificationPage()
        {
            InitializeComponent();

            _notificationViewModel = new NotificationViewModel(Navigation);

            BindingContext = _notificationViewModel;
        }
    }
}
