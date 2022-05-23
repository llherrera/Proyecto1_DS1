using Proyecto1_DS1.Entity;
using Proyecto1_DS1.NewFolder1;
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
        Repositorio<User> repo;
        public Register(Repositorio<User> users)
        {
            InitializeComponent();
            repo = users;
        }

        private void doRegister()
        {
            User u = new User();
            u.username = txtUsername.Text;
            u.password = txtPass.Text;
            u.email = txtEmail.Text;
            u.phone = Convert.ToInt16(txtPhone.Text);
            repo.Create(u);
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

        private void menuLoad_Clicked(object sender, EventArgs e)
        {
            validar();
            Navigation.PushAsync(new Home());
        }
    }
}