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
    public partial class HomeWorkPage : ContentPage
    {

        private HomeWorkViewModel _homeWorkViewModel;

        public HomeWorkPage()
        {
            InitializeComponent();

            _homeWorkViewModel = new HomeWorkViewModel(Navigation);

            BindingContext = _homeWorkViewModel;

        }

        void CarouselView_CurrentItemChanged(System.Object sender, Xamarin.Forms.CurrentItemChangedEventArgs e)
        {
            HomeWorkTabType homeWorkTabType = (HomeWorkTabType)e.CurrentItem;

            switch (homeWorkTabType)
            {
                case HomeWorkTabType.New:

                    // Tab Line Color
                    _homeWorkViewModel.NewLineColor = Color.Red;
                    _homeWorkViewModel.ArchiveLineColor = Color.White;

                    // Tab Title Color
                    _homeWorkViewModel.NewTabColor = Color.Red;
                    _homeWorkViewModel.ArchiveTabColor = Color.Black;

                    break;

                case HomeWorkTabType.Archive:

                    // Tab Line Color
                    _homeWorkViewModel.NewLineColor = Color.White;
                    _homeWorkViewModel.ArchiveLineColor = Color.Red;

                    // Tab Title Color
                    _homeWorkViewModel.NewTabColor = Color.Black;
                    _homeWorkViewModel.ArchiveTabColor = Color.Red;


                    break;

            }
        }
    }
}