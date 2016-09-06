using Capacitacion.Pages;
using Capacitacion.Services;
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
            LoadUsers();
        }

        public ObservableCollection<MenuItemViewModel> Menu { get; set; }
        public ObservableCollection<UsersViewModel> Users { get; set; }



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

            Menu.Add(new MenuItemViewModel()
            {
                Icon = "icon",
                Title = "Users",
                PageName = "Users"
            });
        }

        private async void LoadUsers()
        {
            var apiService = new ApiService();
            var result = await apiService.GetData<ObservableCollection<UsersViewModel>>("http://jsonplaceholder.typicode.com/users");
            Users = result;
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
