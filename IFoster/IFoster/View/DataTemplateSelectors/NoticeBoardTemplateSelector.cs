using System;
using IFoster.View.DashBoardView.EventsProgramTab;
using IFoster.ViewModel.DashBoardViewModel;
using Xamarin.Forms;

namespace IFoster.View.DataTemplateSelectors
{
    public class NoticeBoardTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ClassWiseNoticeTemplate { get; set; }
        public DataTemplate GlobalNoticeTemplate { get; set; }

        public NoticeBoardTemplateSelector()
        {
            ClassWiseNoticeTemplate = new DataTemplate(typeof(ClassWiseEventsView));
            GlobalNoticeTemplate = new DataTemplate(typeof(GlobalEventsView));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {

            NoticeBoardTabType noticeBoardTabType = (NoticeBoardTabType)item;

            switch (noticeBoardTabType)
            {
                case NoticeBoardTabType.ClassWiseNotice:

                    return ClassWiseNoticeTemplate;

                case NoticeBoardTabType.GlobalNotice:

                    return GlobalNoticeTemplate;
            }

            return ClassWiseNoticeTemplate;
        }
    }
}
