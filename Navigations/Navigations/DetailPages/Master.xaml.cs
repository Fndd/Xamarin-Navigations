using Navigations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigations.DetailPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();
            itemList.ItemsSource = new ListItem[]
            {
                new ListItem { Title = "First", Description = "" },
                new ListItem { Title = "Second", Description = "" },
                new ListItem { Title = "Third", Description = "" },
                new ListItem { Title = "Forth", Description = "" }
            };
        }

        async void Handle_Tapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as ListItem;
            if (item == null) return;

            await Navigation.PushAsync(new Details(item));
            itemList.SelectedItem = null;
        }
    }
}