using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class SimpleFunction
    {
        public string GoodMorning(int hour)
        {
            if (hour == 8) return "Good morning!";

            else return "It is not 8AM!";
        }
    }
}
