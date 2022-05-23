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
        addPost temp;
        public MenuP()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MenuP), typeof(MenuP));
            Routing.RegisterRoute(nameof(Favo), typeof(Favo));
            Routing.RegisterRoute(nameof(Perfil), typeof(Perfil));
            repo = new Repositorio<Post>();
            addStack();
        }

        void addStack()
        {
            temp = new addPost();
            var list = temp.list;
            foreach (var i in list)
            {
                StackLayout slc = new StackLayout();
                Label la = new Label();
                la.Text = i.title;
                la.TextColor = Color.Black;
                la.FontSize = 20;
                Image ima = new Image();
                ima.Source = i.img;
                Label la2 = new Label();
                la2.Text = i.descr;
                la2.TextColor = Color.Black;
                la2.FontSize = 20;
                //slc.Children.Add(la);
                //slc.Children.Add(ima);
                //slc.Children.Add(la2);
                sl.Children.Add(la);
                sl.Children.Add(ima);
                sl.Children.Add(la2);
            }
        }
        private void btnAddPost_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new addPost());
        }
    }
}