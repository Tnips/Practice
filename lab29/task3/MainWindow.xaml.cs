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

namespace task3
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private int x1, y1, x2, y2;
		private double a, t, fi;
		private Ellipse movingEllipse;
		private DispatcherTimer timer;

		public MainWindow()
		{
			InitializeComponent();
			Loaded += MainWindow_Loaded;
		}

		private void MainWindow_Loaded(object sender, RoutedEventArgs e)
		{
			x1 = (int)MainCanvas.ActualWidth / 2;
			y1 = (int)MainCanvas.ActualHeight / 2;

			a = 150;
			fi = -0.5;
			t = Math.Tan(fi);

			x2 = x1 + (int)((3 * a * t) / (1 + t * t * t));
			y2 = y1 - (int)((3 * a * t * t) / (1 + t * t * t));

			movingEllipse = new Ellipse
			{
				Width = 20,
				Height = 20,
				Stroke = Brushes.DarkRed,
				StrokeThickness = 2
			};

			Canvas.SetLeft(movingEllipse, x2);
			Canvas.SetTop(movingEllipse, y2);

			MainCanvas.Children.Add(movingEllipse);

			timer = new DispatcherTimer
			{
				Interval = TimeSpan.FromMilliseconds(50)
			};
			timer.Tick += Timer_Tick;
			timer.Start();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			fi += 0.01;
			t = Math.Tan(fi);

			x2 = x1 + (int)((3 * a * t) / (1 + t * t * t));
			y2 = y1 - (int)((3 * a * t * t) / (1 + t * t * t));

			Canvas.SetLeft(movingEllipse, x2);
			Canvas.SetTop(movingEllipse, y2);
		}
	}
}
