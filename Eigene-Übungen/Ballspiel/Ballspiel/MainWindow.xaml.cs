using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
using System.Windows.Threading;

namespace Ballspiel
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DispatcherTimer _animationsTimer = new DispatcherTimer();
        private bool gehtnachrechts = true;
        private bool gehtnachunten = true;
        public MainWindow()
        {
            InitializeComponent();
            _animationsTimer.Interval = TimeSpan.FromMilliseconds(35);
            _animationsTimer.Tick += PositioniereBall;
        }

        private void PositioniereBall(object sender, EventArgs e)
        {
            //-links-Rechts
            var x = Canvas.GetLeft(Ball);
            var y = Canvas.GetTop(Ball);

            if (gehtnachrechts)
            {
                Canvas.SetLeft(Ball, x+5);
            }
            else
            {
                Canvas.SetLeft(Ball, x-5);
            }
           
            if ( x >= Spielplatz.ActualWidth - Ball.Width)
            {
                gehtnachrechts = false;
            }
            else if  (x <= 0)
            {
                gehtnachrechts = true;
            }

            //oben-unten
            

            if (gehtnachunten)
            {
                Canvas.SetTop(Ball, y+5);
            }
            else
            {
                Canvas.SetTop(Ball, y-5);
            }

            if (y >= Spielplatz.ActualHeight - Ball.Height)
            {
                gehtnachunten = false;
            }
            else if (y <= 0)
            {
                gehtnachunten = true;
            }




            
        }

        private void StartStopButton_Click(object sender, RoutedEventArgs e)
        {
            if (_animationsTimer.IsEnabled) 
            {
                _animationsTimer.Stop();
            }
            else
            {
                _animationsTimer.Start();
            }
            

          
        }
    }
}
