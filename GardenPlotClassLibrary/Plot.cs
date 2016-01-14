using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenPlotProgram
{


    public class Plot
    {
        public Plot()
        {

            PlotDimensions plotDimension = new PlotDimensions();
            plotDimension.dimensionList(2, 2, 10, 20);
            plotDimension.dimensionList(100, 10, 5, 5);
            plotDimension.dimensionList(5, 5, 10, 10);

        }
    }
}
