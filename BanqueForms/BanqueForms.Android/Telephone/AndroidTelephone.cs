using Android.App;
using Android.Content;
using BanqueForms.Telephone;

namespace BanqueForms.Droid.Telephone
{
    public class AndroidTelephone : ITelephone
    {
        public void Appel(string numero)
        {
            var strUri = string.Format("tel:{0}", numero);
            var uri = global::Android.Net.Uri.Parse(strUri);
            var intent = new Intent(Intent.ActionDial, uri);
            intent.AddFlags(ActivityFlags.NewTask);
            Application.Context.StartActivity(intent);
        }
    }
}
