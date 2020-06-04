using System;
using System.Runtime.CompilerServices;

namespace DataCalculater
{
    class Program
    {
        static void Main(string[] args)
        {
            int hp = 100;
            // + - * / %
            hp = 1+2 * 100 ;//201
            hp++;//hp+1;
            hp--;//hp-1;

            Console.WriteLine(hp);
            int level = 50;
            //< <= > >= == !=
            bool isAlive = (hp > 0);
            bool isHighLevel = (level >= 40);
            //&& AND || OR ! NOT
            //a= 살아있는 고렙 유저인가요?
            
            bool a = isAlive && isHighLevel;
            //b= 살아있거나, 고렙유저이거나 둘중하나인가요?
            bool b = isAlive||isHighLevel;
            //c= wnrdms dbwjdlsrkdy?
            bool c = !isAlive;
        }
    }
}
