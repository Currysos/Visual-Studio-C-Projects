using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearning
{
    public class ClassLibrary
    {
        //Print
        public void Print(object WhatToPrint)
        {
            Console.WriteLine(WhatToPrint);
        }
        public void PrintArr(object[] WhatToPrint)
        {
            Array.ForEach(WhatToPrint, Console.Write);
        }

        //Convertion
        public string ToString(object WhatToConvert)
        {
            return Convert.ToString(WhatToConvert);
        }
        public int ToInt(object WhatToConvert)
        {
            return Convert.ToInt32(WhatToConvert);
        }
        public float ToFloat(object WhatToConvert)
        {
            return Convert.ToSingle(WhatToConvert);
        }
        public bool ToBool(object WhatToConvert)
        {
            return Convert.ToBoolean(WhatToConvert);
        }
    }
}
