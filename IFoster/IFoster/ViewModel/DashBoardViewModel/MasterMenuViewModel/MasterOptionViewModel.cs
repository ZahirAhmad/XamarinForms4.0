using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using IFoster.View.DashBoardView.MasterMenuView;
using Plugin.Share;
using Plugin.Share.Abstractions;
using Xamarin.Forms;

namespace IFoster.ViewModel.DashBoardViewModel.MasterMenuViewModel
{
    public class MasterOptionViewModel : BaseViewModel
    {
       

        //Commands
        public ICommand ChangePasswordPageCommand { get; private set; }
        public ICommand ChangeMobileNoPageCommand { get; private set; }
        public ICommand SwitchUserPageCommand { get; private set; }
        public ICommand RateThisAppPageCommand { get; private set; }
        public ICommand SharePageCommand { get; private set; }
        public ICommand HelpPageCommand { get; private set; }
        public ICommand LogoutPageCommand { get; private set; }

        public MasterOptionPage MasterOptionPage;

        ChangePasswordPage changePasswordPage;
        ChangeMobileNoPage changeMobileNoPage;
        SwitchUserPage switchUserPage;
        RateThisAppPage rateThisAppPage;
        SharePage sharePage;
        HelpPage helpPage;
        LogoutPage logoutPage;

        public MasterOptionViewModel()
        {
            ChangePasswordPageCommand = new Command(OnChangePasswordPageClick);
            ChangeMobileNoPageCommand = new Command(OnChangeMobileNoPageClick);
            SwitchUserPageCommand = new Command(OnSwitchUserPageClick);
            RateThisAppPageCommand = new Command(OnRateThisAppPageClick);
            SharePageCommand = new Command(OnSharePageClick);
            HelpPageCommand = new Command(OnHelpPageClick);
            LogoutPageCommand = new Command(OnLogoutPageClick);

            changePasswordPage = new ChangePasswordPage();
            changeMobileNoPage = new ChangeMobileNoPage();
            switchUserPage = new SwitchUserPage();
            rateThisAppPage = new RateThisAppPage();
            sharePage = new SharePage();
            helpPage = new HelpPage();
            logoutPage = new LogoutPage();


        }

        #region Share Event

        private void ShareMessage()
        {
            CrossShare.Current.Share(new ShareMessage
            {
                Title= "Message",
                Text ="message.Text"
            });
        }

        #endregion

        #region On Click Method

        public void OnChangePasswordPageClick()
        {
            if (MasterOptionPage != null)
            {
                MasterOptionPage.UpdateMasterDetailPage(changePasswordPage);
            }
        }
        public void OnChangeMobileNoPageClick()
        {
            if (MasterOptionPage != null)
            {
                MasterOptionPage.UpdateMasterDetailPage(changeMobileNoPage);
            }
        }
        public void OnSwitchUserPageClick()
        {
            if(MasterOptionPage != null)
            {
                MasterOptionPage.UpdateMasterDetailPage(switchUserPage);
            }
        }
        public void OnRateThisAppPageClick()
        {
            if(MasterOptionPage != null)
            {
                MasterOptionPage.UpdateMasterDetailPage(rateThisAppPage);
            }
        }
        public void OnSharePageClick()
        {
            if(MasterOptionPage != null)
            {
                ShareMessage();
            }
        }
        public void OnHelpPageClick()
        {
            if(MasterOptionPage != null)
            {
                MasterOptionPage.UpdateMasterDetailPage(helpPage);
            }
        }
        public void OnLogoutPageClick()
        {
            if(MasterOptionPage != null)
            {
                MasterOptionPage.UpdateMasterDetailPage(logoutPage);
            }
        }
        #endregion

       
    }
}
