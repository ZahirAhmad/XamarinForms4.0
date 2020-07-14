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
    public partial class GalleryPage : ContentPage
    {
        private GalleryViewModel _galleryViewModel;
        public GalleryPage()
        {
            InitializeComponent();

            _galleryViewModel = new GalleryViewModel(Navigation);

            BindingContext = _galleryViewModel;
        }
    }
}