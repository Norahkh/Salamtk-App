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
    public partial class SignUpPage : ContentPage
    {
        SingupPageViewModel vm1 = new SingupPageViewModel();
        public SignUpPage()
        {
            InitializeComponent();
            BindingContext = vm1;
        }
        private async void Signup_Button_Clicked(object sender, EventArgs e)
        {
            user info = await vm1.Checkinfo(vm1.Name, vm1.Password, vm1.Email, vm1.City, vm1.Mobile);
            if (info.ID != 0)
            {
                Application.Current.Properties["userid"] = info.ID;
                await Navigation.PushAsync(new Main());



            }
            else
            {
                messageLabel.Text = "الرجاء التأكد من البيانات المدخلة";
            }

        }
    }
}
