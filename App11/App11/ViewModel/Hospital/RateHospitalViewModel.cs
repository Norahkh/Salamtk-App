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

namespace App11.ViewModel.Hospital
{
   
    class RateHospitalViewModel : ContentPage, INotifyPropertyChanged
    {
        private int _userID= int.Parse(Application.Current.Properties["userid"].ToString());
        private int _hospitalId=int.Parse(Application.Current.Properties["hosid"].ToString());
        private string _hospitalname = (Application.Current.Properties["hosname"].ToString());
        private int _quasID;
        private int _CountYes;
        private int _CountNo;
        private string _quasText;
        private List<FullHosRate> _FullHos;


        public List<FullHosRate> FullHos
        {
            get { return _FullHos; }
            set
            {
                _FullHos = value;
                NotifyPropertyChanged("FullHos");
            }
        }

        public RateHospitalViewModel()
        {

            PutDataIntoList();
        }
        public async Task PutDataIntoList()
        {
            int paruserid = (int)Application.Current.Properties["userid"];
            int parhospitalid = (int)Application.Current.Properties["hosid"];

            DataService service = new DataService();
          //  List<FullHosRate> a = await service.GetHospitalQuistions(parhospitalid);



        }


        public async Task<HospitalRate> SaveRate(int id, int answer)
        {

            DataService service = new DataService();
            HospitalRate hr = new HospitalRate();
            hr.User_ID = _userID;
            hr.Hospital_ID = _hospitalId;
            hr.Hospital_Quistions_ID = id;
            hr.Answer = answer.ToString();

            HospitalRate hr1 = await service.createhosrate(hr);
            return hr1;


        }
        public int User_ID
        {
            get
            {
                return _userID;
            }

            set
            {
                _userID = value;
                NotifyPropertyChanged("User_ID");
            }
        }

        public int Hospital_ID
        {
            get
            {
                return _hospitalId;
            }

            set
            {
                _hospitalId = value;
                NotifyPropertyChanged("Hospital_ID");
            }
        }

        public int Quastion_ID
        {
            get
            {
                return _quasID;
            }

            set
            {
                _quasID = value;
                NotifyPropertyChanged("Quastion_ID");
            }
        }

        public int CountYes
        {
            get
            {
                return _CountYes;
            }

            set
            {
                _CountYes = value;
                NotifyPropertyChanged("countyes");
            }
        }


        public int CountNo
        {
            get
            {
                return _CountNo;
            }

            set
            {
                _CountNo = value;
                NotifyPropertyChanged("countno");
            }
        }


        public string Quistion_Text
        {
            get
            {
                return _quasText;
            }

            set
            {
                _quasText = value; NotifyPropertyChanged("Quistion_Text");
            }
        }

        public string Name
        {
            get
            {
                return _hospitalname;
            }

            set
            {
                _hospitalname = value; NotifyPropertyChanged("Name");
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
