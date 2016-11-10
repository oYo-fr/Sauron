using Sauron.Controllers;
using System.IO;
using System.Net;

namespace Sauron.Utils
{
    public static class Service
    {
        public static string Call(CameraController CameraController, string Method)
        {
            WebRequest WReq = WebRequest.Create(CameraController.Protocol + "://" + CameraController.IpAddress + ":" + CameraController.Port + Method);
            WReq.Credentials = new NetworkCredential(CameraController.Login, CameraController.Password);
            using (StreamReader reader = new StreamReader(WReq.GetResponse().GetResponseStream()))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
