
using App11.Model;
using App11.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App11.View
{
    public partial class Page1 : ContentPage
    {
        Page1ViewModel vm = new Page1ViewModel();

        public Page1()
        {
            InitializeComponent();

            this.BindingContext = vm;
        }

        private void Signup_Button_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new SignUpPage());
        }

        private async void Sign_In_Clicked(object sender, EventArgs e)
        {
           user info = await vm.CheckInformationToLogin(vm.Email, vm.Password);

            if (info.ID != 0)
            {
  
                await Navigation.PushAsync(new Main());
            }

            else
            {
                messageLabel.Text = "الرجاء التأكد من أسم المستخدم وكلمة المرور";
            }




        }
    }
}