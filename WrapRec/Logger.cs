﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapRec
{
	public static class Logger
	{
		// Log levels
		// Trace, Debug, Info, Warn, Error, Fatal
		public static NLog.Logger Current = NLog.LogManager.GetLogger("infoLogger");
	}
}
