 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto1_DS1.NewFolder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        String username;
        String password;
        String email;
        int phone;
        public Register()
        {
            InitializeComponent();
        }

        private void doRegister()
        {
            username = txtUsername.Text;
            password = txtPass.Text;
            email = txtEmail.Text;
            phone = Convert.ToInt16( txtPhone.Text);
        }

        private void validar()
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && 
                !string.IsNullOrEmpty(txtPass.Text) && 
                !string.IsNullOrEmpty(txtCPass.Text) &&
                !string.IsNullOrEmpty(txtEmail.Text) &&
                !string.IsNullOrEmpty(txtPhone.Text))
            {
                if (txtPass.Text == txtCPass.Text)
                {
                    doRegister();
                }
                else
                {
                    DisplayAlert("Error", "Password no coindice", "OK");
                }
            }
            else
            {
                DisplayAlert("Error", "Ingrese todos los campos", "OK");
            }

        }

        private void btnBack_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}