using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Data;

namespace Wiki_devel
{
    internal static class Program
    {
        [STAThread]
        public static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

    }
}