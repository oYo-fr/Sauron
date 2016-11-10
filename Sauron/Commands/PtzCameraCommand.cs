using Sauron.Utils;
using Sauron.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sauron.Commands
{
    public class PtzCameraCommand : CameraCommand
    {
        public PtzCameraCommand(CameraViewModel cameraViewModel)
            :base(cameraViewModel)
        {
            canExecute = true;
            Url = "/cgi-bin/ptz.cgi?";
        }

        public override void Execute(object parameter)
        {
            string result = Service.Call(this.BaseViewModel.CameraController, ((PtzCameraCommandParameter) parameter).CreateInstruction(Url, CommandActionTypeEnum.Start));
            Thread.Sleep(100);
            result = Service.Call(this.BaseViewModel.CameraController, ((PtzCameraCommandParameter)parameter).CreateInstruction(Url, CommandActionTypeEnum.Stop));
        }
    }
}
