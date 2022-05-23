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
    public partial class Login : ContentPage
    {
        Repositorio<User> repo;
        public Login(Repositorio<User> users)
        {
            InitializeComponent();
            repo = users;
        }

        private void doLogin()
        {
            User u = repo.Query(p => ((p.password == txtPass.Text) && (p.username == txtUsername.Text))).SingleOrDefault();
            if (u != null)
            {
                Navigation.PushAsync(new Home());
            }
            else
            {
                DisplayAlert("Error", "Usuario no encontrado", "OK");
            }
        }

        private void validar()
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) &&
                !string.IsNullOrEmpty(txtPass.Text))
            {
                doLogin();
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

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            //validar();
            Navigation.PushAsync(new Home());
        }

        private void btnRegister_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Register(repo));
        }
    }
}