using Sauron.Utils;
using Sauron.ViewModels;

namespace Sauron.Commands
{
    public sealed class ZoomTeleCommand : CameraCommand
    {
        public ZoomTeleCommand(CameraViewModel cameraViewModel)
            :base(cameraViewModel)
        {
            canExecute = true;
            Url = "/cgi-bin/ptz.cgi?";
            Code = "ZoomTele";
        }

        public override void Execute(object parameter)
        {
            if (parameter is CommandActionTypeEnum)
            {
                ActionType = (CommandActionTypeEnum)parameter;
            }
            Service.Call(this.BaseViewModel.CameraController, base.ToString());
        }
    }
}
