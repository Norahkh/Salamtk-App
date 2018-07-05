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

namespace App11.ViewModel.Doctor
{
   
    class RateDoctorViewModel : ContentPage, INotifyPropertyChanged
    {
        private int _userID= int.Parse(Application.Current.Properties["userid"].ToString());
        private int _doctorId=int.Parse(Application.Current.Properties["docid"].ToString());
        private string _doctorname = (Application.Current.Properties["docname"].ToString());
        private int _quasID;
        private int _CountYes;
        private int _CountNo;
        private string _quasText;
        private List<FullDocRate> _FullDoc;


        public List<FullDocRate> FullDoc
        {
            get { return _FullDoc; }
            set
            {
                _FullDoc = value;
                NotifyPropertyChanged("FullDoc");
            }
        }

        public RateDoctorViewModel()
        {

            PutDataIntoList();
        }
        public async Task PutDataIntoList()
        {
            int paruserid = (int)Application.Current.Properties["userid"];
            int pardoctorid = (int)Application.Current.Properties["docid"];

            
          //  List<FullHosRate> a = await service.GetHospitalQuistions(parhospitalid);



        }


        public async Task<DoctorRate> SaveRate(int id, int answer)
        {

            DataService service = new DataService();
            DoctorRate dr = new DoctorRate();
            dr.User_ID = _userID;
            dr.Doctor_ID = _doctorId;
            dr.Doc_Quistions_ID = id;
            dr.Answer = answer.ToString();

            DoctorRate dr1 = await service.createdocrate(dr);
            
            return dr1;


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

        public int Doctor_ID
        {
            get
            {
                return _doctorId;
            }

            set
            {
                _doctorId = value;
                NotifyPropertyChanged("Doctor_ID");
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
                return _doctorname;
            }

            set
            {
                _doctorname = value; NotifyPropertyChanged("Name");
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
