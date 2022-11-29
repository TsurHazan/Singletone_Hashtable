using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc_hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager mainTon=Manager.Instance;
            mainTon.loadTable();
        }
    }
}
