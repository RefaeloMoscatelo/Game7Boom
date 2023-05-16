using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Game7Boom
{
    class Program
    {
        static void Main(string[] args)
        {
            Game7 r = new Game7();
            r.ReportGame += Print;
            r.Game();
        }
        static void Print(int ret)
        {
            string str = "";
            if (ret%7==0|| ret.ToString().Contains("7"))
            {
                 str = "Boom";
                Console.Write(str);
               
            }
                
            else
            {
                
                Console.Write("{0}",ret);
            } 
            Console.Write("   \r");
        }
    }
}
