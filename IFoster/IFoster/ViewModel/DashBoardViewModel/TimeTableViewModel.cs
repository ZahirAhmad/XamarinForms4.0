using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace IFoster.ViewModel.DashBoardViewModel
{
    class TimeTableViewModel : BaseViewModel
    {
        private INavigation _navigation;

        private ObservableCollection<Day> _listOfDay = new ObservableCollection<Day>();

        private ObservableCollection<TimeTable> _listOfTimeTable = new ObservableCollection<TimeTable>();
        



        public TimeTableViewModel(INavigation navigation)
        {
            _navigation = navigation;

            GetDay();

            GetTimeTable();

        }


        #region Properties

        public ObservableCollection<Day> ListOfDay
        {
            get => _listOfDay;

            set
            {
                _listOfDay = value;

                OnPropertyChanged();
            }
        }

        public ObservableCollection<TimeTable> ListOfTimeTable
        {
            get => _listOfTimeTable;

            set
            {
                _listOfTimeTable = value;

                OnPropertyChanged();
            }
        }

        

        #endregion

       

        private void GetDay()
        {
            _listOfDay.Add(new Day() { AllDay = "Mon" });
            _listOfDay.Add(new Day() { AllDay = "Tue" });
            _listOfDay.Add(new Day() { AllDay = "Wed" });
            _listOfDay.Add(new Day() { AllDay = "Thu" });
            _listOfDay.Add(new Day() { AllDay = "Fri" });
            _listOfDay.Add(new Day() { AllDay = "Sat" });



        }

        private void GetTimeTable()
        {
            _listOfTimeTable.Add(new TimeTable() { SeriolNo = 1, FrameColor = Color.Yellow,Time = DateTime.Now, Subject = "Hindi", TeacherName = "Alam" });
            _listOfTimeTable.Add(new TimeTable() { SeriolNo = 2, FrameColor = Color.Red,Time = DateTime.Now, Subject = "English", TeacherName = "Faiyaz" });
            _listOfTimeTable.Add(new TimeTable() { SeriolNo = 3, FrameColor = Color.Green,Time = DateTime.Now, Subject = "Math", TeacherName = "Zahir" });
            _listOfTimeTable.Add(new TimeTable() { SeriolNo = 4, FrameColor = Color.Pink,Time = DateTime.Now, Subject = "Chemistery", TeacherName = "Aiyaz" });
            _listOfTimeTable.Add(new TimeTable() { SeriolNo = 5, FrameColor = Color.Violet,Time = DateTime.Now, Subject = "Physics", TeacherName = "Nitin" });
        }

        
    }

    

    public class Day
    {
        public string AllDay { get; set; }
    }

    public class TimeTable
    {
        public int SeriolNo { get; set; }

        public DateTime Time { get; set; }

        public string Subject { get; set; }

        public string TeacherName { get; set; }

        public Color FrameColor { get; set; }
    }

    
}
