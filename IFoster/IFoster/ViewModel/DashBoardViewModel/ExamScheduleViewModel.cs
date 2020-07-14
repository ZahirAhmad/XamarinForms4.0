using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace IFoster.ViewModel.DashBoardViewModel
{
    class ExamScheduleViewModel : BaseViewModel
    {
        private INavigation _navigation;

        private ObservableCollection<ExamSchedule> _listOfExamSchedule = new ObservableCollection<ExamSchedule>();

        public ExamScheduleViewModel(INavigation navigation)
        {
            _navigation = navigation;

            GetExamSchedule();
        }

        #region Property

        public ObservableCollection<ExamSchedule> ListOfExamSchedule
        {
            get => _listOfExamSchedule;

            set
            {
                _listOfExamSchedule = value;

                OnPropertyChanged();
            }
        }

        #endregion

       

        private void GetExamSchedule()
        {
            _listOfExamSchedule.Add(new ExamSchedule() { SerialNo = 1, Months = "Jul", FrameColor=Color.Red, BookName = "ABC Songs", Date = DateTime.Now, Time = DateTime.Now });
            _listOfExamSchedule.Add(new ExamSchedule() { SerialNo = 2, Months = "Jul", FrameColor = Color.Violet, BookName = "Mental Math", Date = DateTime.Now, Time = DateTime.Now });
        }
    }

    public class ExamSchedule
    {
        public int SerialNo { get; set; }

        public string BookName { get; set; }

        public DateTime Date { get; set; }

        public DateTime Time { get; set; }

        public Color FrameColor { get; set; }

        public string Months { get; set; }
    }
}
