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
    public partial class MedicalIdPage : ContentPage
    {
        private MedicalIdViewModel _medicalIdViewModel;
        public MedicalIdPage()
        {
            InitializeComponent();

            _medicalIdViewModel = new MedicalIdViewModel(Navigation);

            BindingContext = _medicalIdViewModel;
        }
    }
}