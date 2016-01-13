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
        public void ReadFromFile()
        {
            StreamReader reader = new StreamReader("PlotMap.txt");
            Console.Write(reader.ReadToEnd());
        }
    }
}
