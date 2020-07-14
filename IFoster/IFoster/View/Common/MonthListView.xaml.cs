using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IFoster.View.Common
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MonthListView : ContentView
    {
        public MonthListView()
        {
            InitializeComponent();
        }
    }
}