using Sauron.Controllers;
using Sauron.Utils;
using Sauron.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sauron.ViewModels.Config
{
    public abstract class ConfigViewModel : BaseViewModel
    {
        public CameraController CameraController { protected set; get; }
        
        public ConfigViewModel(CameraController cameraController)
        {
            CameraController = cameraController;
            Update();
        }

        public void Update()
        {
            ParseJson(Service.Call(CameraController, string.Format(Sauron.Properties.Resources.GetConfigUrl, GetType().Name)));
        }

        public virtual void ParseJson(string json) { }
    }
}
