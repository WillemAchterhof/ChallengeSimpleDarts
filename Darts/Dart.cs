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
			int _score = this.random.Next(101)

			if (this.Score == 0) {
				BullsEyeHit(_score);
			}
			else {
				Ringhit(_score);
			}

		}
		private void BullsEyeHit(int _score)
		{
			if (_score <= 5) { 
				this.BullsEyeInner = true; }
			else { 
				this.BullsEyeOuter = true; }
		}
		private void Ringhit(int _score)
		{
			if (_score <= 5) {
				RingDouble = true;
			}
			else if (_score >= 95) {
				RingTriple = true;
			}
		}
	}
}