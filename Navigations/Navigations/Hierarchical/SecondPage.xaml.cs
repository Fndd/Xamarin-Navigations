using Navigations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigations
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        public SecondPage(Movie m)
        {
            InitializeComponent();
            BindingContext = m;
        }
        async void Handle_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ThirdPage());
        }
        async void Previus_Click(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        
    }
}