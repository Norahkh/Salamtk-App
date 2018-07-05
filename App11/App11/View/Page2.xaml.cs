using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App11.View
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Add_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddDoctorPage());
        }

        private void Search_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SearchForDoctorPage());
        }
    }
}
