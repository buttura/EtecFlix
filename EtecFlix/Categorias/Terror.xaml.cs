using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using EtecFlix.Filmes;
namespace EtecFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Terror : ContentPage
    {
        public Terror()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("EtecFlix.Img.terror.png");
            btnOgrito.Source = ImageSource.FromResource("EtecFlix.Posters.ogrito.jpg");
        }
        private async void Btn_Open_Ogrito(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Ogrito());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "OK");
            }
        }
    }
}