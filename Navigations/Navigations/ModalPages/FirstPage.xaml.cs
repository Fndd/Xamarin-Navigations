using Navigations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigations.ModalPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }
       async void Handle_Click(object sender, EventArgs e)
        {
           // string name = "Funda Demirtaş";

            var m = new Movie{
                Name ="Film 1",
                Description="Açıklama"
               
            };
            await Navigation.PushModalAsync(new ModalPage.SecondPage(m));
        }
    }
}