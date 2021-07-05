using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataType;
using Function;
namespace Utils.test
{
    public class Test
    {
        public static void Main()
        {
            DateTime dt = new DateTime();
            // ok
            BitQ_Point point = new BitQ_Point(100, 12.4, dt);

            // test ToUnix
            test_ToUnixTimestamp();
        }

        public static void test_ToUnixTimestamp()
        {
            DateTime dt = new DateTime(2021, 7, 5);
            int dtToTimestamp = Helper.ToUnixTimestamp(dt);
            Console.WriteLine("Result = " + dtToTimestamp + " expected to 1625418000 GTM +7");
        }
    }
}
