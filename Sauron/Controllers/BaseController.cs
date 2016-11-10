using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sauron.Controllers
{
    [Serializable]
    public abstract class BaseController : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
