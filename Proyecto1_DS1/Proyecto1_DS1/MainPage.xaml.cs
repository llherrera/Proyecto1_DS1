using Proyecto1_DS1.NewFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Proyecto1_DS1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }

        private void btnRegister_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Register());
        }
    }
}
