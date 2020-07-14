using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using IFoster.Model;
using IFoster.View.DashBoard;
using IFoster.View.DashBoardView;
using Xamarin.Forms;

namespace IFoster.ViewModel.DashBoardViewModel
{
    class ResultPageViewModel : BaseViewModel
    {
       

        //Command
        public ICommand ReportCardCommand { get; set; }

        private INavigation _navigation;

        private ObservableCollection<Result> _listOfResult = new ObservableCollection<Result>();

        //Constructor
        public ResultPageViewModel(INavigation navigation)
        {
            _navigation = navigation;

            GetResult();

            ReportCardCommand = new Command(OnReportCardClick);

            
        }

        #region Property

        public ObservableCollection<Result> ListOfResult
        {
            get => _listOfResult;

            set
            {
                _listOfResult = value;

                OnPropertyChanged();
            }
        }

        #endregion

        //Method
        private void OnReportCardClick()
        {
            _navigation.PushAsync(new ReportCardPage());
        }

       
        private void GetResult()
        {
            _listOfResult.Add(new Result() { SerialNo = 1, ExamListShort = "UT", FrameColor = Color.LightGoldenrodYellow, ExamList = "Unit Test", UnitNo = 1 });
            _listOfResult.Add(new Result() { SerialNo = 1, ExamListShort = "T", FrameColor = Color.Violet, ExamList = "Term", UnitNo = 1 });
            _listOfResult.Add(new Result() { SerialNo = 3, ExamListShort = "UT", FrameColor = Color.Blue, ExamList = "Unit Test", UnitNo = 3 });
            _listOfResult.Add(new Result() { SerialNo = 2, ExamListShort = "T", FrameColor = Color.Green, ExamList = "Term", UnitNo = 3 });
        }
    }

    public class Result
    {
        public int SerialNo { get; set; }

        public string ExamListShort { get; set; }

        public Color FrameColor { get; set; }

        public string ExamList { get; set; }

        public int UnitNo { get; set; }

    }
}
