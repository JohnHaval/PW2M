using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW2N.TaskClasses
{
    public static class CenturyFind
    {
        public static int GetCentury(int year)
        {
            if (year < 0) throw new Exception();
            int result;
            result = year / 100;
            if (year % 100 != 0) result++;
            return result;
        }
    }
}
