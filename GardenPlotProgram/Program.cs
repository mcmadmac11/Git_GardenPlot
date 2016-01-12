using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GardenPlotProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            PlotDimensions plot1 = new PlotDimensions();
            
            plot1.dimensionList(2, 2, 4, 4);
            
            foreach (var item in plot1.DimensionList)
            {
                Console.Write(item);
            }

           


        }
    }
}
