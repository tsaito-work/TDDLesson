﻿using System.Collections.Generic;

namespace TDDLesson.UI
{
    public static class Calculation
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static object Ave(List<int> list)
        {
            int values = 0;
            foreach(var val in list)
            {
                values += val;
            }

            return values / list.Count;
        }
    }
}
