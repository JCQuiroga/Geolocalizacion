using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Geolocator;
using Xamarin.Forms;

namespace Geolocalizacion
{
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var loc = CrossGeolocator.Current;
            var pos = await loc.GetPositionAsync();

            if (pos == null)
            {
                await this.DisplayAlert("Error", "No recibo la posicion", "OK");
                return;
            }
            TxtLat.Text = pos.Latitude.ToString();
            TxtLong.Text = pos.Longitude.ToString();
        }
    }
}
