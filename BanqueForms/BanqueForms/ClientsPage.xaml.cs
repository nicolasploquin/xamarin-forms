using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using BanqueForms.Model;
using BanqueForms.Data;
using BanqueForms.Telephone;

namespace BanqueForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientsPage : ContentPage
    {
        public ObservableCollection<Client> Clients { get; set; }

        public ClientsPage()
        {
            InitializeComponent();

            Clients = new ObservableCollection<Client>(
                MemDataService.Instance.ReadAll()
            );
			
		    ListeClients.ItemsSource = Clients;
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //if (e.Item == null)
            //    return;

            //await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            ////Deselect Item
            //((ListView)sender).SelectedItem = null;
        }


        private void AppelClicked(object sender, EventArgs e)
        {
            if(ListeClients.SelectedItem != null)
            {
                string numero = ((Client)ListeClients.SelectedItem).Tel;
                TelephoneService.Instance.Impl.Appel(numero);
            }
        }
    }
}
