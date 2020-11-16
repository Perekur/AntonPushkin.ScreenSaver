using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace СlockScreenSaver
{
    /// <summary>
    /// Логика взаимодействия для Clock.xaml
    /// </summary>
    public partial class Clock : UserControl
    {
        private DispatcherTimer _timer = new DispatcherTimer();
        
        
        public Clock()
        {
            InitializeComponent();

            UpdateClock(null, null);
            
            this.Loaded += Clock_Loaded;
        }

                         
        void Clock_Loaded(object sender, RoutedEventArgs e)
        {
            this._timer.Interval = TimeSpan.FromSeconds(1);
            this._timer.Tick += UpdateClock;
            this._timer.Start();

        }

        void UpdateClock(object sender, EventArgs e)
        {            
            var time = DateTime.Now;            

            var angleHourArrowTransform = this.FindName("AngleHourArrow") as RotateTransform;
            if (angleHourArrowTransform != null)
                angleHourArrowTransform.Angle = (double) (time.Hour + (double)time.Minute / 60 + (double)time.Second/3600) / 12 * 360;
            
            var angleMinuteArrowTransform = this.FindName("AngleMinuteArrow") as RotateTransform;
            if (angleMinuteArrowTransform != null)
                angleMinuteArrowTransform.Angle = (double)(time.Minute + (double)time.Second / 60) / 60 * 360;

            var angleHourSecondTransform = this.FindName("AngleSecondArrow") as RotateTransform;
            if (angleHourSecondTransform != null)
                angleHourSecondTransform.Angle = (double)time.Second / 60 * 360;            

            var txtTime = this.FindName("txtTime") as TextBlock;
            if (txtTime != null)
                txtTime.Text = time.ToString("hh:mm:ss");

            //var secondsArrowAnimation = this.FindResource("SecondsArrowAnimation") as Storyboard;
            //if (secondsArrowAnimation != null)
            //{
            //    secondsArrowAnimation.Stop();
            //    this.BeginStoryboard(secondsArrowAnimation);
            //}
        }

    }
}

