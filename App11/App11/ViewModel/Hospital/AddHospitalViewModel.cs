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

namespace App11.ViewModel.Hospital
{
    class AddHospitalViewModel : ContentPage, INotifyPropertyChanged
    {
        private string _name;
        private string _city;


        public async Task<hospital> AddHospital(string Name, string City)
        {

            DataService service = new DataService();
            hospital hs = new Model.hospital();
            hs.Name = Name;
            hs.City = City;
            hospital hos = await service.createhospital(hs);
            if (hos.ID != 0)
            {
                Application.Current.Properties["hosid"] = hos.ID;
                Application.Current.Properties["hosname"] = hos.Name;
                Application.Current.Properties["hoscity"] = hos.City;
            }
            return hos;


        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyPropertyChanged("Name");
            }
        }
        public string City
        {
            get { return _city; }
            set
            {
                _city = value;
                NotifyPropertyChanged("City");
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

