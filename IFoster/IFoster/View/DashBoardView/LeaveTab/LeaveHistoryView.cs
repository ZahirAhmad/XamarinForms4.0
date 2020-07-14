using System;

using Xamarin.Forms;

namespace IFoster.View.DashBoardView.LeaveTab
{
    public class LeaveHistoryView : ContentPage
    {
        public LeaveHistoryView()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

