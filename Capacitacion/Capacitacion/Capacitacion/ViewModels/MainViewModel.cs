using Capacitacion.Pages;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Capacitacion.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            LoadMenu();
        }

        public ObservableCollection<MenuItemViewModel> Menu { get; set; }



        #region LoadData
        private void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();

            Menu.Add(new MenuItemViewModel()
            {
                Icon = "icon",
                Title = "Home",
                PageName = "Index"
            });

            Menu.Add(new MenuItemViewModel()
            {
                Icon = "icon",
                Title = "About Us",
                PageName = "About"
            });

            Menu.Add(new MenuItemViewModel()
            {
                Icon = "icon",
                Title = "Contact",
                PageName = "Contact"
            });
        }
        #endregion


        #region Commands
        public ICommand GoToCommand { get { return new RelayCommand<string>(GoTo);  } }


        #endregion

        private void GoTo(string PageName)
        {
            switch (PageName)
            {
                case "Home":
                    App.Navigator.PushAsync(new lista());
                    break;
                case "About":
                    App.Navigator.PushAsync(new About());
                    break;
                case "Contact":
                    App.Navigator.PushAsync(new Contact());
                    break;
            }
        }
    }
}
