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
            Data data = new Data();



            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
    public class Data
    {
        static int rows = 12;
        static int columns = 4;
        public string[,] dataSet = new string[rows, columns];
    }

        /*  public static void BubbleSort(string[,] dataSet, int sortByColumn)
 {
     int arraySize = 12;
     bool swapped;

     do
     {
         swapped = false;

         for (int i = 1; i < arraySize; i++)
         {
             if (string.Compare(dataSet[i - 1, 0], dataSet[i, 0]) > 0)
             {
                 for (int j = 0; j < dataSet.GetLength(1); j++)
                 {
                     string temp = dataSet[i - 1, j];
                     dataSet[i - 1, j] = dataSet[i, j];
                     dataSet[i, j] = temp;
                 }
             }
         } 
     } while (swapped);

 } */
}