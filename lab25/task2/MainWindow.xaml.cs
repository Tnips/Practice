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

namespace task2
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			double a = double.Parse(aTextBox.Text);
			double b = double.Parse(bTextBox.Text);

			canvas.Children.Clear();

			Line xAxis = new Line { X1 = 0, Y1 = 400, X2 = 800, Y2 = 400, Stroke = Brushes.Black };
			Line yAxis = new Line { X1 = 400, Y1 = 0, X2 = 400, Y2 = 800, Stroke = Brushes.Black };
			canvas.Children.Add(xAxis);
			canvas.Children.Add(yAxis);

			Polyline polyline = new Polyline();
			polyline.Stroke = Brushes.Black;

			for (double x = -10; x <= 10; x += 0.1)
			{
				double y = a * x + b;
				polyline.Points.Add(new Point(50 * x + 400, 400 - 50 * y));
			}

			canvas.Children.Add(polyline);
		}
	}
}
