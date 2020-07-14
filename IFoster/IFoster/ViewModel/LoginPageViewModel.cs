using IFoster.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Input;
using Xamarin.Forms;
using Xunit;

namespace IFoster.ViewModel
{
    public class LoginPageViewModel : BaseViewModel

    {
        

        private int _mobileno;
        private string _password;

        private INavigation _navigation;
        

        public ICommand SignInCommand { get; set; }
        public ICommand ForgetPasswordCommand{ get; set;}


        public LoginPageViewModel(INavigation navigation)
        {
            _navigation = navigation;

            SignInCommand = new Command(OnSignInClick);
            ForgetPasswordCommand = new Command(OnForgetPasswordClick);

        }

        public int MobileNo
        {
            get => _mobileno;

            set
            {
                _mobileno = value;

                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _password;

            set
            {
                _password = value;

                OnPropertyChanged();
            }

        }

        private void OnSignInClick()
        {

        }

        private void OnForgetPasswordClick()
        {
            _navigation.PushAsync(new ForgetPasswordPage());
        }

       


       
    }
}
