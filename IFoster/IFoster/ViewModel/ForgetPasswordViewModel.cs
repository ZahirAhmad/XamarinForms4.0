using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace IFoster.ViewModel
{
    class ForgetPasswordViewModel : BaseViewModel
    {
        

        private string _mobileno;

        public ICommand ContinueCommand { get; set; }

        public ForgetPasswordViewModel()
        {
            ContinueCommand = new Command(OnContinueClick);
        }

        public string MobileNo
        {
            get => _mobileno;

            set
            {
                _mobileno = value;

                OnPropertyChanged();
            }
        }


        private void OnContinueClick()
        {

        }
       

       
    }
}
