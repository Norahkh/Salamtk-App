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
    class SearchHospitalViewModel : ContentPage, INotifyPropertyChanged
    {
        private string _name;
        private string _city;
        private string _search;
        /*var iii = await vm.PutDataIntoList();

            foreach (var h in iii)
            {
                switch (h.Hospital_Quistions_ID)
                {
                    case 1:
                        Application.Current.Properties["y1"] = h.CountYes;
                        Application.Current.Properties["n1"] = h.CountNo;
                        Application.Current.Properties["m1"] = h.quis;
                        break;
                    case 2:
                        Application.Current.Properties["y2"] = h.CountYes;
                        Application.Current.Properties["n2"] = h.CountNo;
                        Application.Current.Properties["m2"] = h.quis;
                        break;
                    case 3:
                        Application.Current.Properties["y3"] = h.CountYes;
                        Application.Current.Properties["n3"] = h.CountNo;
                        Application.Current.Properties["m3"] = h.quis;
                        break;
                    case 4:
                        Application.Current.Properties["y4"] = h.CountYes;
                        Application.Current.Properties["n4"] = h.CountNo;
                        Application.Current.Properties["m4"] = h.quis;
                        break;
                    case 5:
                        Application.Current.Properties["y5"] = h.CountYes;
                        Application.Current.Properties["n5"] = h.CountNo;
                        Application.Current.Properties["m5"] = h.quis;
                        break;
                    case 6:
                        Application.Current.Properties["y6"] = h.CountYes;
                        Application.Current.Properties["n6"] = h.CountNo;
                        Application.Current.Properties["m6"] = h.quis;
                        break;
                    case 7:
                        Application.Current.Properties["y7"] = h.CountYes;
                        Application.Current.Properties["n7"] = h.CountNo;
                        Application.Current.Properties["m7"] = h.quis;
                        break;
                    case 8:
                        Application.Current.Properties["y8"] = h.CountYes;
                        Application.Current.Properties["n8"] = h.CountNo;
                        Application.Current.Properties["m8"] = h.quis;
                        break;
                




                }
                
            }
            */
          
         



        public async Task<List<hospital>> SearchHospital(string search)
        {

            DataService service = new DataService();

            List<hospital> hos = await service.SearchHospital(search);


            if (hos.Count != 0)
            {
                return hos;

            }
            else
                return null;


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
        public string Search
        {
            get { return _search; }
            set
            {
                _search = value;
                NotifyPropertyChanged("Search");
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

