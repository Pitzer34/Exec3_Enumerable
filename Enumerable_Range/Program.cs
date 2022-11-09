using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable_Range
{
    //利用Enumerable.Range() 建立一個序列, 值介於 [1, 10],請利用迴圈列出每一個項目值,確認無誤
    //利用Enumerable.Range() 建立一個序列, 值介於 [10, 15],請利用迴圈列出每一個項目值,確認無誤

    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> rangeQ1 = Enumerable.Range(1, 10);
            foreach (var number1 in rangeQ1)
            {
                Console.WriteLine(number1);
            }

            IEnumerable<int> rangeQ2 = Enumerable.Range(10, 6);
            foreach (var number2 in rangeQ2)
            {
                Console.WriteLine(number2);
            }
        }
    }
}
