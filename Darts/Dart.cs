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

		private Random random;

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
			int score = this.random.Next(1, 101);

			this.BullsEyeInner = (this.Score == 0 && score <= 5) ? true : false;
			this.BullsEyeOuter = (this.Score == 0 && score > 5) ? true : false;

			this.RingDouble = (!this.BullsEyeInner && !this.BullsEyeOuter && score <= 5) ? true : false;
			this.RingTriple = (!this.BullsEyeInner && !this.BullsEyeOuter && score > 95) ? true : false;
		}
	}
}
