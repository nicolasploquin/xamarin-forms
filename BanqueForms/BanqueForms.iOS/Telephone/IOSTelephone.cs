

using BanqueForms.Telephone;
using Foundation;
using UIKit;

namespace BanqueForms.iOS.Telephone
{
    public class IOSTelephone : ITelephone
    {
        public void Appel(string numero)
        {
            var url = new Foundation.NSUrl("tel:" + numero);
            UIApplication.SharedApplication.OpenUrl(url);
        }
    }
}
