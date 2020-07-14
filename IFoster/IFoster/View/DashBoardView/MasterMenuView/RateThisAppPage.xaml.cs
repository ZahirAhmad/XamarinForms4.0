using System;
using System.Collections.Generic;
using IFoster.ViewModel.DashBoardViewModel.MasterMenuViewModel;
using Xamarin.Forms;

namespace IFoster.View.DashBoardView.MasterMenuView
{
    public partial class RateThisAppPage : ContentPage
    {
        RateThisAppViewModel RateThisAppViewModel;

        public RateThisAppPage()
        {
            InitializeComponent();

            RateThisAppViewModel = new RateThisAppViewModel();

            //Bind Model To Xaml
            BindingContext = RateThisAppViewModel;

        }
    }
}
