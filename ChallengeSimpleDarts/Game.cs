using Darts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeSimpleDarts
{
	public class Game
	{
		Random randomTrow = new Random();

		Player Player1 = new Player();
		Player Player2 = new Player();

		string result = string.Empty;


		public void PlayGame()
		{
			Dart dart = new Dart(randomTrow);

			while (Player1.Score < 300 && Player2.Score < 300)
			{
				for (int i = 0; i < 3; i++)
				{
					dart.Trow();
					Player1.Score += dart.Score;
					resultLabel.Text += string.Format($"Player 1:{Player1.Score}<br />");
				}
				for (int i = 0; i < 3; i++)
				{
					dart.Trow();
					Player2.Score += dart.Score;
					resultLabel.Text += string.Format($"Player 2:{Player2.Score}<br />");
				}
			}
		}
	}
}