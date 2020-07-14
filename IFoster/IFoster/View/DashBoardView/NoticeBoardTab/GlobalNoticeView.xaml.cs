using System;
using System.Collections.Generic;
using IFoster.ViewModel.DashBoardViewModel.NoticeBoard;
using Xamarin.Forms;

namespace IFoster.View.DashBoardView.NoticeBoardTab
{
    public partial class GlobalNoticeView : ContentView
    {
        public GlobalNoticeViewModel _globalNoticeViewModel;

        public GlobalNoticeView()
        {
            InitializeComponent();

            _globalNoticeViewModel = new GlobalNoticeViewModel();

            BindingContext = _globalNoticeViewModel;
        }
    }
}
