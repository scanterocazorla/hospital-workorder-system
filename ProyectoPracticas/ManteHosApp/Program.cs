using ManteHos.Persistence;
using ManteHos.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManteHosApp
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ManteHosService service = new ManteHosService(new EntityFrameworkDAL(new ManteHosDbContext()));
            Application.Run(new ManteHosApp(service));
        }
    }
}
