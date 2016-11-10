using System;
using System.IO;
using System.Net;
using System.Windows;

namespace Sauron
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private WebClient WebClient = new WebClient();
        public MainWindow()
        {
            InitializeComponent();
            //MediaEl.Source = new Uri(Sauron.Properties.Settings.Default.RtspBaseUrl + Sauron.Properties.Resources.VideoUrl);


            //CallService("/cgi-bin/ptz.cgi?action=start&channel=0&code=ZoomWide&arg1=0&arg2=1&arg3=0");
            //CallService("/cgi-bin/ptz.cgi?action=stop&channel=0&code=ZoomWide&arg1=0&arg2=1&arg3=0");





            //DigestAuthFixer digest = new DigestAuthFixer("http://192.168.1.21", "admin", "@Krilik1");
            //string strReturn = digest.GrabResponse(Sauron.Properties.Resources.GetConfigConfigUrl);

            //Uri uri = new Uri(Sauron.Properties.Settings.Default.ServiceBaseUrl + Sauron.Properties.Resources.GetConfigConfigUrl);
            //WebRequest request = WebRequest.Create(uri);

            //var credentialCache = new CredentialCache();
            //credentialCache.Add(
            //  new Uri(uri.GetLeftPart(UriPartial.Authority)), // request url's host
            //  "Digest",  // authentication type 
            //  new NetworkCredential(Base64Encode("admin"), Base64Encode("@Krilik1")) // credentials 
            //);

            //request.Credentials = credentialCache;
            //StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream());
            //string test = reader.ReadToEnd();
        }

        public string CallService(string part)
        {
            String MyURI = "http://192.168.1.21";
            WebRequest WReq = WebRequest.Create(MyURI + part);
            WReq.Credentials = new NetworkCredential("admin", "@Krilik1");
            using (StreamReader reader = new StreamReader(WReq.GetResponse().GetResponseStream()))
            {
                return reader.ReadToEnd();
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //string ptzConfig = WebClient.DownloadString(Sauron.Properties.Settings.Default.ServiceBaseUrl + Sauron.Properties.Resources.GetConfigConfigUrl);

        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
