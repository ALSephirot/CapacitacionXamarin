using Capacitacion.Pages;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Capacitacion.ViewModels
{
    public class MenuItemViewModel
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }

        #region Commands
        public ICommand NavigationCommand { get { return new RelayCommand(Navigate); } }


        #endregion

        public void Navigate()
        {
            App.Master.IsPresented = false;
            switch (PageName)
            {
                case "Index":
                    App.Navigator.PushAsync(new lista());
                    break;
                case "About":
                    App.Navigator.PushAsync(new About());
                    break;
                case "Contact":
                    App.Navigator.PushAsync(new Contact());
                    break;
                case "Users":
                    App.Navigator.PushAsync(new Users());
                    break;
            }
        }
    }
}
