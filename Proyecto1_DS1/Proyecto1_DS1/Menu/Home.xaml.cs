using Proyecto1_DS1.Entity;
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
    public partial class Home : TabbedPage
    {
        Repositorio<Post> repo;
        public Home()
        {
            InitializeComponent();
        }
    }
}