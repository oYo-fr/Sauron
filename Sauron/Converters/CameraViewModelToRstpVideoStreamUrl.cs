using Sauron.Utils;
using Sauron.ViewModels;
using System;
using System.Globalization;
using System.Web;

namespace Sauron.Converters
{
    public class CameraViewModelToRstpVideoStreamUrl : BaseConverter
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(!(value is CameraViewModel))
            {
                return null;
            }
            CameraViewModel cameraViewModel = (value as CameraViewModel);
            return new Uri(string.Format(Constants.Rstp,
                HttpUtility.UrlEncode(cameraViewModel.CameraController.Login),
                HttpUtility.UrlEncode(cameraViewModel.CameraController.Password),
                HttpUtility.UrlEncode(cameraViewModel.CameraController.IpAddress),
                HttpUtility.UrlEncode(cameraViewModel.CameraController.RtspPort.ToString()),
                Properties.Resources.VideoUrl));
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
