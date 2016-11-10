using Sauron.ViewModels;

namespace Sauron.DesignTimeViewModels
{
    public class DTCameraViewModel : CameraViewModel
    {
        public DTCameraViewModel()
            : base(new Controllers.CameraController()
            {
            })
        {
        }
    }
}
