using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CarRevApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
        Windows.Storage.StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;

        public MainPage()
        {
            this.InitializeComponent();

            if (localSettings.Values["rec"] == null)
            {
                localSettings.Values["rec"] = 0;
                textBlock.Text = "Soundboard has been used " + localSettings.Values["rec"] + " times";
            }
            else
            {
                textBlock.Text = "Soundboard has been used " + localSettings.Values["rec"] + " times";
            }
        }

        private async void sound1_Click(object sender, RoutedEventArgs e)
        {
            var element = new MediaElement();
            var folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            var file = await folder.GetFileAsync("sound1.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            element.SetSource(stream, "");
            element.Play();

            localSettings.Values["rec"] = (int)localSettings.Values["rec"] + 1;
            textBlock.Text = "Soundboard has been used " + localSettings.Values["rec"] + " times";
        }

        private async void sound2_Click(object sender, RoutedEventArgs e)
        {
            var element = new MediaElement();
            var folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            var file = await folder.GetFileAsync("sound2.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            element.SetSource(stream, "");
            element.Play();

            localSettings.Values["rec"] = (int)localSettings.Values["rec"] + 1;
            textBlock.Text = "Soundboard has been used " + localSettings.Values["rec"] + " times";
        }

        private async void sound3_Click(object sender, RoutedEventArgs e)
        {
            var element = new MediaElement();
            var folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            var file = await folder.GetFileAsync("sound3.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            element.SetSource(stream, "");
            element.Play();

            localSettings.Values["rec"] = (int)localSettings.Values["rec"] + 1;
            textBlock.Text = "Soundboard has been used " + localSettings.Values["rec"] + " times";
        }

        private async void sound4_Click(object sender, RoutedEventArgs e)
        {
            var element = new MediaElement();
            var folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            var file = await folder.GetFileAsync("sound4.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            element.SetSource(stream, "");
            element.Play();

            localSettings.Values["rec"] = (int)localSettings.Values["rec"] + 1;
            textBlock.Text = "Soundboard has been used " + localSettings.Values["rec"] + " times";
        }

        private async void sound5_Click(object sender, RoutedEventArgs e)
        {
            var element = new MediaElement();
            var folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            var file = await folder.GetFileAsync("sound5.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            element.SetSource(stream, "");
            element.Play();

            localSettings.Values["rec"] = (int)localSettings.Values["rec"] + 1;
            textBlock.Text = "Soundboard has been used " + localSettings.Values["rec"] + " times";
        }

        private async void sound6_Click(object sender, RoutedEventArgs e)
        {
            var element = new MediaElement();
            var folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            var file = await folder.GetFileAsync("sound6.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            element.SetSource(stream, "");
            element.Play();

            localSettings.Values["rec"] = (int)localSettings.Values["rec"] + 1;
            textBlock.Text = "Soundboard has been used " + localSettings.Values["rec"] + " times";
        }

        private async void sound7_Click(object sender, RoutedEventArgs e)
        {
            var element = new MediaElement();
            var folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            var file = await folder.GetFileAsync("sound7.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            element.SetSource(stream, "");
            element.Play();

            localSettings.Values["rec"] = (int)localSettings.Values["rec"] + 1;
            textBlock.Text = "Soundboard has been used " + localSettings.Values["rec"] + " times";
        }

        private async void sound8_Click(object sender, RoutedEventArgs e)
        {
            var element = new MediaElement();
            var folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            var file = await folder.GetFileAsync("sound8.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            element.SetSource(stream, "");
            element.Play();

            localSettings.Values["rec"] = (int)localSettings.Values["rec"] + 1;
            textBlock.Text = "Soundboard has been used " + localSettings.Values["rec"] + " times";
        }

        private async void sound9_Click(object sender, RoutedEventArgs e)
        {
            var element = new MediaElement();
            var folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            var file = await folder.GetFileAsync("sound9.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            element.SetSource(stream, "");
            element.Play();

            localSettings.Values["rec"] = (int)localSettings.Values["rec"] + 1;
            textBlock.Text = "Soundboard has been used " + localSettings.Values["rec"] + " times";
        }

        private async void sound10_Click(object sender, RoutedEventArgs e)
        {
            var element = new MediaElement();
            var folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            var file = await folder.GetFileAsync("sound10.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            element.SetSource(stream, "");
            element.Play();

            localSettings.Values["rec"] = (int)localSettings.Values["rec"] + 1;
            textBlock.Text = "Soundboard has been used " + localSettings.Values["rec"] + " times";
        }
    }
}
