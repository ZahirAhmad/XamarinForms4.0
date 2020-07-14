using System;
using System.Collections.Generic;
using IFoster.ViewModel.DashBoardViewModel.NoticeBoard;
using Xamarin.Forms;

namespace IFoster.View.DashBoardView.NoticeBoardTab
{
    public partial class ClassWiseNoticeView : ContentView
    {
        public ClassWiseNoticeViewModel _classWiseNoticeViewModel;

        public ClassWiseNoticeView()
        {
            InitializeComponent();

            _classWiseNoticeViewModel = new ClassWiseNoticeViewModel();

            //BindingContext = _classWiseNoticeViewModel;

            list.ItemsSource = _classWiseNoticeViewModel.ListOfClassWiseNotice;
        }
    }
}
