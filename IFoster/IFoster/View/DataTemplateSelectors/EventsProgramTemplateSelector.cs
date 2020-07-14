using System;
using IFoster.View.DashBoardView.EventsProgramTab;
using IFoster.ViewModel.DashBoardViewModel;
using Xamarin.Forms;

namespace IFoster.View.DataTemplateSelectors
{
    public class EventsProgramTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ClassWiseEventsTemplate { get; set; }
        public DataTemplate GlobalEventsTemplate { get; set; }

        public EventsProgramTemplateSelector()
        {
            ClassWiseEventsTemplate = new DataTemplate(typeof(ClassWiseEventsView));
            GlobalEventsTemplate = new DataTemplate(typeof(GlobalEventsView));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            EventProgramTabType eventProgramTabType = (EventProgramTabType)item;

            switch (eventProgramTabType)
            {
                case EventProgramTabType.ClassWiseEvents:

                    return ClassWiseEventsTemplate;

                case EventProgramTabType.GlobalEvents:

                    return GlobalEventsTemplate;
            }

            return ClassWiseEventsTemplate;

        }
    }
}
