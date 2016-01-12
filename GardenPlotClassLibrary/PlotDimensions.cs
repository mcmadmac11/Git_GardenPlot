using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenPlotProgram
{
    public class PlotDimensions
    {

        
        public List<string> DimensionList = new List<string>();
        public  void dimensionList(int x, int y, int width, int height)
        {
            string XString = x.ToString() ;
            string YString = y.ToString();
            string WidthString = width.ToString();
            string HeightString = height.ToString();

            DimensionList.Add(XString);
            DimensionList.Add(YString);
            DimensionList.Add(WidthString);
            DimensionList.Add(HeightString);

  

        }
    }
}
