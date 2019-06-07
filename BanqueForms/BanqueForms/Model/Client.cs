using System;
using System.Collections.Generic;
using System.Text;

namespace BanqueForms.Model
{
    public class Client
    {
        private static long _id = 0L;

        public static List<Client> List { get; set; } = new List<Client>()
        {
            new Client(){ Nom="Durand", Prenom="Marie", Tel="0612345789" },
            new Client(){ Nom="Leblanc", Prenom="Marc", Tel="0623457891" },
            new Client(){ Nom="Troadec", Prenom="Nolwenn", Tel="0634578912" },
            new Client(){ Nom="Grenier", Prenom="Laurent", Tel="0645789123" },
            new Client(){ Nom="Tugdual", Prenom="Lou-Ann", Tel="0657891234" }
        };

        public static Client Get(long id)
        {
            return List.Find(cli => cli.Id == id);
        }


        public long Id { get; set; } = _id++;

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }

        public string NomComplet { get { return $"{Prenom} {Nom}"; } }

        public override string ToString()
        {
            return $"{Prenom} {Nom} ({Tel}) [{Id}]";
        }
    }
}
