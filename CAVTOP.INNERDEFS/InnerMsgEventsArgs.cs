using System;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.INNERDEFS
{
	public class InnerMsgEventsArgs : EventArgs
	{
		public string msg
		{
			get;
			set;
		}

		public InnerMsgEventsArgs()
		{
		}
	}
}