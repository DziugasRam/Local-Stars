using Microsoft.Extensions.DependencyInjection;
using Server.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Forms
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            
            Server.Startup.ConfigureServicesStatic(services, ConfigurationManager.ConnectionStrings["DB"].ConnectionString, true);
            ServiceProvider = services.BuildServiceProvider();
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new FrontPage());
        }
    }
}
