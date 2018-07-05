using App11.Model;
using App11.ViewModel.Hospital;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App11.View
{
    public partial class SearchForHospitalPage : ContentPage
    {
        SearchHospitalViewModel vm1 = new SearchHospitalViewModel();
        public SearchForHospitalPage()
        {
            InitializeComponent();
            BindingContext = vm1;
        }

        async void ItemClicked(object sender, SelectedItemChangedEventArgs e)
        {
            var _hospital = (hospital)e.SelectedItem;
           
            Application.Current.Properties["hosid"] = _hospital.ID;
            Application.Current.Properties["hosname"] = _hospital.Name;
            Application.Current.Properties["hoscity"] = _hospital.City;

                
                await Navigation.PushAsync(new ViewHospitalPage());
            //
            //var answer1 = await DisplayAlert("السؤال الاول", "تحتاج المستشفى الى ان تحدث من الأجهزة والمعدات والمستلزمات الطبية المستخدمة؟", "نعم", "لا");
            //var answer2 = await DisplayAlert("السؤال الاول", "تحتاج المستشفى الى ان تحدث من الأجهزة والمعدات والمستلزمات الطبية المستخدمة؟", "نعم", "لا");
            // And access the account here.
        }

        private async void Search_Clicked(object sender, EventArgs e)
        {
            var i = await vm1.SearchHospital(vm1.Search);
            if (i != null)
            {

                this.FindByName<ListView>("Result").ItemsSource = i;

            }
            else
            {
                this.FindByName<Label>("messageLabel").Text = "الرجاء التأكد من معيار البحث";

            }




        }
    }
}
