using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClientApp
{
    //索引器 get
    public class IndexorTest
    {
        public int[] items = new int[10];

        public int this[int index]
        {
            get 
            {
                return items[index];
            }

            set {
                items[index] = value;
            }
        }
    }
}
