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
using System.Windows.Shapes;

namespace hotel_management_system
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MostrarLogin();
        }

        public void MostrarLogin()
        {
            ViewControl.Content = new Login(this);
        }

        public void MostrarInicio()
        {
            ViewControl.Content = new Inicio(this);
        }

        public void MostrarRecuperarPass()
        {
            ViewControl.Content = new RecuperarPass(this);
        }

    }
}
