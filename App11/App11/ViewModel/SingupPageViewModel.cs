using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Runtime.CompilerServices;
using App11.DataServices;
using App11.Model;

namespace App11.ViewModel
{
   
    class SingupPageViewModel : ContentPage, INotifyPropertyChanged
    {
        private int useri;
        private string name;
        private string password;
        private string email;
        private string city;
        private string mobile;

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public async Task<user> Checkinfo(string Name, string Password, string Email, string City, string Mobile)
        {

            DataService service = new DataService();
            user us = new Model.user();
           
            us.Name = Name;
            us.Password = Password;
            us.Email = Email;
            us.City = City;
            us.Mobile = Mobile;
            user user = await service.createuser(us);
            Application.Current.Properties["userid"] = user.ID;
            return user;


        }
        public int ID
        {
            get
            {
                return useri;
            }

            set
            {
                useri = value;
                NotifyPropertyChanged("ID");
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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value; NotifyPropertyChanged("Name");
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

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value; NotifyPropertyChanged("City");
            }
        }

        public string Mobile
        {
            get
            {
                return mobile;
            }

            set
            {
                mobile = value; NotifyPropertyChanged("Mobile");
            }
        }


    }

   
}
