using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace IFoster.ViewModel.DashBoardViewModel
{
    public class LeaveHistoryViewModel : BaseViewModel
    {

       

        private ObservableCollection<LeaveHistory> _listOfLeaveHistory = new ObservableCollection<LeaveHistory>();

        public LeaveHistoryViewModel()
        {
            GetLeaveHistory();
        }

        #region Property

        public ObservableCollection<LeaveHistory> ListOfLeaveHistory
        {
            get => _listOfLeaveHistory;

            set
            {
                _listOfLeaveHistory = value;

                OnPropertyChanged();
            }
        }

        #endregion



       

        private void GetLeaveHistory()
        {
            _listOfLeaveHistory.Add(new LeaveHistory() { SerialNo = 28, Months = "Jan", FrameColor = Color.Brown, Reason = "Medical", Date=DateTime.Now, ReasonName="i need 6 day" });
            _listOfLeaveHistory.Add(new LeaveHistory() { SerialNo = 10, Months = "May", FrameColor = Color.Yellow, Reason = "Personal", Date = DateTime.Now, ReasonName = "Going on a family trip" });
            _listOfLeaveHistory.Add(new LeaveHistory() { SerialNo = 24, Months = "Aug", FrameColor = Color.Blue, Reason = "Personal", Date = DateTime.Now, ReasonName = "Going on a family trip" });
            _listOfLeaveHistory.Add(new LeaveHistory() { SerialNo = 13, Months = "Aug", FrameColor = Color.Red, Reason = "Medical", Date = DateTime.Now, ReasonName = "i am sick" });
            _listOfLeaveHistory.Add(new LeaveHistory() { SerialNo = 11, Months = "Aug", FrameColor = Color.Green, Reason = "Medical", Date = DateTime.Now, ReasonName = "i need 6 day" });
            _listOfLeaveHistory.Add(new LeaveHistory() { SerialNo = 07, Months = "Sep", FrameColor = Color.Aqua, Reason = "Emergency", Date = DateTime.Now, ReasonName = "Heart attack" });
            _listOfLeaveHistory.Add(new LeaveHistory() { SerialNo = 06, Months = "Sep", FrameColor = Color.PaleGoldenrod, Reason = "Medical", Date = DateTime.Now, ReasonName = "i need 6 day" });
            _listOfLeaveHistory.Add(new LeaveHistory() { SerialNo = 04, Months = "Oct", FrameColor = Color.SaddleBrown, Reason = "Emergency", Date = DateTime.Now, ReasonName = "i am sick" });
            _listOfLeaveHistory.Add(new LeaveHistory() { SerialNo = 28, Months = "Nov", FrameColor = Color.Firebrick, Reason = "Medical", Date = DateTime.Now, ReasonName = "sdjhkdskf" });
            _listOfLeaveHistory.Add(new LeaveHistory() { SerialNo = 26, Months = "Dec", FrameColor = Color.Honeydew, Reason = "Personal", Date = DateTime.Now, ReasonName = "jsdfdskjfsd" });
        }
    }

    public class LeaveHistory
    {
        public int SerialNo { get; set; }

        public string Months { get; set; }

        public Color FrameColor { get; set; }

        public string Reason { get; set; }

        public DateTime Date { get; set; }

        public string ReasonName { get; set; }

        

    }


}
