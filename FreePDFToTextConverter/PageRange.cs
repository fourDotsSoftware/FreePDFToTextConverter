using System;
using System.Collections.Generic;
using System.Text;

namespace FreePDFToTextConverter
{
    public class PageRange : ICloneable 
    {
        public bool Initialized = false;
                
        public int NumberOfPages = -1;
        public int IncludedNumberOfPages = -1;

        public bool AllPages = true;
        public bool Pages = false;
        public int PagesFrom = -1;
        public int PagesTo = -1;

        public bool PagesOdd = false;
        public int PagesOddFrom = -1;
        public int PagesOddTo = -1;

        public bool PagesEven = false;
        public int PagesEvenFrom = -1;
        public int PagesEvenTo = -1;

        public bool PagesEvery = false;
        public int PagesEveryValue = -1;
        public int PagesEveryFrom = -1;
        public int PagesEveryTo = -1;

        public string PageRanges = "";

        public bool PagesContainingText = false;
        public string PageText = "";

        public bool ImportReversed = false;

        public bool IsImage = false;

        public bool ScaleToFit = true;

        public bool ScaledSize = false;
        public int ScaledWidth = -1;
        public int ScaledHeight = -1;

        public bool ScaledPercentage = false;
        public int ScaledPercetnageValue = -1;

        public bool AbsolutePosition = false;
        public int AbsX = -1;
        public int AbsY = -1;

        public bool HorizAlign = true;
        //0 left 1 center 2 right
        public int HorizAlignValue = 3;

        public bool VertiAlign = true;
        //0 top 1 middle 2 bottom
        public int VertiAlignValue = 1;

        public object Clone()
        {            
            return this.MemberwiseClone();
        }
    }
}
