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
    public partial class AddDoctorPage : ContentPage

    {
        AddDoctorViewModel vm1 = new AddDoctorViewModel();
        public AddDoctorPage()
        {
            InitializeComponent();
            BindingContext = vm1;

        }

        private async void AddClicked(object sender, EventArgs e)
        {
            int i = 1;
            doctor info = await vm1.AddDoctor(vm1.Name, i);
            if (info.ID != 0)
            {

                await Navigation.PushAsync(new RateDoctorPage());



            }
            else
            {
                messageLabel.Text = "الرجاء التأكد من أسم المستخدم وكلمة المرور";
            }




        }

    }
}
