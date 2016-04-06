using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;


namespace kemen
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            NameValueCollection cnfValues = ConfigurationManager.AppSettings;
            if ((Convert.ToInt16(cnfValues["numGruas"])) == 1)
              Application.Run(new kemen());
            else 
              Application.Run(new Launcher());
        }
    }
}
