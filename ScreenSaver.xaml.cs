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
using KeyEventArgs = System.Windows.Input.KeyEventArgs;

namespace СlockScreenSaver
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class ScreenSaver : Window
    {
        public ScreenSaver()
        {
            InitializeComponent();
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (App.IsScreenSaver || e.Key==Key.Escape)
                Close();            
        }

        private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (App.IsScreenSaver)
                Close();
        }
    }
}
