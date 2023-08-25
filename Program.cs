using System;
using System.Windows.Forms;

namespace Wiki_devel
{
    internal static class Program
    {
        [STAThread]
        public static void Main()
        {
            Data data = new Data();



            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
    public class Data
    {
        //Create a global 2D string array, use static variables for the dimensions [12,4]
        static int rows = 12;
        static int columns = 4; // Name, Category, Structure, Definition.

        public string[,] dataSet = new string[rows, columns];


    }
    public class AddEditDelete
    {

    }


       
}
// Create an add button that will store the information rom the 4 text boxes into the 2D array
