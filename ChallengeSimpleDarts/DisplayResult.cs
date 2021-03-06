using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeSimpleDarts
{
	public class DisplayResult
	{
	
		public static string ResultGame(Player firstPlayer, Player secondPlayer, string winningPlayer)
		{
			string result = string.Format($"First Player's Score: {firstPlayer.Score}<br />" +
				$"Second Player's Score: {secondPlayer.Score}<br/>" +
				$"Winner: {winningPlayer}");
			
			return result;
		}
	}
}