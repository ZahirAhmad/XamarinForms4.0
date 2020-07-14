using System;
using System.Collections.Generic;
using IFoster.ViewModel.DashBoardViewModel.MasterMenuViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace IFoster.View.DashBoardView.MasterMenuView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChangePasswordPage : ContentPage
    {
        ChangePasswordViewModel ChangePasswordViewModel;

        public ChangePasswordPage()
        {
            InitializeComponent();

            ChangePasswordViewModel = new ChangePasswordViewModel();

            //Bind model to Xaml
            BindingContext = ChangePasswordViewModel;
        }
    }
}
