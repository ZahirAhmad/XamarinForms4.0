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
    public partial class ResultPage : ContentPage
    {
        private ResultPageViewModel _resultPageViewModel;
        public ResultPage()
        {
            InitializeComponent();

            _resultPageViewModel = new ResultPageViewModel(Navigation);

            BindingContext = _resultPageViewModel;
        }
    }
}