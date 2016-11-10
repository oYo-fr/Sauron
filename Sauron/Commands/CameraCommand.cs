using Sauron.Utils;
using Sauron.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Sauron.Commands
{
    public class CameraCommand : BaseCommand<CameraViewModel>
    {
        protected CommandActionTypeEnum ActionType = CommandActionTypeEnum.Stop;
        protected string Url;
        
        public CameraCommand(CameraViewModel cameraViewModel)
            :base(cameraViewModel)
        {
            canExecute = true;
        }
    }
}
