using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HadassaGoodman.Q1
{
    public class Q1
    {
        List<TimeSpan> hours = new List<TimeSpan>() {
            new TimeSpan(0,0,0),
            new TimeSpan(1,0,0),
            new TimeSpan(2,0,0),
            new TimeSpan(3,0,0),
            new TimeSpan(4,0,0),
            new TimeSpan(5,0,0),
            new TimeSpan(6,0,0),
            new TimeSpan(7,0,0),
            new TimeSpan(8,0,0),
            new TimeSpan(9,0,0),
        };
        public int GetMaxRevenue(int[] prices)
        {
            int max = 0;
            int maxIndex = 0;
            for (int index = 0; index < prices.Length-1; index++)
            {
                if (Math.Abs( prices[index+1] - prices[index] )> max)
                {
                    max = Math.Abs(prices[index+1] - prices[index]);
                    maxIndex = index;
                }
            }
            Console.WriteLine($"Max revenue is :{max} in hours {hours[maxIndex]}");


            return max;
        }
    }
}
