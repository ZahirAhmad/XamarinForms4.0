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
    public partial class LoginPage : ContentPage
    {
        private LoginPageViewModel _logInPageViewModel;

        public LoginPage()
        {
            InitializeComponent();

            _logInPageViewModel = new LoginPageViewModel(Navigation);

            BindingContext = _logInPageViewModel;
        }

       
    }
}