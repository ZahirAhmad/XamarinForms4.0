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
    public partial class RouteLocaterPage : ContentPage
    {

        private RouteLocatorViewModel _routeLocatorViewModel;
        public RouteLocaterPage()
        {
            InitializeComponent();

            _routeLocatorViewModel = new RouteLocatorViewModel(Navigation);

            BindingContext = _routeLocatorViewModel;
        }
    }
}