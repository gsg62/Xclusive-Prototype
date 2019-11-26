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
    public partial class OpeningPage : ContentPage
    {
        public OpeningPage()
        {
            InitializeComponent();
        }

        async void GoToLoginPage(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new NavigationPage(new LoginPage()));
        }
    }
}