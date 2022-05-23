using Proyecto1_DS1.Entity;
using Proyecto1_DS1.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto1_DS1.NewFolder1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuP : ContentPage
    {
        Repositorio<Post> repo;
        public MenuP()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MenuP), typeof(MenuP));
            Routing.RegisterRoute(nameof(Favo), typeof(Favo));
            Routing.RegisterRoute(nameof(Perfil), typeof(Perfil));
            repo = new Repositorio<Post>();
        }
        private void btnAddPost_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new addPost());
        }

        private void OnTapped(object sender, EventArgs e)
        {
            //string var = e.;
            Navigation.PushAsync(new ContentPost());
        }
        private void OnTapped2(object sender, EventArgs e)
        {
            //string var = e.;
            Navigation.PushAsync(new ContentPost2());
        }
        private void OnTapped3(object sender, EventArgs e)
        {
            //string var = e.;
            Navigation.PushAsync(new ContentPost3());
        }
    }
}