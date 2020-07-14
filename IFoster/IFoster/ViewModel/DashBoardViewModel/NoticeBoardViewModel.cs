using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace IFoster.ViewModel.DashBoardViewModel
{
    internal class NoticeBoardViewModel : BaseViewModel
    {
        

        private INavigation _navigation;

        private List<NoticeBoardTabType> _listOfTab = new List<NoticeBoardTabType>();

       

        //Color
        private Color _classWiseNoticeLineColor = Color.Red;
        private Color _globalNoticeLineColor = Color.White;

        private Color _classWiseNoticeTabColor = Color.Red;
        private Color _globalNoticeTabColor = Color.Black;

        //Command
        public ICommand ClassWiseNoticeTabCommand { get; set; }
        public ICommand GlobalNoticeTabCommand { get; set; }

        //Selected tab Index
        private int _selectedTabIndex = 0;

        public NoticeBoardViewModel(INavigation navigation)
        {
            _navigation = navigation;

            ClassWiseNoticeTabCommand = new Command(OnClassWiseNoticeTabClick);
            GlobalNoticeTabCommand = new Command(OnGlobalNoticeTabClick);

            MakeTabList();

            
        }

        #region Handle Click Events

        private void OnClassWiseNoticeTabClick()
        {
            ClassWiseNoticeLineColor = Color.Red;
            GlobalNoticeLineColor = Color.White;

            ClassWiseNoticeTabColor = Color.Red;
            GlobalNoticeTabColor = Color.Black;

            Device.BeginInvokeOnMainThread(() =>
            {
                SelectedTabIndex = 0;
            });
        }

        private void OnGlobalNoticeTabClick()
        {
            ClassWiseNoticeLineColor = Color.White;
            GlobalNoticeLineColor = Color.Red;

            ClassWiseNoticeTabColor = Color.Black;
            GlobalNoticeTabColor = Color.Red;

            Device.BeginInvokeOnMainThread(() =>
            {
                _selectedTabIndex = 1;
            });
        }

        #endregion

        #region Properties

        public List<NoticeBoardTabType> ListOfTab
        {
            get => _listOfTab;

            set
            {
                _listOfTab = value;

                OnPropertyChanged();
            }
        }

        public Color ClassWiseNoticeLineColor
        {
            get => _classWiseNoticeLineColor;

            set
            {
                _classWiseNoticeLineColor = value;

                OnPropertyChanged();
            }
        }

        public Color GlobalNoticeLineColor
        {
            get => _globalNoticeLineColor;

            set
            {
                _globalNoticeLineColor = value;

                OnPropertyChanged();
            }
        }

        public Color ClassWiseNoticeTabColor
        {
            get => _classWiseNoticeTabColor;

            set
            {
                _classWiseNoticeTabColor = value;

                OnPropertyChanged();
            }
        }

        public Color GlobalNoticeTabColor
        {
            get => _globalNoticeTabColor;
            set
            {
                _globalNoticeTabColor = value;

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
            _listOfTab.Add(NoticeBoardTabType.ClassWiseNotice);
            _listOfTab.Add(NoticeBoardTabType.GlobalNotice);
        }

       

       
    }

    public enum NoticeBoardTabType
    {
        ClassWiseNotice = 1,
        GlobalNotice = 2
    }

   
}
