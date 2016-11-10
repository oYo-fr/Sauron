using Sauron.ViewModels;
using System;
using System.Collections.Generic;

namespace Sauron.Commands
{
    public class CameraCommand : BaseCommand<CameraViewModel>
    {
        protected int Channel = 0;
        protected string Code;
        protected int Arg1 = 0;
        protected int Arg2 = 0;
        protected int Arg3 = 0;
        protected CommandActionTypeEnum ActionType = CommandActionTypeEnum.Stop;
        protected string Url;
        public CameraCommand(CameraViewModel cameraViewModel)
            :base(cameraViewModel)
        {
            canExecute = true;
        }

        public override string ToString()
        {
            List<string> parameters = new List<string>();
            parameters.Add("action=" + Enum.GetName(typeof(CommandActionTypeEnum), ActionType).ToLower());
            parameters.Add("channel=" + Channel);
            parameters.Add("code=" + Code);
            parameters.Add("arg1=" + Arg1);
            parameters.Add("arg2=" + Arg2);
            parameters.Add("arg3=" + Arg3);
            return Url + string.Join("&", parameters);
        }
    }
}
