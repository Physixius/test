using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateVoorbeeld
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger log = new Logger();
            Writer wr = new Writer(log.writeMessage);
            wr("Hello PXL");
        }
    }
}
