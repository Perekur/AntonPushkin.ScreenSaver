using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace СlockScreenSaver
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static App Current
        {
            get { return (App) Application.Current; }
        }


        public static bool IsScreenSaver
        {
            get
            {
                var assemblyPath = AppDomain.CurrentDomain.BaseDirectory;
                return !String.IsNullOrEmpty(assemblyPath) && assemblyPath.EndsWith(".scr");
            }
        }

        void OnStartup(Object sender, StartupEventArgs e)
        {            
            string[] args = e.Args;
            if (args.Length > 0)
            {
                // Получение аргументов
                string arg = args[0].ToLower(CultureInfo.InvariantCulture).Trim().Substring(0, 2);
                switch (arg)
                {
                    case "/c":
                        // Открытие окна опций
                        ShowOptions();
                        break;
                    case "/p":
                        // Превью
                        FullScreenView();                        
                        break;
                    case "/s":
                        // Полноэкранный режим                        
                        FullScreenView();
                        break;
                    default:
                        Application.Current.Shutdown();
                        break;
                }
            }
            else
            {
                //ShowOptions();
                FullScreenView();
            }
        }

        private static void ShowOptions()
        {
            // TODO: Show color picker     
            Application.Current.Shutdown();
        }

        
        void FullScreenView()
        {
            ScreenSaver wnd = new ScreenSaver(); ;
            
            System.Windows.Forms.Screen primaryScreen = System.Windows.Forms.Screen.PrimaryScreen;
            System.Windows.Forms.Screen secondaryScreen = System.Windows.Forms.Screen.AllScreens.Where(s => !s.Primary).LastOrDefault();
            
            if (secondaryScreen != null)
            {
                var workingArea = secondaryScreen.Bounds;
                wnd.Left = workingArea.Left;
                wnd.Top = workingArea.Top;
                wnd.Width = workingArea.Width;
                wnd.Height = workingArea.Height;

                // If window isn't loaded then maxmizing will result in the window displaying on the primary monitor
                wnd.Loaded+=(s,arg)=>
                {
                    wnd.WindowState = WindowState.Maximized;
                };
            }
            else if (primaryScreen != null)                                     
            {
                var location = primaryScreen.Bounds;                
                wnd.Left = 0;
                wnd.Top = 0;
                wnd.Width = location.Width;
                wnd.Height = location.Height;

                // If window isn't loaded then maxmizing will result in the window displaying on the primary monitor
                wnd.WindowState = WindowState.Maximized;
            }

            wnd.Show();
        }
    }
}
