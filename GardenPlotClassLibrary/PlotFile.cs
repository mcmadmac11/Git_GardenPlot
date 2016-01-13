namespace GardenPlotProgram
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class PlotFile
    {
        string plotFile;
        public string readPlotFile(string _plotFile)
        {
            this.plotFile = _plotFile;
            return this.plotFile;
        }
    }
}
