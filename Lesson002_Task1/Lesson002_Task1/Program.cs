using System;

namespace Lesson002_Task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long lYear = 2002;
            Console.WriteLine($"Birth yeah: {lYear}");
            const int cName = 2;
            short sName = cName;
            const long lName = 32768;
            unchecked
            {
                short ssName = (short)lName;
            }
            
        }
    }
}
