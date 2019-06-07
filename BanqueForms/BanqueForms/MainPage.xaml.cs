using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BanqueForms
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void CreerClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClientFormPage());
        }

        private async void ListeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClientsPage());
        }
    }
}
