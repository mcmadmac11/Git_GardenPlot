using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GardenPlotProgram
{

    public class FileWriter
    {
        public void WriteToFile()
        {
            StreamWriter sw = new StreamWriter("PlotMap.txt");
            sw.Write("Hello, ");



            sw.Close();

        }
    }
}
