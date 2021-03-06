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
		public static void PlayGame(Player firstPlayer, Player secondPlayer)
		{
			while (firstPlayer.Score < 300 && secondPlayer.Score < 300)
			{
				for (int i = 0; i < 3; i++)
				{
					dart.Trow();
					ringHit(dart.Score);
					firstPlayer.Score += dart.Score;
				}
				for (int i = 0; i < 3; i++)
				{
					dart.Trow();
					ringHit(dart.Score);
					secondPlayer.Score += dart.Score;
				}
			}
		}

		private static void ringHit(int score)
		{
			score = (dart.BullsEyeOuter) ? 25 : score;
			score = (dart.BullsEyeInner) ? 50 : score;
			score = (dart.RingDouble) ? score * 2 : score;
			score = (dart.RingTriple) ? score * 3 : score;

			ringHitToFalse();

			dart.Score = score;
		}

		private static void ringHitToFalse()
		{
			dart.BullsEyeOuter = false;
			dart.BullsEyeInner = false;
			dart.RingDouble = false;
			dart.RingTriple = false;
		}
	}
}