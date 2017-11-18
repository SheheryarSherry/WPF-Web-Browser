using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using System.Net;
using fyp.Bookmarks;
using fyp.Applets;
using System.Windows.Shell;

namespace fyp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool Maximized;
        private AddBookmark Addbook;
        public List<TabView> Pages;
        private WebClient DLUpdate;
        private WebClient JsonDownload;
        

        public void CheckForUpdates()
        {
            Dispatcher.Invoke(() =>
            {
                try
                {
                    DLUpdate = new WebClient();
                    JsonDownload = new WebClient();
                    string ActualVersion =
                    Convert.ToString(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version);
                    string link = DLUpdate.DownloadString("http://www.google.com");
                    string newVersion = DLUpdate.DownloadString(link + "fyp/update.txt");
                    DLUpdate.DownloadFileCompleted += DLUpdate_DownloadFileCompleted;
                    var version1 = new Version(ActualVersion);
                    var version2 = new Version(newVersion);
                    var result = version1.CompareTo(version2);
                    if (result > 0)
                    {
                        Console.WriteLine("version is greater");
                    }
                    else if (result < 0)
                    {
                        JsonDownload.DownloadFileAsync(new Uri(link + "fyp/files.json"), "files.json");
                        this.Hide();
                        DLUpdate.DownloadFileAsync(new Uri(link + "fyp/Update.exe"), "Update.exe");


                    }
                    else
                    {
                        Console.WriteLine("versions are equal");
                        return;
                    }
                }
                catch (Exception ex)
                {

                }
            });
        }

        public void HideTabs()
        {
            container.Margin = new Thickness(0);
        }

        public void ShowTabs()
        {
            container.Margin = new Thickness(0,26,0,0);
        }
        //ek min
        private void DLUpdate_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            try
            {
                if (File.Exists("Update.exe"))
                {
                    Process.Start("Update.exe");
                    Application.Current.Shutdown();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update open: " + ex.Message);
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
