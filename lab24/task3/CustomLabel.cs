using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3
{
	internal class CustomLabel : Label
	{
		private Color defaultColor = Color.Black;
		private Color hoverColor = Color.Red;
		public CustomLabel()
		{
			this.MouseEnter += (sender, e) =>
			{
				this.ForeColor = hoverColor;
			};

			this.MouseLeave += (sender, e) =>
			{
				this.ForeColor = defaultColor;
			};
		}
	}
	
}
