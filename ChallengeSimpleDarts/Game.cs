using Darts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeSimpleDarts
{
	public class Game
	{
		static Dart dart = new Dart(new Random());
		public static string PlayGame(Player firstPlayer, Player secondPlayer)
		{
			while (firstPlayer.Score < 300 && secondPlayer.Score < 300)
			{
				Trow(firstPlayer);
				Trow(secondPlayer);
			}

			string winningPlayerName = (firstPlayer.Score > secondPlayer.Score) ? firstPlayer.Name : secondPlayer.Name;

			return winningPlayerName;
;
		}
		private static void Trow(Player player)
		{
				for (int i = 0; i < 3; i++)
				{
					dart.Trow();
					ringHit(dart.Score);
					player.Score += dart.Score;
				}
		}
		private static void ringHit(int score)
		{
			score = (dart.BullsEyeOuter) ? 25 : score;
			score = (dart.BullsEyeInner) ? 50 : score;
			score = (dart.RingDouble) ? score * 2 : score;
			score = (dart.RingTriple) ? score * 3 : score;

			dart.Score = score;
		}
	}
}