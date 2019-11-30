using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PartyEZ_prototype.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMasterDetailPage : MasterDetailPage
    {
        public MainMasterDetailPage()
        {
            InitializeComponent();
            navigationDrawerList.ItemsSource = GetMasterPageLists();
        }

        private void OnMenuSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageList)e.SelectedItem;

            if (item.Title == "Settings")
            {
                Detail = new NavigationPage(new SettingsPage());
                IsPresented = false;
            }
            if (item.Title == "Home")
            {
                Detail = new NavigationPage(new HomeTabbedPage());
                IsPresented = false;
            }
            if (item.Title == "Profile")
            {
                Detail = new NavigationPage(new ProfilePage());
                IsPresented = false;
            }
            else
            {
                //Application.Current.Properties["MenuName"] = item.Title;
                Detail = new NavigationPage(new HomeTabbedPage());
                IsPresented = false;
            }
        }
        List<MasterPageList> GetMasterPageLists()
        {
            return new List<MasterPageList>
            {
                new MasterPageList() { Title = "Home" },// Icon = "home.png" },
                new MasterPageList() { Title = "Profile" },// Icon = "home.png" },
                new MasterPageList() { Title = "Messaging" },// Icon = "admin.png" },
                new MasterPageList() { Title = "Setting" }, //Icon = "setting.png" }
            };
        }
    }

    //This class used for binding ListView. We can move it to other separate files as well   
    public class MasterPageList
    {
        public string Title { get; set; }
        public string Icon { get; set; }
    }
}