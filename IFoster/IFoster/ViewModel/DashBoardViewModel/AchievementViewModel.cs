using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace IFoster.ViewModel.DashBoardViewModel
{
    class AchievementViewModel : BaseViewModel
    {
       
        private INavigation _navigation;

        private ObservableCollection<Achievement> _listOfAchievement = new ObservableCollection<Achievement>();

        public AchievementViewModel(INavigation navigation)
        {
            _navigation = navigation;

            GetAchievement();
        }


        #region Property

        public ObservableCollection<Achievement> ListOfAchievement
        {
            get => _listOfAchievement;

            set
            {
                _listOfAchievement = value;

                OnPropertyChanged();
            }
        }

        #endregion









       

        private void GetAchievement()
        {
            _listOfAchievement.Add(new Achievement() { SportsName = "Sports", Date = DateTime.Now, Description = "Nothing" });
            _listOfAchievement.Add(new Achievement() { SportsName = "Sports", Date = DateTime.Now, Description = "Tanweer won the gold medal in long" });
            _listOfAchievement.Add(new Achievement() { SportsName = "Education", Date = DateTime.Now, Description = "Zafiaha got 1st position in English lang" });
        }

    }
     public class Achievement
    {
        public string SportsName { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }
    }
}
