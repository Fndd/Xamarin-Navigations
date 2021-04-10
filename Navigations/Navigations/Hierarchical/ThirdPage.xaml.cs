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
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();
        }
        async void Previus_Click(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        async void FirstPage_Click(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}