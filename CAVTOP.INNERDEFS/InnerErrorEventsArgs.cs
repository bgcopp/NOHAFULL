using System;

namespace BGCOP.CAVTOP.INNERDEFS
{
	public class InnerErrorEventsArgs : EventArgs
	{
		private string _MensajeError;

		private string _SourceError;

		public string MensajeError
		{
			get
			{
				return this._MensajeError;
			}
			set
			{
				this._MensajeError = value;
			}
		}

		public string SourceError
		{
			get
			{
				return this._SourceError;
			}
			set
			{
				this._SourceError = value;
			}
		}

		public InnerErrorEventsArgs()
		{
		}
	}
}