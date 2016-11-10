namespace Sauron.Controllers
{
    public class CameraController : BaseController
    {
        private string login;
        public string Login
        {
            set
            {
                if (login == value) return;
                login = value;
                RaisePropertyChanged();
            }
            get { return login; }
        }

        private string password;
        public string Password
        {
            set
            {
                if (password == value) return;
                password = value;
                RaisePropertyChanged();
            }
            get { return password; }
        }

        private string ipAddress;
        public string IpAddress
        {
            set
            {
                if (ipAddress == value) return;
                ipAddress = value;
                RaisePropertyChanged();
            }
            get { return ipAddress; }
        }

        private short rtspPort;
        public short RtspPort
        {
            set
            {
                if (rtspPort == value) return;
                rtspPort = value;
                RaisePropertyChanged();
            }
            get { return rtspPort; }
        }

        private short port;
        public short Port
        {
            set
            {
                if (port == value) return;
                port = value;
                RaisePropertyChanged();
            }
            get { return port; }
        }

        private string protocol;
        public string Protocol
        {
            set
            {
                if (protocol == value) return;
                protocol = value;
                RaisePropertyChanged();
            }
            get { return protocol; }
        }
    }
}
