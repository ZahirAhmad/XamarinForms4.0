using IFoster.ViewModel.DashBoardViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IFoster.View.DashBoard
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LeavePage : ContentPage
    {

        private LeavePageViewModel _leavePageViewModel;
        public LeavePage()
        {
            InitializeComponent();

            _leavePageViewModel = new LeavePageViewModel(Navigation);

            BindingContext = _leavePageViewModel;
        }

        void CarouselView_CurrentItemChanged(System.Object sender, Xamarin.Forms.CurrentItemChangedEventArgs e)
        {
            LeaveTabType leaveTabType = (LeaveTabType)e.CurrentItem;

            switch (leaveTabType)
            {
                case LeaveTabType.LeaveList:

                    _leavePageViewModel.IsLeaveListShow = true;
                    _leavePageViewModel.IsLeaveHistoryShow = false;
                    _leavePageViewModel.IsLeavePlannerShow = false;

                    _leavePageViewModel.LeaveListLineColor = Color.Red;
                    _leavePageViewModel.LeaveHistoryLineColor = Color.White;
                    _leavePageViewModel.LeavePlannerLineColor = Color.White;

                    break;

                case LeaveTabType.LeaveHistory:

                    _leavePageViewModel.IsLeaveListShow = false;
                    _leavePageViewModel.IsLeaveHistoryShow = true;
                    _leavePageViewModel.IsLeavePlannerShow = false;

                    _leavePageViewModel.LeaveListLineColor = Color.White;
                    _leavePageViewModel.LeaveHistoryLineColor = Color.Red;
                    _leavePageViewModel.LeavePlannerLineColor = Color.White;


                    break;

                case LeaveTabType.LeavePlanner:

                    _leavePageViewModel.IsLeaveListShow = false;
                    _leavePageViewModel.IsLeaveHistoryShow = false;
                    _leavePageViewModel.IsLeavePlannerShow = true;

                    _leavePageViewModel.LeaveListLineColor = Color.White;
                    _leavePageViewModel.LeaveHistoryLineColor = Color.White;
                    _leavePageViewModel.LeavePlannerLineColor = Color.Red;

                    break;
            }
        }
    }
}