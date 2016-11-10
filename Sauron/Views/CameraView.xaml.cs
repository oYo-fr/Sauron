using Sauron.Converters;
using Sauron.ViewModels;
using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Controls;

namespace Sauron.Views
{
    /// <summary>
    /// Logique d'interaction pour CameraView.xaml
    /// </summary>
    public partial class CameraView : UserControl
    {
        public CameraView()
        {
            InitializeComponent();
            //player.MediaPlayer.VlcLibDirectory = new DirectoryInfo(Path.Combine(new FileInfo(Assembly.GetEntryAssembly().Location).DirectoryName, "lib\x64"));
            player.MediaPlayer.VlcLibDirectoryNeeded += MediaPlayer_VlcLibDirectoryNeeded;
            player.MediaPlayer.EndInit();
            DataContextChanged += CameraView_DataContextChanged;
        }

        private void MediaPlayer_VlcLibDirectoryNeeded(object sender, Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs e)
        {
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            if (currentDirectory == null)
                return;
            //if (AssemblyName.GetAssemblyName(currentAssembly.Location).ProcessorArchitecture == ProcessorArchitecture.X86)
                e.VlcLibDirectory = new DirectoryInfo(Path.Combine(currentDirectory, @".\lib\x86\"));
            //else
            //    e.VlcLibDirectory = new DirectoryInfo(Path.Combine(currentDirectory, @".\lib\x64\"));
        }

        private void CameraView_DataContextChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            //player.MediaPlayer.Play((Uri)(new CameraViewModelToRstpVideoStreamUrl()).Convert(((MainViewModel)DataContext).SelectedCameraViewModel, typeof(Uri), null, CultureInfo.InvariantCulture), null);
            player.MediaPlayer.Play("rtsp://admin:%40Krilik1@90.120.188.10:554/cam/realmonitor?channel=1&subtype=0", null);
        }
    }
}
