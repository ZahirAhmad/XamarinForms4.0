using System;
using System.Collections.Generic;
using IFoster.ViewModel.DashBoardViewModel.MasterMenuViewModel;
using Xamarin.Forms;

namespace IFoster.View.DashBoardView.MasterMenuView
{
    public partial class MasterOptionPage : ContentPage
    {
        //Event Handler
        public event EventHandler<ContentPage> ChangeDetailPage;

        //View Model
        MasterOptionViewModel MasterOptionViewModel;

        public MasterOptionPage()
        {
            InitializeComponent();

            // Hide Default Toolbar
            NavigationPage.SetHasNavigationBar(this, false);

            MasterOptionViewModel = new MasterOptionViewModel();
            MasterOptionViewModel.MasterOptionPage = this;

            //Bind Model To the xaml
            BindingContext = MasterOptionViewModel;

            if (Device.RuntimePlatform == Device.iOS)
            {
                //Icon = "menu.png";
            }
        }

        public void UpdateMasterDetailPage(ContentPage DetailPage)
        {
            //Fire Event
            if(ChangeDetailPage != null)
            {
                ChangeDetailPage.Invoke(this, DetailPage);
            }
        }
    }
}
