using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace IFoster.ViewModel.DashBoardViewModel
{
    class HolidayCalenderViewModel : BaseViewModel
    {

       

        private INavigation _navigation;

        private ObservableCollection<HolidayCalender> _listOfHolidayCalender = new ObservableCollection<HolidayCalender>();

        public HolidayCalenderViewModel(INavigation navigation)
        {
            _navigation = navigation;

            GetHolidayCalender();
        }

        #region Property

        public ObservableCollection<HolidayCalender> ListOfHolidayCalender
        {
            get => _listOfHolidayCalender;

            set
            {
                _listOfHolidayCalender = value;

                OnPropertyChanged();
            }
        }

        #endregion





       

        private void GetHolidayCalender()
        {
            _listOfHolidayCalender.Add(new HolidayCalender() { SerialNo = 26, Months = "Jan", FrameColor = Color.Yellow, Event = "Gazetted Holiday", EventName = "Republic Day" });
            _listOfHolidayCalender.Add(new HolidayCalender() { SerialNo = 16, Months = "Jan", FrameColor = Color.Violet, Event = "Eid", EventName = "A celebration of joy after 30 days..." });
            _listOfHolidayCalender.Add(new HolidayCalender() { SerialNo = 15, Months = "Aug", FrameColor = Color.Blue, Event = "Gazetted Holiday", EventName = "Independence Day" });
            _listOfHolidayCalender.Add(new HolidayCalender() { SerialNo = 22, Months = "Aug", FrameColor = Color.Green, Event = "Gazetted Holiday", EventName = "Id-ul-Zuha(Bakrid)" });
            _listOfHolidayCalender.Add(new HolidayCalender() { SerialNo = 26, Months = "Aug", FrameColor = Color.Yellow, Event = "Restricted Holiday", EventName = "Raksha Bandhan(Rakhi)" });
            _listOfHolidayCalender.Add(new HolidayCalender() { SerialNo = 21, Months = "Sep", FrameColor = Color.Violet, Event = "Gazetted Holiday", EventName = "Muharram/Ashura" });
            _listOfHolidayCalender.Add(new HolidayCalender() { SerialNo = 02, Months = "Oct", FrameColor = Color.Blue, Event = "Gazetted Holiday", EventName = "Mahatma Gandhi Jayanti" });
            _listOfHolidayCalender.Add(new HolidayCalender() { SerialNo = 07, Months = "Nov", FrameColor = Color.Green, Event = "Gazetted Holiday", EventName = "Diwali(Deepavali)" });
            _listOfHolidayCalender.Add(new HolidayCalender() { SerialNo = 21, Months = "Nov", FrameColor = Color.Yellow, Event = "Gazetted Holiday", EventName = "Milad-un-Nabi or Id-e-Milad" });
            _listOfHolidayCalender.Add(new HolidayCalender() { SerialNo = 25, Months = "Dec", FrameColor = Color.Violet, Event = "Christine Holiday", EventName = "Christmas Day1" });
            _listOfHolidayCalender.Add(new HolidayCalender() { SerialNo = 04, Months = "May", FrameColor = Color.Blue, Event = "Gazetted Holiday", EventName = "Due to ramadan 1st day" });
        }
    }

    public class HolidayCalender
    {
        public int SerialNo { get; set; }

        public string Months { get; set; }

        public string Event { get; set; }

        public string EventName { get; set; }

        public Color FrameColor { get; set; }
    }
}
