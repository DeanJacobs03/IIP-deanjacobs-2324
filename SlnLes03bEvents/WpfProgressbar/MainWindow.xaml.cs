using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace WpfProgressbar
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer;
        private double _progress;

        public MainWindow()
        {
            InitializeComponent();

            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromMilliseconds(100);
            _timer.Tick += Timer_Tick;

            _progress = 0;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            StartButton.IsEnabled = false;
            AnnuleerButton.IsEnabled = true;

            _timer.Start();

            ProgressRectangle.Visibility = Visibility.Visible;
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            AnnuleerButton.IsEnabled = false;
            StartButton.IsEnabled = true;

            _timer.Stop();
            _progress = 0;

            UpdateProgressBar();

            ProgressRectangle.Visibility = Visibility.Collapsed;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            _progress += 0.05;

            if (_progress >= 1)
            {
                _timer.Stop();
                AnnuleerButton.IsEnabled = false;
                StartButton.IsEnabled = true;
            }

            UpdateProgressBar();
        }
        private void UpdateProgressBar()
        {
            ProgressRectangle.Width = _progress * 200;
            LblProgress.Content = $"{_progress * 100:F0}%";

            if (_progress >= 1)
            {
                LblProgress.Content = "klaar";
            }
        }
    }
}