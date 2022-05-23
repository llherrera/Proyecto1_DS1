using Proyecto1_DS1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto1_DS1.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class addPost : ContentPage
    {
        Repositorio<Post> repo;
        public List<Post> list = new List<Post>();
        public addPost()
        {
            InitializeComponent();
            repo = new Repositorio<Post>();
        }
        private void doPosted()
        {
            Post p = new Post();
            p.price = Convert.ToInt16(txtPrice.Text);
            p.title = txtTitle.Text;
            p.descr = txtDesc.Text;
            p.img = txtURL.Text;
            list.Add(p);
            repo.Create(p);
        }

        private void validar()
        {
            if (!string.IsNullOrEmpty(txtDesc.Text) &&
                !string.IsNullOrEmpty(txtTitle.Text) &&
                !string.IsNullOrEmpty(txtPrice.Text) &&
                !string.IsNullOrEmpty(txtURL.Text))
            {
                doPosted();
            }
        }

        private void btnAddPost_Clicked(object sender, EventArgs e)
        {
            validar();
            Navigation.PopAsync();
        }

        private void btnBack_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}