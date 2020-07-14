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
    public partial class AchievementPage : ContentPage
    {
        private AchievementViewModel _achievementViewModel;
        public AchievementPage()
        {
            InitializeComponent();

            _achievementViewModel = new AchievementViewModel(Navigation);

            BindingContext = _achievementViewModel;
        }
    }
}