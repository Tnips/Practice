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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace task6
{
	public partial class MainWindow : Window
	{
		private DispatcherTimer timer;
		public MainWindow()
		{
			InitializeComponent();
			InitializeClock();
		}

		private void InitializeClock()
		{
			Canvas.SetLeft(SecondHand, ClockCanvas.Width / 2 - SecondHand.Width / 2);
			Canvas.SetTop(SecondHand, ClockCanvas.Height / 2 - SecondHand.Height + 10);

			timer = new DispatcherTimer();
			timer.Interval = TimeSpan.FromSeconds(1);
			timer.Tick += Timer_Tick;
			timer.Start();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
			double angle = now.Second * 6; 
			RotateSecondHand(angle);
		}

		private void RotateSecondHand(double angle)
		{
			DoubleAnimation rotationAnimation = new DoubleAnimation
			{
				To = angle,
				Duration = TimeSpan.FromSeconds(0.5),
				EasingFunction = new CircleEase { EasingMode = EasingMode.EaseInOut }
			};
			SecondHandTransform.BeginAnimation(RotateTransform.AngleProperty, rotationAnimation);
		}
	}
}
