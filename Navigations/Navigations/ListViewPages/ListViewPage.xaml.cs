using Navigations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigations.ListViewPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();
            itemList.ItemsSource = new ListItemPage[]
            {
                new ListItemPage{Title= "First",PageType = typeof(FirstPage)},
                new ListItemPage{Title= "Second",PageType = typeof(SecondPage)},
                new ListItemPage{Title= "Third",PageType = typeof(ThirdPage)}

            };
        }

        async void Handle_Tapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as ListItemPage;
            if (item == null) return;
            Page page = (Page)Activator.CreateInstance(item.PageType);
            await Navigation.PushAsync(page);



        }
    }
}