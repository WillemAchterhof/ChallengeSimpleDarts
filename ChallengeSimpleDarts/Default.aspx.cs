using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleDarts
{
	public partial class Default : System.Web.UI.Page
	{
		Random randomTrow = new Random();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void okButton_Click(object sender, EventArgs e)
		{
			resultLabel.Text = string.Empty;
			Darts.Dart dart = new Darts.Dart(randomTrow);

			for (int i = 0; i < 20; i++)
			{
				dart.Trow();
				resultLabel.Text += dart.Score.ToString() + "<br />";
			}
		}
	}
}