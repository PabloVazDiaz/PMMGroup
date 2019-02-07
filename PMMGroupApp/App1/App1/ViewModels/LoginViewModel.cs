using App1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private List<User> _users;
        public List<User> Users
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value; OnPropertyChanged("Users");
            }
        }

        public LoginViewModel()
        {
            //TODO inicializar servicio que traiga la lista de users
        }

    }
}
