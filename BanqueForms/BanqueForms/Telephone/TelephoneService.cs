using System;
using System.Collections.Generic;
using System.Text;

namespace BanqueForms.Telephone
{
    class TelephoneService
    {
        //readonly Dictionary<Type, Func<string>> _cache;
        public ITelephone Impl { get; private set; }

        public static TelephoneService Instance { get; } = new TelephoneService();

        public void Enregistrer(ITelephone impl) {
            Impl = impl;
        }

    }
}
