using System;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.INNERDEFS
{
	public class InnerCardEventsArgs : EventArgs
	{
		public string card
		{
			get;
			set;
		}

		public DateTime fecha
		{
			get;
			set;
		}

		public int innerNum
		{
			get;
			set;
		}

		public InnerCardEventsArgs()
		{
		}
	}
}