using System;
using System.Collections.Generic;
using IFoster.ViewModel.DashBoardViewModel.MasterMenuViewModel;
using Xamarin.Forms;

namespace IFoster.View.DashBoardView.MasterMenuView
{
    public partial class HelpPage : ContentPage
    {
        HelpViewModel HelpViewModel;

        public HelpPage()
        {
            InitializeComponent();

            HelpViewModel = new HelpViewModel();

            //Bind model to Xaml
            BindingContext = HelpViewModel;
        }
    }
}
