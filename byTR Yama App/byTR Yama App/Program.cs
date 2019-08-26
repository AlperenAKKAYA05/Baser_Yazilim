using System;
using System.Windows.Forms;

namespace byTR_Yama_App
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002CCB File Offset: 0x00000ECB
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Tr_Yama());
		}
	}
}
