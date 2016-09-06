using Capacitacion.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Capacitacion.Pages
{
    public partial class User : ContentPage
    {
        public User(UsersViewModel usuario)
        {
            InitializeComponent();
            this.BindingContext = usuario;
        }
    }
}
