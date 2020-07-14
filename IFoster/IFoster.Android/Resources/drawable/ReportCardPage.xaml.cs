using System;
using System.Collections.Generic;
using IFoster.ViewModel.DashBoardViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IFoster.View.DashBoardView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReportCardPage : ContentPage
    {
        private ReportCardViewModel _reportCardViewModel;

        public ReportCardPage()
        {
            InitializeComponent();

            _reportCardViewModel = new ReportCardViewModel(Navigation);

            BindingContext = _reportCardViewModel;
        }
    }
}
