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
    public partial class NoticeBoardPage : ContentPage
    {

        private NoticeBoardViewModel _noticeBoardViewModel;

        public NoticeBoardPage()
        {
            InitializeComponent();

            _noticeBoardViewModel = new NoticeBoardViewModel(Navigation);

            BindingContext = _noticeBoardViewModel;
        }

        void CarouselView_CurrentItemChanged(System.Object sender, Xamarin.Forms.CurrentItemChangedEventArgs e)
        {
            NoticeBoardTabType noticeBoardTabType = (NoticeBoardTabType)e.CurrentItem;

            switch (noticeBoardTabType)
            {
                case NoticeBoardTabType.ClassWiseNotice:

                    //Tab Line Color
                    _noticeBoardViewModel.ClassWiseNoticeLineColor = Color.Red;
                    _noticeBoardViewModel.GlobalNoticeLineColor = Color.White;

                    //Tab Title Color

                    _noticeBoardViewModel.ClassWiseNoticeTabColor = Color.Red;
                    _noticeBoardViewModel.GlobalNoticeTabColor = Color.Black;

                    break;

                case NoticeBoardTabType.GlobalNotice:

                    //Tab Line Color
                    _noticeBoardViewModel.ClassWiseNoticeLineColor = Color.White;
                    _noticeBoardViewModel.ClassWiseNoticeLineColor = Color.Red;

                    //Tab Title Color
                    _noticeBoardViewModel.ClassWiseNoticeTabColor = Color.Black;
                    _noticeBoardViewModel.GlobalNoticeTabColor = Color.Red;

                    break;

            }
        }
    }
}