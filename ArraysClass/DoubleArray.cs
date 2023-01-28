using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysClass
{
    class DoubleArray : MainArray
    {
        private double[] arr;
        public DoubleArray(double firstElem, double secondElem)
        {
            arr = new double[N];
            arr[0] = firstElem;
            arr[1] = secondElem;
        }


        public override void printArray()
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public override double maxArray()
        {
            double maxElem = 0;
            for (int i = 0; i < N; i++)
            {
                if (arr[i] > maxElem)
                    maxElem = arr[i];
            }
            return maxElem;
        }
    }
}
