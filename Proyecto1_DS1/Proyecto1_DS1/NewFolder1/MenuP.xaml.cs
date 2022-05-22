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
        public MenuP()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MenuP), typeof(MenuP));
            Routing.RegisterRoute(nameof(Favo), typeof(Favo));
            Routing.RegisterRoute(nameof(Perfil), typeof(Perfil));
        }
    }
}