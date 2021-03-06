using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Darts
{
	public class Dart
	{
		public int Score { get; set; }
		public bool RingDouble { get; set; }
		public bool RingTriple { get; set; }
		public bool BullsEyeOuter { get; set; }
		public bool BullsEyeInner { get; set; }
		private Random random { get; set; }

		public Dart(Random random)
		{
			this.random = random;
			this.RingDouble = false;
			this.RingTriple = false;
			this.BullsEyeInner = false;
			this.BullsEyeOuter = false;
		}
		public void Trow()
		{
			this.Score = this.random.Next(0, 21);
			int score = this.random.Next(101);

			if (this.Score == 0) {
				BullsEyeHit(score);
			}
			else {
				RingHit(score);
			}
		}
		private void BullsEyeHit(int score)
		{
			if (score <= 5) { 
				this.BullsEyeInner = true; }
			else { 
				this.BullsEyeOuter = true; }
		}
		private void RingHit(int score)
		{
			if (score <= 5) {
				RingDouble = true;
			}
			else if (score > 95) {
				RingTriple = true;
			}
		}
	}
}
