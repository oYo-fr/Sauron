using Sauron.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sauron.ViewModels.Config
{
    public class Ptz : ConfigViewModel
    {
        public Ptz(CameraController cameraController)
            : base(cameraController)
        {
        }

        public override void ParseJson(string json) {
        }
    }
}
