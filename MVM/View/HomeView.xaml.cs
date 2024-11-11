using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace PMS.MVM.View
{
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void Documents_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://google.com") { UseShellExecute = true });
        }

        private void Policies_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://google.com") { UseShellExecute = true });
        }

        private void Contacts_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://google.com") { UseShellExecute = true });
        }

        private void WebPage_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.hyatt.com/en-US/hotel/colorado/hyatt-vacation-club-at-the-ranahan/bresr") { UseShellExecute = true });
        }
    }
}
