using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace IFoster.ViewModel.DashBoardViewModel.NoticeBoard
{
    public class GlobalNoticeViewModel : BaseViewModel
    {
        

        private ObservableCollection<GlobalNotice> _listOfGlobalNotice = new ObservableCollection<GlobalNotice>();

        public GlobalNoticeViewModel()
        {
            GetGlobalNotice();
        }

        #region Property

        private ObservableCollection<GlobalNotice> ListOfGlobalNotice
        {
            get => _listOfGlobalNotice;

            set
            {
                _listOfGlobalNotice = value;

                OnPropertyChanged();
            }
        }

        #endregion

       

        private void GetGlobalNotice()
        {
            _listOfGlobalNotice.Add(new GlobalNotice() { Months = "Jan" });
            _listOfGlobalNotice.Add(new GlobalNotice() { Months = "Feb" });
            _listOfGlobalNotice.Add(new GlobalNotice() { Months = "Mar" });
            _listOfGlobalNotice.Add(new GlobalNotice() { Months = "Apr" });
            _listOfGlobalNotice.Add(new GlobalNotice() { Months = "May" });
            _listOfGlobalNotice.Add(new GlobalNotice() { Months = "Jun" });
            _listOfGlobalNotice.Add(new GlobalNotice() { Months = "Jul" });
            _listOfGlobalNotice.Add(new GlobalNotice() { Months = "Aug" });
            _listOfGlobalNotice.Add(new GlobalNotice() { Months = "Sep" });
            _listOfGlobalNotice.Add(new GlobalNotice() { Months = "Oct" });
            _listOfGlobalNotice.Add(new GlobalNotice() { Months = "Nov" });
            _listOfGlobalNotice.Add(new GlobalNotice() { Months = "Dec" });
        }

    }

    public class GlobalNotice
    {
        public string Months { get; set; }
    }
}
