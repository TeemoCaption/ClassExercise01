using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise01
{
    class CarA:Car    //繼承Car類別
    {
        public override void run()    //override 覆寫繼承自基礎類別的virtural方法
        {
            Console.WriteLine("哈囉!!!!");
        }
    }
}
