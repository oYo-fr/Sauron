using Sauron.ViewModels;
using System.Linq;

namespace Sauron.DesignTimeViewModels
{
    public class DTMainViewModel : MainViewModel
    {
        public DTMainViewModel()
            : base()
        {
            CameraViewModels.Add(new DTCameraViewModel());
            SelectedCameraViewModel = CameraViewModels.FirstOrDefault();
        }
    }
}
