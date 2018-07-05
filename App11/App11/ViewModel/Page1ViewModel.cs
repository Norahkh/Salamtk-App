using App11.DataServices;
using App11.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App11.ViewModel
{
    class Page1ViewModel : ContentPage, INotifyPropertyChanged
    {
        private int useri;
        private string email;
        private string password;


        public async Task<user> CheckInformationToLogin(string email, string password)
        {
            DataService service = new DataService();

            user varible = await service.Login(email);

            if (varible.ID != 0)
            {
                if (varible.Password == this.password)
                {
                    Application.Current.Properties["userid"] = varible.ID;
                    return varible;
                }
                return varible;
            }
            else
            {
                return varible;
            }
        }


        public int ID
        {
            get
            {
                return useri;
            }

            set
            {
                useri = value; NotifyPropertyChanged("ID");
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value; NotifyPropertyChanged("Password");
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value; NotifyPropertyChanged("Email");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

}
