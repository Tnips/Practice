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

namespace task4
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private bool isMouseOverButton = false;
		private Random random = new Random();

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_MouseEnter(object sender, MouseEventArgs e)
		{
			if (!isMouseOverButton)
			{
				Button newButton = new Button();
				newButton.Content = "Новая кнопка";
				newButton.MouseEnter += Button_MouseEnter;
				newButton.Click += Button_Click;
				newButton.MouseLeave += Button_MouseLeave;

				Canvas.SetLeft(newButton, random.Next(0, (int)canvas.ActualWidth - 100));
				Canvas.SetTop(newButton, random.Next(0, (int)canvas.ActualHeight - 50));

				canvas.Children.Add(newButton);
				isMouseOverButton = true;
			}
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Button button = (Button)sender;
			if (button.Parent is Panel parentPanel)
			{
				parentPanel.Children.Remove(button);
			}
		}

		private void Button_MouseLeave(object sender, MouseEventArgs e)
		{
			isMouseOverButton = false;
		}
	}
}
