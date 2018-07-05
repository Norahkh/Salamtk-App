using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App11.ViewModel.Hospital;
using Xamarin.Forms;
using App11.Model;

namespace App11.View
{
    public partial class ViewHospitalPage : ContentPage
    {
        ViewHospitalViewModel vm1 = new ViewHospitalViewModel();
        private string _hospitalname = (Application.Current.Properties["hosname"].ToString());
        private string _hospitalcity = (Application.Current.Properties["hoscity"].ToString());
        FullHosRate hr = new FullHosRate();
        List<FullHosRate> hrl = new List<FullHosRate>();
        public ViewHospitalPage()
        {
         
            InitializeComponent();
            BindingContext = vm1;
            Name.Text = _hospitalname;
            City.Text = _hospitalcity;
            vm1.PutDataIntoList();
        }

        /*   if (i != null)
           {
               Result.ItemsSource = i;
           }
       */



        async void ItemClicked(object sender, SelectedItemChangedEventArgs e)
        {
            var _FullHosRate = (FullHosRate)e.SelectedItem;
            string y = _FullHosRate.yes_Count.ToString();
            string n = _FullHosRate.No_Count.ToString();
            string f = "عدد الاجابات ب نعم: " + y + " عدد الاجابات ب لا:" + n;
            List<string> title = vm1.QN;
            switch (_FullHosRate.Hospital_Quistions_ID)
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
        }

        private async void RateClicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new RateHospitalPage());


        }
    }
}
