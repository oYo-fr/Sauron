using Sauron.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sauron.ViewModels.Status
{
    public class Ptz : StatusViewModel
    {
        public Ptz(CameraController cameraController)
            : base(cameraController)
        {
        }

        public override void ParseJson(string json) {
        }
    }
}
