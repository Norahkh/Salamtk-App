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

namespace App11.ViewModel.Doctor
{
    class AddDoctorViewModel : ContentPage, INotifyPropertyChanged
    {
        private string name;
        private int major_ID=1;
        

        
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }

        
        
        public async Task<doctor> AddDoctor(string Name, int major1)
        {

            DataService service = new DataService();
            doctor dc = new doctor();
            dc.Name = Name;
            dc.Major_ID = 1;
            doctor doc = await service.createdoctor(dc);
            if (doc.ID != 0)
            {
                Application.Current.Properties["docid"] = doc.ID;
                Application.Current.Properties["docname"] = doc.Name;
                
            }
            return doc;


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

