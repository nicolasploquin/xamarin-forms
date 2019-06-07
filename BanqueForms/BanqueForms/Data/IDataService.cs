using System;
using System.Collections.Generic;
using System.Text;

using BanqueForms.Model;

namespace BanqueForms.Data
{
    public interface IDataService
    {

        List<Client> ReadAll();

        void Create(string nom, string prenom, string tel);

        Client Read(long id);


    }
}
