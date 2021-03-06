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
				
			string winningPlayer = string.Empty;
			resultLabel.Text = string.Empty;

			Game.PlayGame(Player1, Player2);

			if (Player1.Score > Player2.Score) {
				winningPlayer = "Player1";
			}
			else { winningPlayer = "Player2"; }

			resultLabel.Text = DisplayResult.ResultGame(Player1, Player2, winningPlayer);
		}
	}
}