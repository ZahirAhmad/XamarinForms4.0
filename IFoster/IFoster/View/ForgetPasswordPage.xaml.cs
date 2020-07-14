using IFoster.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IFoster.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForgetPasswordPage : ContentPage
    {
        private ForgetPasswordViewModel _forgetPasswordViewModel;
        public ForgetPasswordPage()
        {
            InitializeComponent();

            _forgetPasswordViewModel = new ForgetPasswordViewModel();

            BindingContext = _forgetPasswordViewModel;

        }
    }
}