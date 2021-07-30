using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppModal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AbrirModal(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(
                new Modal()
            );
        }
    }
}
