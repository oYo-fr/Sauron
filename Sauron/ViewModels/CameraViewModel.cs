using Sauron.Commands;
using Sauron.Controllers;

namespace Sauron.ViewModels
{
    public class CameraViewModel : BaseViewModel
    {
        private CameraController cameraController;
        public CameraController CameraController
        {
            private set
            {
                if (cameraController == value) return;
                cameraController = value;
                RaisePropertyChanged();
            }
            get
            {
                return cameraController;
            }
        }
        
        public ZoomTeleCommand ZoomTeleCommand { protected set; get; }
        public ZoomWideCommand ZoomWideCommand { protected set; get; }

        public CameraViewModel(CameraController cameraController)
        {
            CameraController = cameraController;
            ZoomTeleCommand = new ZoomTeleCommand(this);
            ZoomWideCommand = new ZoomWideCommand(this);
        }
    }
}
