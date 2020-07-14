using System;
using System.Collections.Generic;
using IFoster.ViewModel.DashBoardViewModel;
using Xamarin.Forms;

namespace IFoster.View.DashBoardView
{
    public partial class HolidayCalenderPageNew : ContentPage
    {
        private HolidayCalenderViewModel _holidayCalenderViewModel;

        public HolidayCalenderPageNew()
        {
            InitializeComponent();

            _holidayCalenderViewModel = new HolidayCalenderViewModel(Navigation);

            BindingContext = _holidayCalenderViewModel;
        }
    }
}
