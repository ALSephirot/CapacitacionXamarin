using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Capacitacion.Pages
{
    public partial class index : ContentPage
    {
        public string Parametro = string.Empty;
        public index(string data)
        {
            InitializeComponent();
            Parametro = data;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("alerta de prueba", Parametro, "Ok");
            //Navigation.PushAsync(new lista());
        }
   }
}
