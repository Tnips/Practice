using System.Text;
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
		public MainWindow()
		{
			InitializeComponent();
			DrawShapes();
		}
		private void DrawShapes()
		{
			Polygon triangle = new Polygon
			{
				Points = new PointCollection(new Point[]
				{
					new Point(100, 50),
					new Point(150, 150),
					new Point(50, 150)
				}),
				Stroke = Brushes.Black,
				StrokeThickness = 2
			};
			drawingCanvas.Children.Add(triangle);

			Ellipse ellipse = new Ellipse
			{
				Width = 100,
				Height = 60,
				Stroke = Brushes.Black,
				StrokeThickness = 2
			};
			Canvas.SetLeft(ellipse, 200);
			Canvas.SetTop(ellipse, 50);
			drawingCanvas.Children.Add(ellipse);

			Ellipse filledCircle = new Ellipse
			{
				Width = 50,
				Height = 50,
				Fill = Brushes.Blue,
				Stroke = Brushes.Black,
				StrokeThickness = 2
			};
			Canvas.SetLeft(filledCircle, 350);
			Canvas.SetTop(filledCircle, 50);
			drawingCanvas.Children.Add(filledCircle);

			Rectangle filledRectangle = new Rectangle
			{
				Width = 100,
				Height = 50,
				Fill = Brushes.Green,
				Stroke = Brushes.Black,
				StrokeThickness = 2
			};
			Canvas.SetLeft(filledRectangle, 450);
			Canvas.SetTop(filledRectangle, 50);
			drawingCanvas.Children.Add(filledRectangle);

			Path sector = new Path
			{
				Fill = Brushes.Red,
				Stroke = Brushes.Black,
				StrokeThickness = 2,
				Data = Geometry.Parse("M 600,100 A 50,50 0 1 1 650,150 L 600,100")
			};
			drawingCanvas.Children.Add(sector);

			DrawConcentricCircles(50, 300, 30);

			DrawOverlappingRectangles(200, 300);

			DrawCheckerboard(400, 300, 40, 8);
		}

		private void DrawConcentricCircles(double x, double y, double radius)
		{
			for (int i = 0; i < 3; i++)
			{
				Ellipse circle = new Ellipse
				{
					Width = radius * 2,
					Height = radius * 2,
					Stroke = Brushes.Black,
					StrokeThickness = 2
				};
				Canvas.SetLeft(circle, x - radius);
				Canvas.SetTop(circle, y - radius);
				drawingCanvas.Children.Add(circle);
				radius -= 10;
			}
		}

		private void DrawOverlappingRectangles(double x, double y)
		{
			for (int i = 0; i < 5; i++)
			{
				Rectangle rect = new Rectangle
				{
					Width = 40,
					Height = 60,
					Stroke = Brushes.Black,
					StrokeThickness = 2
				};
				Canvas.SetLeft(rect, x + i * 20);
				Canvas.SetTop(rect, y + i * 20);
				drawingCanvas.Children.Add(rect);
			}
		}

		private void DrawCheckerboard(double x, double y, double size, int gridSize)
		{
			for (int row = 0; row < gridSize; row++)
			{
				for (int col = 0; col < gridSize; col++)
				{
					Rectangle rect = new Rectangle
					{
						Width = size,
						Height = size,
						Fill = (row + col) % 2 == 0 ? Brushes.White : Brushes.Black
					};
					Canvas.SetLeft(rect, x + col * size);
					Canvas.SetTop(rect, y + row * size);
					drawingCanvas.Children.Add(rect);
				}
			}
		}
	}
	
}