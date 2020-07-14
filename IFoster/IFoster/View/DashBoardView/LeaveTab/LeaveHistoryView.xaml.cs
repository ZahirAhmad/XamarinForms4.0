using System;
using System.Collections.Generic;
using IFoster.ViewModel.DashBoardViewModel;
using Xamarin.Forms;

namespace IFoster.View.DashBoardView.LeaveTab
{
    public partial class LeaveHistoryView : ContentView
    {
        public LeaveHistoryViewModel _leaveHistoryViewModel;

        public LeaveHistoryView()
        {
            InitializeComponent();

            _leaveHistoryViewModel = new LeaveHistoryViewModel();

            //BindingContext = _leaveHistoryViewModel;

            list.ItemsSource = _leaveHistoryViewModel.ListOfLeaveHistory;

            

        }
    }
}
