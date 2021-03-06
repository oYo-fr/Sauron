﻿using System.Collections.ObjectModel;
using System.Linq;

namespace Sauron.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private ObservableCollection<CameraViewModel> cameraViewModels = new ObservableCollection<CameraViewModel>();

        public ObservableCollection<CameraViewModel> CameraViewModels
        {
            get { return cameraViewModels; }
        }

        private CameraViewModel selectedCameraViewModel;
        public CameraViewModel SelectedCameraViewModel
        {
            set
            {
                if (selectedCameraViewModel == value) return;
                selectedCameraViewModel = value;
                RaisePropertyChanged();
            }
            get { return selectedCameraViewModel; }
        }

        public MainViewModel()
        {
        }
    }
}
