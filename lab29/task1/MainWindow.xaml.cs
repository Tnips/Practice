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

namespace task1
{
	public partial class MainWindow : Window
	{
		private int x1, y1, x2, y2, rSecondHand, rHourHand;
		private double aSecond, aHour;
		private SolidColorBrush secondHandBrush = new SolidColorBrush(Colors.DarkRed);
		private SolidColorBrush hourHandBrush = new SolidColorBrush(Colors.DarkBlue);
		private Line secondHand, hourHand;

		public MainWindow()
		{
			InitializeComponent();
			Loaded += Form1_Load;
			CompositionTarget.Rendering += Timer1_Tick;
		}

		private void Form1_Load(object sender, RoutedEventArgs e)
		{
			rSecondHand = 150;
			rHourHand = 100;
			aSecond = 0;
			aHour = 0;

			x1 = (int)(this.Width / 2);
			y1 = (int)(this.Height / 2);

			x2 = x1 + (int)(rSecondHand * Math.Cos(aSecond));
			y2 = y1 - (int)(rSecondHand * Math.Sin(aSecond));

			secondHand = new Line
			{
				Stroke = secondHandBrush,
				StrokeThickness = 2,
				X1 = x1,
				Y1 = y1,
				X2 = x2,
				Y2 = y2
			};

			hourHand = new Line
			{
				Stroke = hourHandBrush,
				StrokeThickness = 4,
				X1 = x1,
				Y1 = y1,
				X2 = x1 + (int)(rHourHand * Math.Cos(aHour)),
				Y2 = y1 - (int)(rHourHand * Math.Sin(aHour))
			};

			MainCanvas.Children.Add(secondHand);
			MainCanvas.Children.Add(hourHand);
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			aSecond += 0.1;
			aHour += 0.01; 

			if (secondHand != null)
			{
				secondHand.X2 = x1 + (int)(rSecondHand * Math.Cos(aSecond));
				secondHand.Y2 = y1 - (int)(rSecondHand * Math.Sin(aSecond));
			}

			if (hourHand != null)
			{
				hourHand.X2 = x1 + (int)(rHourHand * Math.Cos(aHour));
				hourHand.Y2 = y1 - (int)(rHourHand * Math.Sin(aHour));
			}
		}
	}
}
