using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Darts
{
	public class Dart
	{
		public int Score { get; set; }
		public Dart(Random random)
		{
		}
		string result = string.Empty;
		public string Trow()
		{
			result = "1";

			return result;
		}
	}
}