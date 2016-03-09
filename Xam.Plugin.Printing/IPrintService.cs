﻿using System;

namespace Plugin.Printing
{
	public interface IPrintService
	{
		void PrintFile(string jobName, string pdfPath);

		void PrintWeb(string jobName, string url);
	}
}

