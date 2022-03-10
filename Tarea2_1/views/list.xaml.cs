using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Tarea2_1.Controller;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace Tarea2_1.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class list : ContentPage
    {
        public int b = 0;
        public list(int a)
        {
            InitializeComponent();
            b=a;
          //  conectar();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            switch (b)
            {
                case 0:
                    ListaEmpleados.ItemsSource = await paises.ObtenerAfrica();
                    break;
                case 1: ListaEmpleados.ItemsSource = await paises.ObtenerAmerica();
                    break;
                case 2:
                    ListaEmpleados.ItemsSource = await paises.ObtenerAsia();
                    break;
                case 3:
                    ListaEmpleados.ItemsSource = await paises.ObtenerEuropa();
                    break;
                case 4:
                    ListaEmpleados.ItemsSource = await paises.ObtenerOceania();
                    break;
                default:
                    break;
                
            }



            
        }


       



        private async void ListaEmpleados_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var d = e.SelectedItem as Models.contructor.Root;
            String nam = d.name.common;
            Double la = d.latlng[0];
            Double lo = d.latlng[1];
            String dess = d.independent.ToString();

            var page = new mapa(nam,la,lo,dess);
            await Navigation.PushAsync(new NavigationPage(page));

        }
    }
}