using Sauron.Controllers;
using Sauron.Utils;
using Sauron.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sauron.ViewModels.Status
{
    public abstract class StatusViewModel : BaseViewModel
    {
        public CameraController CameraController { protected set; get; }
        
        public StatusViewModel(CameraController cameraController)
        {
            CameraController = cameraController;
            Update();
        }

        public void Update()
        {
            ParseJson(Service.Call(CameraController, string.Format(Sauron.Properties.Resources.GetStatusUrl, GetType().Name.ToLower(), 0)));
        }

        public virtual void ParseJson(string json) { }
    }
}
