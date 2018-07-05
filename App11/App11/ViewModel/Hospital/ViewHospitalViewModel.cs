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
   
    class ViewHospitalViewModel : ContentPage, INotifyPropertyChanged
    {
        private int _userID= (int)Application.Current.Properties["userid"];
        private int _hospitalId=(int)Application.Current.Properties["hosid"];
        private string _hospitalname = Application.Current.Properties["hosname"].ToString();
        private string _hospitalcity = Application.Current.Properties["hoscity"].ToString();
        
        private int _CountYes;
        private int _CountNo;
        
        private List<FullHosRate> _FullHos;
        private List<string> _qn;

        public ViewHospitalViewModel()
        {

            PutDataIntoList();
            NotifyPropertyChanged("FullHos");

        }

        public List<FullHosRate> FullHos
        {
            get { return _FullHos; }
            set
            {
                _FullHos = value;
                NotifyPropertyChanged("FullHos");
            }
        }
        public List<String> QN
        {
            get { return _qn; }
            set {
                _qn = value;
                NotifyPropertyChanged("FullHos");
            }
        }
        
        public async Task<List<FullHosRate>> PutDataIntoList()
        {

            DataService service = new DataService();
            List<FullHosRate> a = await service.GetHospitalRate(_hospitalId);
            
            FullHos = a;
            _FullHos = a;
            NotifyPropertyChanged("FullHos");
            List<String> QN1 = new List<string> { "تحتاج المستشفى الى ان تحدث من الأجهزة والمعدات والمستلزمات الطبية المستخدمة؟ ", "ا تلتزم إدارة المستشفى بوعودها للمرضى في مجال تقديم الخدمات الصحية والعلاجية وتوفير البيئة الملائمة كما تتوقعها في ذهنك ؟  ", "تهتم إدارة المستشفى بتقديم الخدمات في الوقت المحدد وبشكل سريع ودقيق ؟ ", "تهتم إدارة المستشفى بشكل دقيق في تدوين المعلومات عن المرضى وحالاتهم الصحية في السجلات والحاسوب ؟ ", "تتجاوب إدارة المستشفى مع الشكاوى بشكل سريع وفعال ؟", " الطاقم الطبي والعامل متفاعل مع المرضى ويتعاملون معهم بلطف و رقي ؟", "تتوفر لدى العامل  في المستشفى الجدارة والكياسة والمصداقية في أداء عملهم ؟", "إدارة المستشفى تولي المرضى عناية شخصية ؟" };

            QN = QN1;
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
                return _hospitalId;
            }

            set
            {
                _hospitalId = value;
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
                return _hospitalname;
            }

            set
            {
                _hospitalname = value; NotifyPropertyChanged("Name");
            }
        }


        public string City
        {
            get
            {
                return _hospitalcity;
            }

            set
            {
                _hospitalcity = value; NotifyPropertyChanged("City");
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
