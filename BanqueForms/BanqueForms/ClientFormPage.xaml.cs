using BanqueForms.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BanqueForms
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ClientFormPage : ContentPage
	{
		public ClientFormPage ()
		{
			InitializeComponent ();
		}

        private async void Enregistrer(object sender, EventArgs e)
        {
            NomEntry.Text = NomEntry.Text.ToUpper();
            MemDataService.Instance.Create(
                NomEntry.Text, PrenomEntry.Text, TelEntry.Text
            );
            await Navigation.PopAsync();
        }
    }
}