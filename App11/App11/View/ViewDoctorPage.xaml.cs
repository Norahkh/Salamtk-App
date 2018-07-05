using App11.Model;
using App11.ViewModel.Doctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App11.View
{
    public partial class ViewDoctorPage : ContentPage
    { 
    ViewDoctorViewModel vm1 = new ViewDoctorViewModel();
    private string _doctorname = (Application.Current.Properties["docname"].ToString());

    FullDocRate hr = new FullDocRate();
    List<FullDocRate> hrl = new List<FullDocRate>();
    public ViewDoctorPage()
    {

        InitializeComponent();
        BindingContext = vm1;
        Name.Text = _doctorname;

        vm1.PutDataIntoList();

    }

        /*   if (i != null)
           {
               Result.ItemsSource = i;
           }
       */



        async void ItemClicked(object sender, SelectedItemChangedEventArgs e)
        {
            var _FullDocRate = (FullDocRate)e.SelectedItem;
            string y = _FullDocRate.yes_Count.ToString();
            string n = _FullDocRate.No_Count.ToString();
            string f = "عدد الاجابات ب نعم: " + y + " عدد الاجابات ب لا:" + n;
            List<string> title = vm1.QN;
            switch (_FullDocRate.Doc_Quistions_ID)
            {
                case 1:
                    
                    await DisplayAlert(title[0], f, "ok"); 
                    break;
                case 2:
                    await DisplayAlert(title[1], f, "ok");
                    break;
                case 3:
                    await DisplayAlert(title[2], f, "ok");
                    break;
                case 4:
                    await DisplayAlert(title[3], f, "ok");
                    break;

                case 5:
                    await DisplayAlert(title[4], f, "ok");
                    break;
                case 6:
                    await DisplayAlert(title[5], f, "ok");
                    break;
                case 7:
                    await DisplayAlert(title[6], f, "ok");
                    break;
                case 8:
                    await DisplayAlert(title[7], f, "ok");
                    break;

            }
            //
            //var answer1 = await DisplayAlert("السؤال الاول", "تحتاج المستشفى الى ان تحدث من الأجهزة والمعدات والمستلزمات الطبية المستخدمة؟", "نعم", "لا");
            //var answer2 = await DisplayAlert("السؤال الاول", "تحتاج المستشفى الى ان تحدث من الأجهزة والمعدات والمستلزمات الطبية المستخدمة؟", "نعم", "لا");
            // And access the account here.
        }


 

    private async void RateClicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new RateDoctorPage());


    }
}
}
