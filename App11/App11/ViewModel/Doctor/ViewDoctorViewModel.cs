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
   
    class ViewDoctorViewModel : ContentPage, INotifyPropertyChanged
    {
        private int _userID= (int)Application.Current.Properties["userid"];
        private int _doctorId=(int)Application.Current.Properties["docid"];
        private string _doctorname = Application.Current.Properties["docname"].ToString();
        
        private int _CountYes;
        private int _CountNo;
        
        private List<FullDocRate> _FullDoc;
        private List<string> _qn;
        public ViewDoctorViewModel(){

            PutDataIntoList();
            NotifyPropertyChanged("FullDoc");

        }
        public List<FullDocRate> FullDoc
        {
            get { return _FullDoc; }
            set
            {
                _FullDoc = value;
                NotifyPropertyChanged("FullDoc");
            }
        }
        public List<String> Quis
        {
            get { return QN; }
            set {
                QN = value;
                NotifyPropertyChanged("FullDoc");
            }
        }
        
        public async Task<List<FullDocRate>> PutDataIntoList()
        {

            DataService service = new DataService();
            List<FullDocRate> a = await service.GetDoctorRate(_doctorId);
           
            FullDoc = a;
            _FullDoc = a;
            NotifyPropertyChanged("FullDoc");
            List<String> QN1 = new List<string> {"المهارة في تشخيص المرض وتحديد العلاج المناسب ؟ ","المعرفة بأنواع الامراض المتفشية في البيئة المحيطة ؟ ","متابع/ة ما يستجد في مجال التخصص ؟  ","القدرة على إقامة اتصالات فعالة مع الآخرين ؟ "," القدرة على معاينة المرضى عند الدخول ؟"," القدرة على استخلاص المعلومات عن المرضى وتدوين حالتهم ؟","المتابعة للنتائج المخبرية والفحوص الطبية ؟","حسن التصرف والبشاشة وتقبل الأفكار الجديدة ؟"};
           
            QN=QN1;
            _qn = QN1;
            NotifyPropertyChanged("QN");
            this.Content = this.Content;

            return a;
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
                return _doctorId;
            }

            set
            {
                _doctorId = value;
                NotifyPropertyChanged("Hospital_ID");
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

        public List<String> QN
        {
            get
            {
                return _qn;
            }
            set
            {
                _qn = value;
                NotifyPropertyChanged("QN");
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
