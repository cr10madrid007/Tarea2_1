using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Plugin.Geolocator;
using Xamarin.Forms.Maps;

namespace Tarea2_1.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class mapa : ContentPage
    {

        Double lat;
        Double lon;
        String des;
        String nombre;

        public mapa(String nn, Double l, Double ll, String d)
        {
            InitializeComponent();

            nombre= nn;
            des = d;
            lat = l;
            lon = ll;

        }

        protected override async void OnAppearing()
        {


            String d = "¿Es Independiente? " + des;
            

            

            base.OnAppearing();
            Pin ubicacion = new Pin();
            ubicacion.Label = nombre;
            ubicacion.Address = d;
            ubicacion.Position = new Position(Convert.ToDouble(lat), Convert.ToDouble(lon));
            Mapa.Pins.Add(ubicacion);


            Mapa.MoveToRegion(new MapSpan(new Position(Convert.ToDouble(lat), Convert.ToDouble(lon)), 1, 1));



            
        }

       
    }
}