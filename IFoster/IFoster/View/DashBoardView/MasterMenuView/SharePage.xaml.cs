using System;
using System.Collections.Generic;
using IFoster.ViewModel.DashBoardViewModel.MasterMenuViewModel;
using Xamarin.Forms;

namespace IFoster.View.DashBoardView.MasterMenuView
{
    public partial class SharePage : ContentPage
    {
        ShareViewModel ShareViewModel;

        public SharePage()
        {
            InitializeComponent();

            ShareViewModel = new ShareViewModel();

            //Bind model to Xaml
            BindingContext = ShareViewModel;
        }
    }
}
