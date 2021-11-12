using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp0
{
	class Options
	{
		public string nomoption;
		public int opmaxplace;
		public int placedisponible;

		public Options(string nomop, int maxinop)
		{
			this.nomoption = nomop;
			this.opmaxplace = maxinop;
			this.placedisponible = maxinop;
		}
	}
}