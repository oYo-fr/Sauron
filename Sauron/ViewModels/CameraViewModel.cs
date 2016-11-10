using Sauron.Commands;
using Sauron.Controllers;
using Sauron.ViewModels.Config;
using Sauron.ViewModels.Status;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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

        private ObservableCollection<ConfigViewModel> configViewModels = new ObservableCollection<ConfigViewModel>();
        public ObservableCollection<ConfigViewModel> ConfigViewModels
        {
            private set
            {
                if (configViewModels == value) return;
                configViewModels = value;
                RaisePropertyChanged();
            }
            get
            {
                return configViewModels;
            }
        }

        private ObservableCollection<StatusViewModel> statusViewModels = new ObservableCollection<StatusViewModel>();
        public ObservableCollection<StatusViewModel> StatusViewModels
        {
            private set
            {
                if (statusViewModels == value) return;
                statusViewModels = value;
                RaisePropertyChanged();
            }
            get
            {
                return statusViewModels;
            }
        }

        public PtzCameraCommand PtzCameraCommand { protected set; get; }

        public CameraViewModel(CameraController cameraController)
        {
            CameraController = cameraController;
            PtzCameraCommand = new PtzCameraCommand(this);
            StatusViewModels.Add(new ViewModels.Status.Ptz(CameraController));
            ConfigViewModels.Add(new ViewModels.Config.Ptz(CameraController));
        }
    }
}
