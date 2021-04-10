using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigations.ModalPage
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
            await Navigation.PopModalAsync();
        }
        async void FirstPage_Click(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}