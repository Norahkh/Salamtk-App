using App11.ViewModel.Hospital;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App11.View
{
    public partial class RateHospitalPage : ContentPage
        
    {
        RateHospitalViewModel vm1 = new RateHospitalViewModel();

        public RateHospitalPage()
        {
            InitializeComponent();
            BindingContext = vm1;

        }
        private async void ConfirmClicked(object sender, EventArgs e)
        {



            //
            int an=0;
            var answer1 = await DisplayAlert("السؤال الاول", "تحتاج المستشفى الى ان تحدث من الأجهزة والمعدات والمستلزمات الطبية المستخدمة؟", "نعم", "لا");
            
            if (answer1)
            {
                
                an = 1;
            }
            else
            {
                an = 0;
            }
            var save1 = await vm1.SaveRate(1,an);
            if (save1.Hospital_Quistions_ID==1)
                await DisplayAlert("السؤال الاول", "تم تخزين الاجابة", "ok");
            else
            {
                await DisplayAlert("السؤال الاول", "لم يتم تخزين الاجابة", "ok");
            }
            var answer2 = await DisplayAlert("السؤال الثاني", "تلتزم إدارة المستشفى بوعودها للمرضى في مجال تقديم الخدمات الصحية والعلاجية وتوفير البيئة الملائمة كما تتوقعها في ذهنك؟", "نعم", "لا");
            if (answer2)
            {
                an = 1;
            }
            else
            {
                an = 0;
            }
            var save2 = await vm1.SaveRate(2, an);
            if (save2.Hospital_Quistions_ID == 2)
                await DisplayAlert("السؤال الثاني", "تم تخزين الاجابة", "ok");
            else
            {
                await DisplayAlert("السؤال الثاني", "لم يتم تخزين الاجابة", "ok");
            }

            var answer3 = await DisplayAlert("السؤال الثالث", "تهتم إدارة المستشفى بتقديم الخدمات في الوقت المحدد وبشكل سريع ودقيق ؟ ", "نعم", "لا");
            if (answer3)
            {
                an = 1;
            }
            else
            {
                an = 0;
            }
            var save3 = await vm1.SaveRate(3, an);
            if (save3.Hospital_Quistions_ID == 3)
                await DisplayAlert("السؤال الاول", "تم تخزين الاجابة", "ok");
            else
            {
                await DisplayAlert("السؤال الاول", "لم يتم تخزين الاجابة", "ok");
            }

            var answer4 = await DisplayAlert("السؤال الرابع", "تهتم إدارة المستشفى بشكل دقيق في تدوين المعلومات عن المرضى وحالاتهم الصحية في السجلات والحاسوب ؟ ", "نعم", "لا");
            if (answer4)
            {
                an = 1;
            }
            else
            {
                an = 0;
            }
            var save4 = await vm1.SaveRate(4, an);
            if (save4.Hospital_Quistions_ID == 4)
                await DisplayAlert("السؤال الاول", "تم تخزين الاجابة", "ok");
            else
            {
                await DisplayAlert("السؤال الاول", "لم يتم تخزين الاجابة", "ok");
            }


            var answer5 = await DisplayAlert("السؤال الخامس", " تتجاوب إدارة المستشفى مع الشكاوى بشكل سريع وفعال ؟", "نعم", "لا");
            if (answer5)
            {
                an = 1;
            }
            else
            {
                an = 0;
            }
            var save5 = await vm1.SaveRate(5, an);
            if (save5.Hospital_Quistions_ID == 5)
                await DisplayAlert("السؤال الاول", "تم تخزين الاجابة", "ok");
            else
            {
                await DisplayAlert("السؤال الاول", "لم يتم تخزين الاجابة", "ok");
            }



            var answer6 = await DisplayAlert("السؤال السادس", "الطاقم الطبي والعامل متفاعل مع المرضى ويتعاملون معهم بلطف و رقي ؟", "نعم", "لا");
            if (answer6)
            {
                an = 1;
            }
            else
            {
                an = 0;
            }
            var save6 = await vm1.SaveRate(6, an);
            if (save6.Hospital_Quistions_ID == 6)
                await DisplayAlert("السؤال الاول", "تم تخزين الاجابة", "ok");
            else
            {
                await DisplayAlert("السؤال الاول", "لم يتم تخزين الاجابة", "ok");
            }



            var answer7 = await DisplayAlert("السؤال السابع", "تتوفر لدى العامل  في المستشفى الجدارة والكياسة والمصداقية في أداء عملهم ؟", "نعم", "لا");
            if (answer7)
            {
                an = 1;
            }
            else
            {
                an = 0;
            }
            var save7 = await vm1.SaveRate(7, an);
            if (save7.Hospital_Quistions_ID == 7)
                await DisplayAlert("السؤال الاول", "تم تخزين الاجابة", "ok");
            else
            {
                await DisplayAlert("السؤال الاول", "لم يتم تخزين الاجابة", "ok");
            }



            var answer8 = await DisplayAlert("السؤال الثامن", "إدارة المستشفى تولي المرضى عناية شخصية ؟", "نعم", "لا");
            if (answer8)
            {
                an = 1;
            }
            else
            {
                an = 0;
            }
            var save8 = await vm1.SaveRate(8, an);
            if (save8.Hospital_Quistions_ID == 8)
                await DisplayAlert("السؤال الاول", "تم تخزين الاجابة", "ok");
            else
            {
                await DisplayAlert("السؤال الاول", "لم يتم تخزين الاجابة", "ok");
            }

        }

    }
}
