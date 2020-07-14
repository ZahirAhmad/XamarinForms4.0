using System;
using System.Collections.Generic;
using IFoster.ViewModel.DashBoardViewModel.MasterMenuViewModel;
using Xamarin.Forms;

namespace IFoster.View.DashBoardView.MasterMenuView
{
    public partial class SwitchUserPage : ContentPage
    {
        SwitchUserViewModel SwitchUserViewModel;

        public SwitchUserPage()
        {
            InitializeComponent();

            SwitchUserViewModel = new SwitchUserViewModel();

            //Bind model to Xaml
            BindingContext = SwitchUserViewModel;
        }
    }
}
