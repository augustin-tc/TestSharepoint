using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSharePoint.EventReceiver.Utilities
{
    class Logger
    {
        public static void Log(string message)
        {
            using (System.IO.StreamWriter str = new System.IO.StreamWriter("test_log.log"))
            {
                str.WriteLine(message);
            }
        }
    }
}
