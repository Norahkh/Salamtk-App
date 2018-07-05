using App11.ViewModel.Doctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App11.View
{
    public partial class RateDoctorPage : ContentPage
    { 
        RateDoctorViewModel vm1 = new RateDoctorViewModel();

        public RateDoctorPage()
        {
            InitializeComponent();
            BindingContext = vm1;

        }
        private async void ConfirmClicked(object sender, EventArgs e)
        {



            //
            int an = 0;
            var answer1 = await DisplayAlert("السؤال الاول", "المهارة في تشخيص المرض وتحديد العلاج المناسب ؟ ", "نعم", "لا");

            if (answer1)
            {

                an = 1;
            }
            else
            {
                an = 0;
            }
            var save1 = await vm1.SaveRate(1, an);
            if (save1.Doc_Quistions_ID == 1)
                await DisplayAlert("السؤال الاول", "تم تخزين الاجابة", "ok");
            else
            {
                await DisplayAlert("السؤال الاول", "لم يتم تخزين الاجابة", "ok");
            }
            var answer2 = await DisplayAlert("السؤال الثاني", "المعرفة بأنواع الامراض المتفشية في البيئة المحيطة ؟ ", "نعم", "لا");
            if (answer2)
            {
                an = 1;
            }
            else
            {
                an = 0;
            }
            var save2 = await vm1.SaveRate(2, an);
            if (save2.Doc_Quistions_ID == 2)
                await DisplayAlert("السؤال الثاني", "تم تخزين الاجابة", "ok");
            else
            {
                await DisplayAlert("السؤال الثاني", "لم يتم تخزين الاجابة", "ok");
            }

            var answer3 = await DisplayAlert("السؤال الثالث", "متابع/ة ما يستجد في مجال التخصص ؟  ", "نعم", "لا");
            if (answer3)
            {
                an = 1;
            }
            else
            {
                an = 0;
            }
            var save3 = await vm1.SaveRate(3, an);
            if (save3.Doc_Quistions_ID == 3)
                await DisplayAlert("السؤال الثالث", "تم تخزين الاجابة", "ok");
            else
            {
                await DisplayAlert("السؤال الثالث", "لم يتم تخزين الاجابة", "ok");
            }

            var answer4 = await DisplayAlert("السؤال الرابع", "القدرة على إقامة اتصالات فعالة مع الآخرين ؟ ", "نعم", "لا");
            if (answer4)
            {
                an = 1;
            }
            else
            {
                an = 0;
            }
            var save4 = await vm1.SaveRate(4, an);
            if (save4.Doc_Quistions_ID == 4)
                await DisplayAlert("السؤال الرابع", "تم تخزين الاجابة", "ok");
            else
            {
                await DisplayAlert("السؤال الرابع", "لم يتم تخزين الاجابة", "ok");
            }


            var answer5 = await DisplayAlert("السؤال الخامس", " القدرة على معاينة المرضى عند الدخول ؟", "نعم", "لا");
            if (answer5)
            {
                an = 1;
            }
            else
            {
                an = 0;
            }
            var save5 = await vm1.SaveRate(5, an);
            if (save5.Doc_Quistions_ID == 5)
                await DisplayAlert("السؤال الخامس", "تم تخزين الاجابة", "ok");
            else
            {
                await DisplayAlert("السؤال الخامس", "لم يتم تخزين الاجابة", "ok");
            }



            var answer6 = await DisplayAlert("السؤال السادس", " القدرة على استخلاص المعلومات عن المرضى وتدوين حالتهم ؟", "نعم", "لا");
            if (answer6)
            {
                an = 1;
            }
            else
            {
                an = 0;
            }
            var save6 = await vm1.SaveRate(6, an);
            if (save6.Doc_Quistions_ID == 6)
                await DisplayAlert("السؤال السادس", "تم تخزين الاجابة", "ok");
            else
            {
                await DisplayAlert("السؤال السادس", "لم يتم تخزين الاجابة", "ok");
            }



            var answer7 = await DisplayAlert("السؤال السابع", "المتابعة للنتائج المخبرية والفحوص الطبية ؟", "نعم", "لا");
            if (answer7)
            {
                an = 1;
            }
            else
            {
                an = 0;
            }
            var save7 = await vm1.SaveRate(7, an);
            if (save7.Doc_Quistions_ID == 7)
                await DisplayAlert("السؤال السابع", "تم تخزين الاجابة", "ok");
            else
            {
                await DisplayAlert("السؤال السابع", "لم يتم تخزين الاجابة", "ok");
            }


            var answer8 = await DisplayAlert("السؤال الثامن", "حسن التصرف والبشاشة وتقبل الأفكار الجديدة ؟", "نعمالسؤال الاول", "لا");
            if (answer8)
            {
                an = 1;
            }
            else
            {
                an = 0;
            }
            var save8 = await vm1.SaveRate(8, an);
            if (save8.Doc_Quistions_ID == 8)
                await DisplayAlert("السؤال الثامن", "تم تخزين الاجابة", "ok");
            else
            {
                await DisplayAlert("السؤال الثامن", "لم يتم تخزين الاجابة", "ok");
            }

        }

    }
}
