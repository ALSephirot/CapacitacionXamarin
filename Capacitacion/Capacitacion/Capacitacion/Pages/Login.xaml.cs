using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Capacitacion.Pages
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(txtEmail.Text != "asdasd.com")
            {
                DisplayAlert("Error Usuario", "El correo electrónico es incorrecto", "Ok");
            }
            else if(txtPassword.Text != "12345")
            {
                DisplayAlert("Error Password", "La contraseña es incorrecta", "Ok");
            }
            else
            {
                App.Current.MainPage = new MasterPage();
            }
        }
    }
}
