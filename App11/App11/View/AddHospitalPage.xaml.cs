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
    public partial class AddHospitalPage : ContentPage
    {
        AddHospitalViewModel vm1 = new AddHospitalViewModel();

        public AddHospitalPage()

        {
            InitializeComponent();
            BindingContext = vm1;
        }


        private async void AddClicked(object sender, EventArgs e)
        {
            hospital info = await vm1.AddHospital(vm1.Name, vm1.City);
            if (info.ID != 0)
            {
                
                await Navigation.PushAsync(new RateHospitalPage ());



            }
            else
            {
                messageLabel.Text = "الرجاء التأكد من أسم المستخدم وكلمة المرور";
            }




        }
    }
}
