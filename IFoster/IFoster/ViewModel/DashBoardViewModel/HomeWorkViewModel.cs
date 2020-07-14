using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using IFoster.View.DashBoardView;
using Xamarin.Forms;

namespace IFoster.ViewModel.DashBoardViewModel
{
    class HomeWorkViewModel : BaseViewModel
    {
       

        private INavigation _navigation;

        private List<HomeWorkTabType> _listOfTab = new List<HomeWorkTabType>();

        //Color
        private Color _newLineColor = Color.Red;
        private Color _archiveLineColor = Color.White;

        private Color _newTabColor = Color.Red;
        private Color _archiveTabColor = Color.Black;

        // Command
        public ICommand NewTabCommand { get; set; }
        public ICommand ArchiveTabCommand { get; set; }

        // Selected Tab Index
        private int _selectedTabIndex = 0;

        public HomeWorkViewModel(INavigation navigation)
        {
            _navigation = navigation;

            NewTabCommand = new Command(OnNewTabClick);
            ArchiveTabCommand = new Command(OnArchiveTabClick);

            MakeTabList();
        }


        #region Handle Click Events

        private void OnNewTabClick()
        {
            NewLineColor = Color.Red;
            ArchiveLineColor = Color.White;

            NewTabColor = Color.Red;
            ArchiveTabColor = Color.Black;

            Device.BeginInvokeOnMainThread(() =>
            {
                SelectedTabIndex = 0;
            });
            
        }

        private void OnArchiveTabClick()
        {
            NewLineColor = Color.White;
            ArchiveLineColor = Color.Red;

            NewTabColor = Color.Black;
            ArchiveTabColor = Color.Red;

            Device.BeginInvokeOnMainThread(() =>
            {
                SelectedTabIndex = 1;
            });
        }


        #endregion


        #region Properties

        public List<HomeWorkTabType> ListOfTab
        {
            get => _listOfTab;

            set
            {
                _listOfTab = value;

                OnPropertyChanged();
            }
        }


        public Color NewLineColor
        {
            get => _newLineColor;

            set
            {
                _newLineColor = value;

                OnPropertyChanged();
            }
        }

        public Color ArchiveLineColor
        {
            get => _archiveLineColor;

            set
            {
                _archiveLineColor = value;

                OnPropertyChanged();
            }
        }

        public Color NewTabColor
        {
            get => _newTabColor;

            set
            {
                _newTabColor = value;

                OnPropertyChanged();
            }
        }

        public Color ArchiveTabColor
        {
            get => _archiveTabColor;

            set
            {
                _archiveTabColor = value;

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
            _listOfTab.Add(HomeWorkTabType.New);
            _listOfTab.Add(HomeWorkTabType.Archive);
        }

        
    }

    public enum HomeWorkTabType
    {
        New = 1,
        Archive = 2
    }
}
