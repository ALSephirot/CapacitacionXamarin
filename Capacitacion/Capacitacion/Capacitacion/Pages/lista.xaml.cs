using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Capacitacion.Pages
{
    public partial class lista : ContentPage
    {
        public lista()
        {
            InitializeComponent();

            var opciones = new ObservableCollection<ModelList>();
            opciones.Add(new ModelList { Nombre = "Opcion 1" });
            opciones.Add(new ModelList { Nombre = "Opcion 2" });
            opciones.Add(new ModelList { Nombre = "Opcion 3" });
            opciones.Add(new ModelList { Nombre = "Opcion 4" });

            lstEjemplo.ItemsSource = opciones;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new index("Este es un mensaje enviado desde otra page"));
        }
    }

    public class ModelList
    {
        public string Nombre { get; set; }
    }
}
