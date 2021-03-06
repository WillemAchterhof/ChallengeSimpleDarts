using Darts;
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
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void okButton_Click(object sender, EventArgs e)
		{
			Player Player1 = new Player();
			Player Player2 = new Player();

			Player1.Name = "Willem";
			Player2.Name = "Mark";
				
			string winningPlayer = Game.PlayGame(Player1, Player2);

			resultLabel.Text = DisplayResult.ResultGame(Player1, Player2, winningPlayer);
		}
	}
}