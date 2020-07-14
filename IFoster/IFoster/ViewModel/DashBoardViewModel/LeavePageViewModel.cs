using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace IFoster.ViewModel.DashBoardViewModel
{
    class LeavePageViewModel : BaseViewModel
    {
        

        private INavigation _navigation;

        private List<LeaveTabType> _listOfTab = new List<LeaveTabType>();


        //Color
        private Color _leaveListLineColor = Color.Red;
        private Color _leaveHistoryLineColor = Color.White;
        private Color _leavePlannerLineColor = Color.White;

        private bool _isLeaveListShow = true;
        private bool _isLeaveHistoryShow = false;
        private bool _isLeavePlannerShow = false;

        //Command
        public ICommand LeaveListCommand { get; set; }
        public ICommand LeaveHistoryCommand { get; set; }
        public ICommand LeavePlannerCommand { get; set; }

        #region Constructor

        //Selected tab Index
        private int _selectedTabIndex = 0;

        public LeavePageViewModel(INavigation navigation)
        {
            _navigation = navigation;

            LeaveListCommand = new Command(OnLeaveListTabClick);
            LeaveHistoryCommand = new Command(OnLeaveHistoryTabClick);
            LeavePlannerCommand = new Command(OnLeavePlannerTabClick);

            MakeTabList();
        }

        #endregion



        #region Handle Click Events

        private void OnLeaveListTabClick()
        {
            LeaveListLineColor = Color.Red;
            LeaveHistoryLineColor = Color.White;
            LeavePlannerLineColor = Color.White;

            Device.BeginInvokeOnMainThread(() =>
            {
                SelectedTabIndex = 0;
            });
        }

        private void OnLeaveHistoryTabClick()
        {
            LeaveListLineColor = Color.White;
            LeaveHistoryLineColor = Color.Red;
            LeavePlannerLineColor = Color.White;

            Device.BeginInvokeOnMainThread(() =>
            {
                SelectedTabIndex = 1;
            });
        }

        private void OnLeavePlannerTabClick()
        {
            LeaveListLineColor = Color.White;
            LeaveHistoryLineColor = Color.White;
            LeavePlannerLineColor = Color.Red;

            Device.BeginInvokeOnMainThread(() =>
            {
                SelectedTabIndex = 2;
            });
        }

        #endregion




        #region Properties

        public List<LeaveTabType> ListOfTab
        {
            get => _listOfTab;

            set
            {
                _listOfTab = value;

                OnPropertyChanged();
            }
        }

        public Color LeaveListLineColor
        {
            get => _leaveListLineColor;

            set
            {
                _leaveListLineColor = value;

                OnPropertyChanged();
            }
        }

        public Color LeaveHistoryLineColor
        {
            get => _leaveHistoryLineColor;

            set
            {
                _leaveHistoryLineColor = value;

                OnPropertyChanged();
            }
        }

        public Color LeavePlannerLineColor
        {
            get => _leavePlannerLineColor;

            set
            {
                _leavePlannerLineColor = value;

                OnPropertyChanged();
            }
        }

        public bool IsLeaveListShow
        {
            get => _isLeaveListShow;

            set
            {
                _isLeaveListShow = value;

                OnPropertyChanged();
            }
        }

        public bool IsLeaveHistoryShow
        {
            get => _isLeaveHistoryShow;

            set
            {
                _isLeaveHistoryShow = value;

                OnPropertyChanged();
            }
        }

        public bool IsLeavePlannerShow
        {
            get => _isLeavePlannerShow;

            set
            {
                _isLeavePlannerShow = value;

                OnPropertyChanged();
            }
        }


        public int SelectedTabIndex
        {
            get => _selectedTabIndex;

            set
            {
                _selectedTabIndex = value;

                OnPropertyChanged();
            }
        }



        #endregion


        private void MakeTabList()
        {
            _listOfTab.Add(LeaveTabType.LeaveList);
            _listOfTab.Add(LeaveTabType.LeaveHistory);
            _listOfTab.Add(LeaveTabType.LeavePlanner);
        }


        


    }

    public enum LeaveTabType
    {
        LeaveList = 1,
        LeaveHistory = 2,
        LeavePlanner = 3
    }
}
