using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Tests
{
    public static class SimpleFunctionTest // mora biti static
    {
        public static void SimpleFunction_GoodMorning_ReturnString() // naming convention
        {
            // arrange
            // act
            // assert

            try
            {
                int hour = 8; // ovo testira, i tu varijablu mijenjam za testiranje
                SimpleFunction function = new SimpleFunction();

                string result = function.GoodMorning(hour);

                if(result == "Good morning!")
                {
                    Console.WriteLine("PASSED: SimpleFunction_GoodMorning_ReturnString()");
                }
                else
                {
                    Console.WriteLine("FAILED: SimpleFunction_GoodMorning_ReturnString()");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
