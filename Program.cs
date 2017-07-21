using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LaunchDemo
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            string idonothing = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            new Startup().LaunchApplication(args);
        }

        private void LaunchApplication(string[] args)
        {
            if (args != null)
            {

            }

            if (args == null || args.Length == 0)
            {
                Console.Error.WriteLine("The user did not send arguments");
                LaunchGUI();
                return;
            }
        }

        private void LaunchGUI()
        {
            System.Console.Error.WriteLine("launchGUI");
            new Form1().ShowDialog();
        }
    }
}
