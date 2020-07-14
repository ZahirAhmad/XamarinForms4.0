using System;
using System.Collections.Generic;
using IFoster.ViewModel.DashBoardViewModel;
using Xamarin.Forms;

namespace IFoster.View.DashBoardView
{
    


    public partial class ReportCardPage : ContentPage
    {
        private ReportCardViewModel _reportCardViewModel;

        public ReportCardPage()
        {
            InitializeComponent();

            // Hide Default Toolbar
            //NavigationPage.SetHasNavigationBar(this, false);

            _reportCardViewModel = new ReportCardViewModel(Navigation);

            BindingContext = _reportCardViewModel;
        }
    }
}
