using Sauron.Controllers;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;

namespace Sauron.Utils
{
    public static class Service
    {
        public static string Call(CameraController cameraController, string method)
        {
            WebRequest WReq = WebRequest.Create(cameraController.Protocol + "://" + cameraController.IpAddress + ":" + cameraController.Port + method);
            WReq.Credentials = new NetworkCredential(cameraController.Login, cameraController.Password);
            
            using (StreamReader reader = new StreamReader(WReq.GetResponse().GetResponseStream()))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
