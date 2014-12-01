using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipTest
{
    public class Statistics
    {
        List<int> turns = new List<int>();
        double mean;
        double median;
        double q1;
        double q3;
        int min;
        int max;

        public Statistics(List<int> data)
        {
            foreach (int i in data)
            {
                turns.Add(i);
            }
            initialize();
            printData();
           
        }

        private void initialize()
        {
            calcMean();
            calcMedian();
            calcQuartiles();
            calcMin();
            calcMax();

        }

        private void calcMean()
        {
            int sum = 0;
            foreach (int i in turns)
            {
                sum += i;
            }

            mean = sum / turns.Count();
        }
        private void calcMedian()
        {
            turns.Sort();
            median = turns[turns.Count() / 2];

        }
        private void calcQuartiles()
        {
            q1 = turns[turns.Count() / 4];
            q3 = turns[(turns.Count() / 4) * 3];
        }
        private void calcMin()
        {
            min = turns[0];
        }
        private void calcMax(){
            max = turns[turns.Count - 1];
        }

        private void printData(){
            foreach (int i in turns)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Mean: " + mean);
            Console.WriteLine("Median: " + median);
            Console.WriteLine("Q1: " + q1);
            Console.WriteLine("Q3: " + q3);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
        }
    }

}
