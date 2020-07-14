using System;
using IFoster.View.DashBoardView.HomeWorkTab;
using IFoster.ViewModel.DashBoardViewModel;
using Xamarin.Forms;

namespace IFoster.View.DataTemplateSelectors
{
    public class HomeWorkTemplateSelector : DataTemplateSelector
    {
        public DataTemplate NewTamplate { get; set; }
        public DataTemplate ArchiveTemplate { get; set; }

        public HomeWorkTemplateSelector()
        {
            NewTamplate = new DataTemplate(typeof(NewView));
            ArchiveTemplate = new DataTemplate(typeof(ArchiveView));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            HomeWorkTabType homeWorkTabType = (HomeWorkTabType)item;

            switch (homeWorkTabType)
            {
                case HomeWorkTabType.New:

                    return NewTamplate;

                case HomeWorkTabType.Archive:

                    return ArchiveTemplate;

            }

            return NewTamplate;
        }
    }
}
