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
    public partial class AttendancePage : ContentPage
    {

        private AttendanceViewModel _attendanceViewModel;
        public AttendancePage()
        {
            InitializeComponent();

            _attendanceViewModel = new AttendanceViewModel(Navigation);

            BindingContext = _attendanceViewModel;
        }
    }
}