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
    public partial class CommunicationPage : ContentPage
    {

        private CommunicationViewModel _communicationViewModel;
        public CommunicationPage()
        {
            InitializeComponent();

            _communicationViewModel = new CommunicationViewModel(Navigation);

            BindingContext = _communicationViewModel;
        }
    }
}