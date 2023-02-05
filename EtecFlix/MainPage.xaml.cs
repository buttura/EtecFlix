using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using EtecFlix.Categorias;

namespace EtecFlix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("EtecFlix.Img.etecflix.png");
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private async void Btn_Open_Terror(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Terror());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "OK");
            }
        }
    }
}
