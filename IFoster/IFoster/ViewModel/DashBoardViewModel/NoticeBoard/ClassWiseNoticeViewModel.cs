using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace IFoster.ViewModel.DashBoardViewModel.NoticeBoard
{
    public class ClassWiseNoticeViewModel : BaseViewModel
    {
        

        private ObservableCollection<ClassWiseNotice> _listOfClassWiseNotice = new ObservableCollection<ClassWiseNotice>();

        public ClassWiseNoticeViewModel()
        {
            GetClassWiseNotice();
        }

        #region Property

        public ObservableCollection<ClassWiseNotice> ListOfClassWiseNotice
        {
            get => _listOfClassWiseNotice;

            set
            {
                _listOfClassWiseNotice = value;

                OnPropertyChanged();
            }
        }

        #endregion

        

        private void GetClassWiseNotice()
        {
            _listOfClassWiseNotice.Add(new ClassWiseNotice() { Months = "Jan" });
            _listOfClassWiseNotice.Add(new ClassWiseNotice() { Months = "Feb" });
            _listOfClassWiseNotice.Add(new ClassWiseNotice() { Months = "Mar" });
            _listOfClassWiseNotice.Add(new ClassWiseNotice() { Months = "Apr" });
            _listOfClassWiseNotice.Add(new ClassWiseNotice() { Months = "May" });
            _listOfClassWiseNotice.Add(new ClassWiseNotice() { Months = "Jun" });
            _listOfClassWiseNotice.Add(new ClassWiseNotice() { Months = "Jul" });
            _listOfClassWiseNotice.Add(new ClassWiseNotice() { Months = "Aug" });
            _listOfClassWiseNotice.Add(new ClassWiseNotice() { Months = "Sep" });
            _listOfClassWiseNotice.Add(new ClassWiseNotice() { Months = "Oct" });
            _listOfClassWiseNotice.Add(new ClassWiseNotice() { Months = "Nov" });
            _listOfClassWiseNotice.Add(new ClassWiseNotice() { Months = "Dec" });
        }

    }
    public class ClassWiseNotice
    {
        public string Months { get; set; }
    }
}
