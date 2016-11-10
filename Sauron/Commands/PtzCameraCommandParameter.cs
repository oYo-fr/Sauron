using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sauron.Commands
{
    public class PtzCameraCommandParameter
    {
        public PtzCommandTypeEnum PtzCommandType;
        public int Channel = 0;
        public int Arg1 = 0;
        public int Arg2 = 0;
        public int Arg3 = 0;

        public string CreateInstruction(string url, CommandActionTypeEnum commandActionTypeEnum)
        {
            List<string> parameters = new List<string>();
            parameters.Add("action=" + Enum.GetName(typeof(CommandActionTypeEnum), commandActionTypeEnum).ToLower());
            parameters.Add("channel=" + Channel);
            parameters.Add("code=" + (PtzCommandTypeEnum)PtzCommandType);
            parameters.Add("arg1=" + Arg1);
            parameters.Add("arg2=" + Arg2);
            parameters.Add("arg3=" + Arg3);
            return url + string.Join("&", parameters);
        }
    }
}
