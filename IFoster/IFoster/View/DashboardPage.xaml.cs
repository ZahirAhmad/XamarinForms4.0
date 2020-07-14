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
    public partial class DashboardPage : ContentPage
    {
        private object _dashboardPageViewModel;

        public DashboardPage()
        {
            InitializeComponent();

            // Hide Default Toolbar
            NavigationPage.SetHasNavigationBar(this, false);

            _dashboardPageViewModel = new DashboardPageViewModel(Navigation);

            BindingContext = _dashboardPageViewModel;

           

        }

        public Action<object, ContentPage> ChangeDetailPage { get; internal set; }
    }
}