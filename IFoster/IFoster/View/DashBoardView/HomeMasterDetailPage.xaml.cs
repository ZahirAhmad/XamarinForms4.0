using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IFoster.View.DashBoardView.MasterMenuView;
using Xamarin.Forms;

namespace IFoster.View.DashBoardView
{       
    public partial class HomeMasterDetailPage : MasterDetailPage

    {
        public HomeMasterDetailPage()
        {
            InitializeComponent();

            // Hide Default Toolbar
            NavigationPage.SetHasNavigationBar(this, false);

            HandleClickEvent();

        }

        /// <summary>
        /// Handles the click event.
        /// </summary>
        private void HandleClickEvent()
        {
            MasterMenuPage.ChangeDetailPage += ChangeDetailPage;
        }

        /// <summary>
        /// Changes the detail page.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="detailPage">Detail page.</param>
        public void ChangeDetailPage(object sender, Page detailPage)
        {
            HideShownavigationDrawer(false);

            // Hide Default Toolbar
            //NavigationPage.SetHasNavigationBar(detailPage, false);

            Navigation.PushAsync(detailPage);

            // For Changing Detail Page
            //Detail = new NavigationPage(detailPage);
        }

        /// <summary>
        /// Ons the appearing.
        /// </summary>
        protected override void OnAppearing()
        {
            base.OnAppearing();

            HideShownavigationDrawer(false);
        }

        /// <summary>
        /// Hides the shownavigation drawer.
        /// </summary>
        /// <param name="isShowDrawer">If set to <c>true</c> is show drawer.</param>
        public void HideShownavigationDrawer(bool isShowDrawer)
        {
            IsPresented = isShowDrawer;
        }

        protected override bool OnBackButtonPressed()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("", "Do you really want to exit from app ?", "Yes", "No");

                if (result)
                {
                    Kill();
                }

            });

            return true;
        }

        protected internal void Kill()
        {
            if (Device.Android == Device.RuntimePlatform)
            {
                DependencyService.Get<ICloseApplication>().closeApplication();
            }
            else
            {
                System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
            }

        }
    }
}
