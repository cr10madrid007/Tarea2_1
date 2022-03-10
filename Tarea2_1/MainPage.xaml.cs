using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea2_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAfrica_Clicked(object sender, EventArgs e)
        {
            var am = new views.list(0);
            await Navigation.PushAsync(am);
        }

        private async void btnAmerica_Clicked(object sender, EventArgs e)
        {
            var am = new views.list(1);
            await Navigation.PushAsync(am);

        }

        private async void btnAsia_Clicked(object sender, EventArgs e)
        {
            var am = new views.list(2);
            await Navigation.PushAsync(am);

        }

        private async void btnEuropa_Clicked(object sender, EventArgs e)
        {
            var am = new views.list(3);
            await Navigation.PushAsync(am);
        }

        private async void btnOseania_Clicked(object sender, EventArgs e)
        {
            var am = new views.list(4);
            await Navigation.PushAsync(am);
        }
    }
}
