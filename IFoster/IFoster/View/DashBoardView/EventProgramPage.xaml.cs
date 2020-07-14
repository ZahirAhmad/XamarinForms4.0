using IFoster.ViewModel.DashBoardViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IFoster.View.DashBoardView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventProgramPage : ContentPage
    {

        private EventProgramViewModel _eventProgramViewModel;
        public EventProgramPage()
        {
            InitializeComponent();

            _eventProgramViewModel = new EventProgramViewModel(Navigation);

            BindingContext = _eventProgramViewModel;
        }

        void CarouselView_CurrentItemChanged(System.Object sender, Xamarin.Forms.CurrentItemChangedEventArgs e)
        {
            EventProgramTabType eventProgramTabType = (EventProgramTabType)e.CurrentItem;

            switch (eventProgramTabType)
            {
                case EventProgramTabType.ClassWiseEvents:

                    // Tab Line Color
                    _eventProgramViewModel.ClassWiseEventsLineColor = Color.Red;
                    _eventProgramViewModel.GlobalEventsLineColor = Color.White;

                    // Tab Title Color
                    _eventProgramViewModel.ClassWiseEventsTabColor = Color.Red;
                    _eventProgramViewModel.GlobalEventsTabColor = Color.Black;

                    break;

                case EventProgramTabType.GlobalEvents:

                    // Tab Line Color
                    _eventProgramViewModel.ClassWiseEventsLineColor = Color.White;
                    _eventProgramViewModel.GlobalEventsLineColor = Color.Red;

                    // Tab Title Color
                    _eventProgramViewModel.ClassWiseEventsTabColor = Color.Black;
                    _eventProgramViewModel.GlobalEventsTabColor = Color.Red;

                    break;

            }

        }
    }
}