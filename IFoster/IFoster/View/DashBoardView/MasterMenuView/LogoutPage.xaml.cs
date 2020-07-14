using System;
using System.Collections.Generic;
using IFoster.ViewModel.DashBoardViewModel.MasterMenuViewModel;
using Xamarin.Forms;

namespace IFoster.View.DashBoardView.MasterMenuView
{
    public partial class LogoutPage : ContentPage
    {
        LogoutViewModel LogoutViewModel;

        public LogoutPage()
        {
            InitializeComponent();

            LogoutViewModel = new LogoutViewModel();

            //Bind model to Xaml
            BindingContext = LogoutViewModel;
        }
    }
}
