using IFoster.View;
using IFoster.View.DashBoardView;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace IFoster
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomeMasterDetailPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }


        void OnHamburgerClick(System.Object sender, System.EventArgs e)
        {
            Page currPage = null;

            if (Application.Current.MainPage.Navigation.NavigationStack.Count > 0)
            {
                //LIFO is the only game in town! - so send back the last page

                int index = Application.Current.MainPage.Navigation.NavigationStack.Count - 1;

                currPage = Application.Current.MainPage.Navigation.NavigationStack[index];

            }

            if (currPage!=null && (currPage is HomeMasterDetailPage))
            {
                HomeMasterDetailPage homeMasterDetailPage = currPage as HomeMasterDetailPage;
                homeMasterDetailPage.IsPresented = !homeMasterDetailPage.IsPresented;
            }
            else
            {
                App.Current.MainPage.Navigation.PopAsync();
            }
        }

        void OnBackClick(System.Object sender, System.EventArgs e)
        {
           
        }
    }
}
