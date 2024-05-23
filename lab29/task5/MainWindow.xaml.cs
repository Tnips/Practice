using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace task5
{
	public partial class MainWindow : Window
	{
		private Rectangle fire;
		private Ellipse windowEllipse;

		public MainWindow()
		{
			InitializeComponent();
			AddRocketWindow();
		}

		private void AddRocketWindow()
		{
			windowEllipse = new Ellipse
			{
				Width = 20, 
				Height = 20, 
				Fill = Brushes.LightBlue 
			};

			Canvas canvas = (Canvas)Rocket.Parent; 
			canvas.Children.Add(windowEllipse); 

			Canvas.SetLeft(windowEllipse, Canvas.GetLeft(Rocket) + (Rocket.Width / 2) - (windowEllipse.Width / 2));
			Canvas.SetTop(windowEllipse, Canvas.GetTop(Rocket) + 40); 
		}

		private void LaunchButton_Click(object sender, RoutedEventArgs e)
		{
			Canvas canvas = (Canvas)Rocket.Parent; 

			if (fire != null && canvas.Children.Contains(fire))
			{
				canvas.Children.Remove(fire);
			}

			fire = new Rectangle
			{
				Width = 30, 
				Height = 60,
				Fill = Brushes.Red 
			};

			canvas.Children.Add(fire);

			Canvas.SetLeft(fire, Canvas.GetLeft(Rocket) + (Rocket.Width / 2) - (fire.Width / 2));
			Canvas.SetTop(fire, Canvas.GetTop(Rocket) + Rocket.Height);

			Storyboard storyboard = new Storyboard();

			DoubleAnimation rocketAnimation = new DoubleAnimation
			{
				From = Canvas.GetTop(Rocket),
				To = -Rocket.Height,
				Duration = new Duration(TimeSpan.FromSeconds(5))
			};
			Storyboard.SetTarget(rocketAnimation, Rocket);
			Storyboard.SetTargetProperty(rocketAnimation, new PropertyPath(Canvas.TopProperty));
			storyboard.Children.Add(rocketAnimation);


			DoubleAnimation fireAnimation = new DoubleAnimation
			{
				From = Canvas.GetTop(fire),
				To = -Rocket.Height + Rocket.Height,
				Duration = new Duration(TimeSpan.FromSeconds(5))
			};
			Storyboard.SetTarget(fireAnimation, fire);
			Storyboard.SetTargetProperty(fireAnimation, new PropertyPath(Canvas.TopProperty));
			storyboard.Children.Add(fireAnimation);

			DoubleAnimation windowAnimation = new DoubleAnimation
			{
				From = Canvas.GetTop(windowEllipse),
				To = -Rocket.Height + 40, 
				Duration = new Duration(TimeSpan.FromSeconds(5))
			};
			Storyboard.SetTarget(windowAnimation, windowEllipse);
			Storyboard.SetTargetProperty(windowAnimation, new PropertyPath(Canvas.TopProperty));
			storyboard.Children.Add(windowAnimation);

			storyboard.Begin();
		}
	}
}
