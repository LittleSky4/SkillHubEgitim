﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());//()içinde hangi form yazılı olursa başlangıçta onu çalıştırır
			//windows form projesi çalıştırıldığında hangi formun açılacağını buradan ayarlıyoruz.
		}
	}
}
