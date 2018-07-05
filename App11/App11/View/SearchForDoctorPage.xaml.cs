using Android.Content.Res;
using App11.Model;
using App11.ViewModel.Doctor;
using App11.ViewModel.Hospital;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App11.View
{
   
    public partial class SearchForDoctorPage : ContentPage
    {

        SearchDoctorViewModel vm1 = new SearchDoctorViewModel();

        public SearchForDoctorPage()
        {
            InitializeComponent();
            BindingContext = vm1;
        }
   

    async void ItemClicked(object sender, SelectedItemChangedEventArgs e)
    {
        var _doctor = (doctor)e.SelectedItem;
        Application.Current.Properties["docid"] = _doctor.ID;
        Application.Current.Properties["docname"] = _doctor.Name;
        await Navigation.PushAsync(new ViewDoctorPage());
        //
        //var answer1 = await DisplayAlert("السؤال الاول", "تحتاج المستشفى الى ان تحدث من الأجهزة والمعدات والمستلزمات الطبية المستخدمة؟", "نعم", "لا");
        //var answer2 = await DisplayAlert("السؤال الاول", "تحتاج المستشفى الى ان تحدث من الأجهزة والمعدات والمستلزمات الطبية المستخدمة؟", "نعم", "لا");
        // And access the account here.
    }

    private async void Search_Clicked(object sender, EventArgs e)
    {
        var i = await vm1.SearchDoctor(vm1.Search);
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