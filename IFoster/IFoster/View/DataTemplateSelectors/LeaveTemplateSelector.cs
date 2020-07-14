using System;
using IFoster.View.DashBoardView.LeaveTab;
using IFoster.ViewModel.DashBoardViewModel;
using Xamarin.Forms;

namespace IFoster.View.DataTemplateSelectors
{
    public class LeaveTemplateSelector : DataTemplateSelector
    {
        public DataTemplate LeaveListTemplate { get; set; }
        public DataTemplate LeaveHistoryTemplate { get; set; }
        public DataTemplate LeavePlannerTemplate { get; set; }

        public LeaveTemplateSelector()
        {
            LeaveListTemplate = new DataTemplate(typeof(LeaveListView));
            LeaveHistoryTemplate = new DataTemplate(typeof(LeaveHistoryView));
            LeavePlannerTemplate = new DataTemplate(typeof(LeavePlannerView));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {

            LeaveTabType leaveTabType = (LeaveTabType)item;

            switch (leaveTabType)
            {
                case LeaveTabType.LeaveList:

                    return LeaveListTemplate;

                case LeaveTabType.LeaveHistory:

                    return LeaveHistoryTemplate;

                case LeaveTabType.LeavePlanner:

                    return LeavePlannerTemplate;
            }

            return LeaveListTemplate;
        }

    }
}
