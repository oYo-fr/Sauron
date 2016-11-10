using Sauron.ViewModels;

namespace Sauron.DesignTimeViewModels
{
    public class DTCameraViewModel : CameraViewModel
    {
        public DTCameraViewModel()
            : base(new Controllers.CameraController()
            {
                Login = "admin",
                Password = "@Krilik1",
                IpAddress = "90.120.188.10",
                RtspPort = 554,
                Port = 8000,
                Protocol = "http"
            })
        {
        }
    }
}
