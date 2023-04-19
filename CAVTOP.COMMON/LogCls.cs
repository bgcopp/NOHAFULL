using System;
using System.Globalization;
using System.IO;

namespace BGCOP.CAVTOP.COMMON
{
	public class LogCls
	{
		private string _eventoLog;

		private string _fpath;

		public string Evento
		{
			get
			{
				return this._eventoLog;
			}
			set
			{
				this._eventoLog = value;
			}
		}

		public string FilePath
		{
			get
			{
				return this._fpath;
			}
			set
			{
				this._fpath = value;
			}
		}

		public LogCls()
		{
		}

		public void AddEvent()
		{
			int num = this._fpath.IndexOf(".", StringComparison.Ordinal);
			string str = this._fpath;
			int day = DateTime.Now.Day;
			string str1 = day.ToString("0#");
			day = DateTime.Now.Month;
			string str2 = day.ToString("0#");
			day = DateTime.Now.Year;
			string str3 = str.Insert(num, string.Concat(str1, str2, day.ToString(CultureInfo.InvariantCulture)));
			try
			{
				StreamWriter streamWriter = new StreamWriter(str3, true);
				string[] shortDateString = new string[] { "[", null, null, null, null, null };
				DateTime now = DateTime.Now;
				shortDateString[1] = now.ToShortDateString();
				shortDateString[2] = " ";
				now = DateTime.Now;
				shortDateString[3] = now.ToShortTimeString();
				shortDateString[4] = "] ";
				shortDateString[5] = this._eventoLog;
				streamWriter.WriteLine(string.Concat(shortDateString));
				streamWriter.Close();
			}
			catch (Exception exception)
			{
			}
		}
	}
}