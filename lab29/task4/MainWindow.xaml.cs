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

namespace task4
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		// BitmapImages for sky and plane
		BitmapImage skyImage, planeImage;

		// Image elements for displaying sky and plane
		Image skyImageControl, planeImageControl;

		// DispatcherTimer for animation
		DispatcherTimer timer;

		// X-coordinate increment, determines flight speed
		int dx;

		// Random number generator
		Random rnd;
		public MainWindow()
		{
			InitializeComponent();
			// Initialize random number generator
			rnd = new Random();

			// Load bitmap images from resources
			skyImage = new BitmapImage(new Uri("C:\\Users\\LENOVO\\OneDrive\\Рабочий стол\\Practice\\lab29\\task4\\Resources\\sky.bmp"));
			planeImage = new BitmapImage(new Uri("C:\\Users\\LENOVO\\OneDrive\\Рабочий стол\\Practice\\lab29\\task4\\Resources\\plane.bmp"));

			// Create image controls for sky and plane
			skyImageControl = new Image { Source = skyImage };
			planeImageControl = new Image { Source = planeImage };

			// Set the initial position of the plane
			Canvas.SetLeft(planeImageControl, -40);
			Canvas.SetTop(planeImageControl, 20 + rnd.Next(20));

			// Add images to the canvas
			MainCanvas.Children.Add(skyImageControl);
			MainCanvas.Children.Add(planeImageControl);

			// Set flight speed
			dx = 2;

			// Initialize and start the timer for animation
			timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(20) };
			timer.Tick += Timer_Tick;
			timer.Start();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			// Move the plane
			double newX = Canvas.GetLeft(planeImageControl) + dx;
			if (newX < MainCanvas.ActualWidth)
			{
				Canvas.SetLeft(planeImageControl, newX);
			}
			else
			{

				Canvas.SetLeft(planeImageControl, -40);
				Canvas.SetTop(planeImageControl, 20 + rnd.Next((int)(MainCanvas.ActualHeight - 40 - planeImage.Height)));
				dx = 2 + rnd.Next(4);
			}
		}
	}
}