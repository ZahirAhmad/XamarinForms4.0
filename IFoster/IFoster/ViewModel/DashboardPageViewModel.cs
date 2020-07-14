using IFoster.View.DashBoard;
using IFoster.View.DashBoardView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace IFoster.ViewModel
{
    public class DashboardPageViewModel : BaseViewModel
    {
        

        private INavigation _navigation;

        public ICommand HomeworkCommand { get; set; }
        public ICommand NoticeBoardCommand { get; set; }
        public ICommand EventsProgramCommand { get; set; }
        public ICommand AttendanceCommand { get; set; }
        public ICommand FeeCommand { get; set; }
        public ICommand ResultCommand { get; set; }
        public ICommand LeaveCommand { get; set; }
        public ICommand ExamScheduleCommand { get; set; }
        public ICommand TimeTableCommand { get; set; }
        public ICommand HolidayCalenderCommand { get; set; }
        public ICommand MedicalIdCommand { get; set; }
        public ICommand AchievementCommand { get; set; }
        public ICommand GalleryCommand { get; set; }
        public ICommand CommunicationCommand { get; set; }
        public ICommand RouteLocatorCommand { get; set; }


        public DashboardPageViewModel(INavigation navigation)
        {
            _navigation = navigation;


            HomeworkCommand = new Command(OnHomeWorkClick);
            NoticeBoardCommand = new Command(OnNoticeBoardClick);
            EventsProgramCommand = new Command(OnEventProgram);
            AttendanceCommand = new Command(OnAttendanceClick);
            FeeCommand = new Command(OnFeeClick);
            ResultCommand = new Command(OnResultClick);
            LeaveCommand = new Command(OnLeaveClick);
            ExamScheduleCommand = new Command(OnExamScheduleClick);
            TimeTableCommand = new Command(OnTimeTableClick);
            HolidayCalenderCommand = new Command(OnHolidayCalenderClick);
            MedicalIdCommand = new Command(OnMedicalIdClick);
            AchievementCommand = new Command(OnAchievementClick);
            GalleryCommand = new Command(OnGalleryClick);
            CommunicationCommand = new Command(OnCommunicationClick);
            RouteLocatorCommand = new Command(OnRouteLocatorClick);
        }




        private void OnHomeWorkClick()
        {
            _navigation.PushAsync(new HomeWorkPage());
        }
        private void OnNoticeBoardClick()
        {
            _navigation.PushAsync(new NoticeBoardPage());
        }
        private void OnEventProgram()
        {
            _navigation.PushAsync(new EventProgramPage());
        }
        private void OnAttendanceClick()
        {
            _navigation.PushAsync(new AttendancePage());
        }
        private void OnFeeClick()
        {
            _navigation.PushAsync(new FeePage());
        }
        private void OnResultClick()
        {
            _navigation.PushAsync(new ResultPage());
        }
        private void OnLeaveClick()
        {
            _navigation.PushAsync(new LeavePage());
        }
        private void OnExamScheduleClick()
        {
            _navigation.PushAsync(new ExamSchedulePage());
        }
        private void OnTimeTableClick()
        {
            _navigation.PushAsync(new TimeTablePage());
        }
        private void OnHolidayCalenderClick()
        {
            _navigation.PushAsync(new HolidayCalenderPageNew());
        }
        private void OnMedicalIdClick()
        {
            _navigation.PushAsync(new MedicalIdPage());
        }
        private void OnAchievementClick()
        {
            _navigation.PushAsync(new AchievementPage());
        }
        private void OnGalleryClick()
        {
            _navigation.PushAsync(new GalleryPage());
        }
        private void OnCommunicationClick()
        {
            _navigation.PushAsync(new CommunicationPage());
        }
        private void OnRouteLocatorClick()
        {
            _navigation.PushAsync(new RouteLocaterPage());
        }

        

       
    }
}
