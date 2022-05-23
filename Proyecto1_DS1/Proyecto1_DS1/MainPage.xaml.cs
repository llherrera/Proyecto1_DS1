using Proyecto1_DS1.Entity;
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
        Repositorio<User> users;
        public MainPage()
        {
            users = new Repositorio<User>();
            InitializeComponent();
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login(users));
        }

        private void btnRegister_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Register(users));
        }
    }
}
