using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Class
{
    class Program
    {
        static void Main(string[] args)
        {

            

            List<string> d = new List<string>();
            List<string> c = new List<string>();

            d.Add("15");
            d.Add("16");
            d.Add("17");

            c.Add("1");
            c.Add("15");
            c.Add("17");

            for(int i = 0; i < 3; i++)
            {
                for(int e = 0; e<3; e++)
                {
                    if(d[i] == c[e])
                    {
                        Console.WriteLine("나는 빡빡이다"+ d[i] + c[e]);
                    }
                }
            }






        }
    }
}
