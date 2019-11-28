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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void BackToLanding(object sender, EventArgs args)
        {
            await Application.Current.MainPage.Navigation.PopAsync();
            //   await Navigation.PushModalAsync(new NavigationPage(new LoginPage()));
        }

        async void GoToHomePage(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new NavigationPage(new MainMasterDetailPage()));
        }
    }
}