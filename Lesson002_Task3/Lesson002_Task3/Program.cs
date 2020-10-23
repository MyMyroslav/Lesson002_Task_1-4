using System;

namespace Lesson002_Task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int iA = 5;
            int iB = 2;
            int iAdd = iA + iB;
            int iSubtract = iA - iB;
            int iMultiplication = iA * iB;
            double iDivision = (double)iA / iB;
            double iRemainder = (double)iA % iB;
            Console.WriteLine($"A + B = {iAdd}, A - B = {iSubtract}, A * B = {iMultiplication}, A / B = {iDivision}, A % B = {iRemainder}");
        }
    }
}
