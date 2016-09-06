using Capacitacion.Pages;
using GalaSoft.MvvmLight.Command;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Capacitacion.ViewModels
{
    public class UsersViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public AddressViewModel address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public CompanyViewModel company { get; set; }

        public ICommand DetailCommand { get { return new RelayCommand(Navigate); } }

        private void Navigate()
        {
            App.Navigator.PushAsync(new User(this));
        }
    }

    public class AddressViewModel
    {
        public string street { get; set; }
        public string suite { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }
        public GeoViewModel geo { get; set; }
    }

    public class GeoViewModel
    {
        public string lat { get; set; }
        public string lng { get; set; }
    }

    public class CompanyViewModel
    {
        public string name { get; set; }
        public string catchPhrase { get; set; }
        public string bs { get; set; }
    }
}
