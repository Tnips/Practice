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
using System.Windows.Threading;

namespace task7
{

	public partial class MainWindow : Window
	{
		private DispatcherTimer timer;
		private double time;

		public MainWindow()
		{
			InitializeComponent();
			InitializeAnimation();
		}
		private void InitializeAnimation()
		{
			timer = new DispatcherTimer();
			timer.Interval = TimeSpan.FromMilliseconds(20); 
			timer.Tick += Timer_Tick;
			timer.Start();

			Canvas.SetLeft(MovingCircle, 0);
			Canvas.SetTop(MovingCircle, AnimationCanvas.Height / 2);
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			time += 0.1;

			double x = time * 20; 
			double y = (AnimationCanvas.Height / 2) + 50 * Math.Sin(x * 0.05); 

			Canvas.SetLeft(MovingCircle, x);
			Canvas.SetTop(MovingCircle, y);

			if (x > AnimationCanvas.Width)
			{
				time = 0;
				Canvas.SetLeft(MovingCircle, 0);
			}
		}
	}
}
	
