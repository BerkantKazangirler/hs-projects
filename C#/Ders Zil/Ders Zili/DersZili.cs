using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ders_Zili
{
	static class DersZili
	{
        //[STAThread]
		static void Main()
		{
			bool gizliMi = false;
			foreach (string i in Environment.GetCommandLineArgs())
			{
				if (i == "-gizli")
				{
					gizliMi = true;
				}
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			if (gizliMi)
			{
				Application.Run(new AnaForm(true));
			}
			else
			{
				Application.Run(new AnaForm(false));
			}
		}
	}
}