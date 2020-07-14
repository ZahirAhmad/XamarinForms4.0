using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using IFoster.View.DashBoardView;
using Xamarin.Forms;

namespace IFoster.ViewModel.DashBoardViewModel
{
    public class GalleryViewModel : BaseViewModel
    {
        private INavigation _navigation;

        public ICommand eventsCommand { get; set; }
        public ICommand programCommand { get; set; }
        public ICommand AcadmeicCommand { get; set; }
        public ICommand ConferenceCommand { get; set; }

        public GalleryViewModel(INavigation navigation)
        {
            _navigation = navigation;

            eventsCommand = new Command(OnGalleryEventClick);
            programCommand = new Command(OnGalleryProgramClick);
            AcadmeicCommand = new Command(OnGalleryAcademeicClick);
            ConferenceCommand = new Command(OnGalleryConferenceClick);
        }

       


        private void OnGalleryEventClick()
        {
            _navigation.PushAsync(new GalleryEventPage());
        }

        private void OnGalleryProgramClick()
        {
            _navigation.PushAsync(new GalleryProgramPage());
        }

        private void OnGalleryAcademeicClick()
        {
            _navigation.PushAsync(new GalleryAcademeicPage());
        }

        private void OnGalleryConferenceClick()
        {
            _navigation.PushAsync(new GalleryConferencePage());
        }





       
    }
}
