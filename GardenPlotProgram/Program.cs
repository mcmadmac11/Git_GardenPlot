using System;
using System.Collections.Generic;
using System.IO;
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
            PlotDimensions plot2 = new PlotDimensions();
            
            //plot1.dimensionList(2,2,10,10);
            //plot2.dimensionList(4, 9, 3, 7);

            //new FileWriter();

            StreamWriter sw = new StreamWriter("PlotMap.txt");
           
            

            foreach (var item in plot1.DimensionList)
            {
                Console.Write(item);
            }

            foreach (var item in plot2.DimensionList)
            {
                sw.Write(item);
            }
            sw.Close();


            



        }
    }
}
