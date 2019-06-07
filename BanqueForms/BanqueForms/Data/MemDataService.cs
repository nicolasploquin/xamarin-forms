using System;
using System.Collections.Generic;
using System.Text;
using BanqueForms.Model;

namespace BanqueForms.Data
{
    public class MemDataService : IDataService
    {
        public static MemDataService Instance { get; } = new MemDataService();

        private List<Client> clients = new List<Client>
        {
            new Client(){ Nom="Durand", Prenom="Marie", Tel="0612345789" },
            new Client(){ Nom="Leblanc", Prenom="Marc", Tel="0623457891" },
            new Client(){ Nom="Troadec", Prenom="Nolwenn", Tel="0634578912" },
            new Client(){ Nom="Grenier", Prenom="Laurent", Tel="0645789123" },
            new Client(){ Nom="Tugdual", Prenom="Lou-Ann", Tel="0657891234" }
        };

        public void Create(string nom, string prenom, string tel)
        {
            clients.Add(new Client() {
                Nom = nom,
                Prenom = prenom,
                Tel = tel
            });
        }

        public Client Read(long id)
        {
            return clients.Find(cli => cli.Id == id);
        }

        public List<Client> ReadAll()
        {
            return clients;
        }
    }
}
