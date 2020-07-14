using IFoster.ViewModel.DashBoardViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IFoster.View.DashBoard
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimeTablePage : ContentPage
    {

        private TimeTableViewModel _timeTableViewModel;

        public TimeTablePage()
        {
            InitializeComponent();

            _timeTableViewModel = new TimeTableViewModel(Navigation);

            BindingContext = _timeTableViewModel;
        }
    }
}