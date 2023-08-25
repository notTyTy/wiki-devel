using System.Data;

namespace Wiki_devel
{
    internal static class Program
    {
        [STAThread]
        public static void Main()
        {
            var data = new Data();
            Console.WriteLine(data.dataSet);


            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
    public class Data
    {
        static int row = 12;
        static int column = 4;
        public string[] dataSet = new string[12]
        {
          "one", "two", "three", "four", "five", "six",
          "seven", "eight", "nine", "ten", "eleven", "twelve" 
        };

    }
}
