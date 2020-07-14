using System;
using System.Collections.Generic;
using IFoster.ViewModel.DashBoardViewModel.MasterMenuViewModel;
using Xamarin.Forms;

namespace IFoster.View.DashBoardView.MasterMenuView
{
    public partial class ChangeMobileNoPage : ContentPage
    {
        public ChangeMobileNoViewModel changeMobileNoViewModel;

        public ChangeMobileNoPage()
        {
            InitializeComponent();

            changeMobileNoViewModel = new ChangeMobileNoViewModel();

            BindingContext = changeMobileNoViewModel;
        }
    }
}
