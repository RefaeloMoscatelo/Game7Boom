using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ClassLibrary1
{
    public delegate void ReportGameHandler(int x);
   public class Game7
    {
       public event ReportGameHandler ReportGame;

       public void Game()
       {
           for (int i = 1; i <= 200; i++)
           {             
             
               Thread.Sleep(500);
               ReportGame(i);
           }
       }
    }
}
