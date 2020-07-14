using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace IFoster.ViewModel.DashBoardViewModel
{
    class EventProgramViewModel : BaseViewModel
    {
       

        private INavigation _navigation;

        private List<EventProgramTabType> _listOfTab = new List<EventProgramTabType>();

        //Color
        private Color _classWiseEventsLineColor = Color.Red;
        private Color _globalEventsLineColor = Color.White;

        private Color _classWiseEventsTabColor = Color.Red;
        private Color _globalEventsTabColor = Color.Black;

        //Command
        public ICommand ClassWiseEventsTabCommand { get; set; }
        public ICommand GlobalEventsTabCommand { get; set; }

        //Selected Tab Index
        private int _selectedTabIndex = 0;

        public EventProgramViewModel(INavigation navigation)
        {
            _navigation = navigation;

            ClassWiseEventsTabCommand = new Command(OnClassWiseEventsTabClick);
            GlobalEventsTabCommand = new Command(OnGlobalEventsTabClick);

            MakeTabList();
        }

        #region Handle Click Events

        private void OnClassWiseEventsTabClick()
        {
            ClassWiseEventsLineColor = Color.Red;
            GlobalEventsLineColor = Color.White;

            ClassWiseEventsTabColor = Color.Red;
            GlobalEventsTabColor = Color.Black;

            Device.BeginInvokeOnMainThread(() =>
            {
                SelectedTabIndex = 0;
            });
        }

        private void OnGlobalEventsTabClick()
        {
            ClassWiseEventsLineColor = Color.White;
            GlobalEventsLineColor = Color.Red;

            ClassWiseEventsTabColor = Color.Black;
            GlobalEventsTabColor = Color.Red;

            Device.BeginInvokeOnMainThread(() =>
            {
                SelectedTabIndex = 1;
            });
        }

        #endregion

        #region properties

        public List<EventProgramTabType> ListOfTab
        {
            get => _listOfTab;

            set
            {
                _listOfTab = value;

                OnPropertyChanged();
            }
        }

        public Color ClassWiseEventsLineColor
        {
            get => _classWiseEventsLineColor;

            set
            {
                _classWiseEventsLineColor = value;

                OnPropertyChanged();
            }
        }

        public Color GlobalEventsLineColor
        {
            get => _globalEventsLineColor;

            set
            {
                _globalEventsLineColor = value;

                OnPropertyChanged();
            }
        }

        public Color ClassWiseEventsTabColor
        {
            get => _classWiseEventsTabColor;

            set
            {
                _classWiseEventsTabColor = value;

                OnPropertyChanged();
            }
        }

        public Color GlobalEventsTabColor
        {
            get => _globalEventsTabColor;

            set
            {
                _globalEventsTabColor = value;

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
            _listOfTab.Add(EventProgramTabType.ClassWiseEvents);
            _listOfTab.Add(EventProgramTabType.GlobalEvents);
        }



       
    }

    public enum EventProgramTabType
    {
        ClassWiseEvents = 1,
        GlobalEvents = 2
    }
}
