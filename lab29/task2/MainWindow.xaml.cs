using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

namespace task2
{
	public partial class MainWindow : Window
	{
		private System.Windows.Controls.Image bannerImage;
		private TranslateTransform translateTransform;
		private DispatcherTimer timer;
		private int bannerWidth;
		private const int ShiftStep = 3; 

		public MainWindow()
		{
			InitializeComponent();
			Loaded += MainWindow_Loaded;
		}

		private void MainWindow_Loaded(object sender, RoutedEventArgs e)
		{
			try
			{
				BitmapImage bitmap = new BitmapImage(new Uri("banner.png", UriKind.Relative));
				bannerWidth = bitmap.PixelWidth;

				bannerImage = new System.Windows.Controls.Image
				{
					Source = bitmap,
					Width = bannerWidth,
					Height = bitmap.PixelHeight
				};

				translateTransform = new TranslateTransform();
				bannerImage.RenderTransform = translateTransform;

				MainCanvas.Children.Add(bannerImage);

				timer = new DispatcherTimer
				{
					Interval = TimeSpan.FromMilliseconds(50)
				};
				timer.Tick += Timer_Tick;
				timer.Start();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка загрузки файла баннера " + ex.Message, "Баннер");
				Close();
			}
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			translateTransform.X -= ShiftStep;

			if (Math.Abs(translateTransform.X) > bannerWidth)
				translateTransform.X += bannerWidth;
		}
	}
}

