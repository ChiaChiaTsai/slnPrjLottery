using System;
using System.Collections.Generic;
using System.Text;

namespace PrjLottery.Model
{
    public class CLott
    {
        public string RanLot()
        {
            Random random = new Random();
            int[] x = new int[6];
            string str = "";
            int count = 0;
            while (count < 6)
            {
                int temp = random.Next(1, 50);
                if (!Isselected(temp, x))
                {
                    x[count] = temp;
                    count++;
                }
            }
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < x.Length - 1; j++)
                {
                    if (x[j + 1] < x[j])
                    { int big=x[j];
                        x[j] = x[j + 1];
                      x[j + 1] = big; }
                }
            
            }

            foreach (int num in x)
            { str += num.ToString() + " "; }
            return str ;
        }

        private bool Isselected(int temp, int[] x)
        {
            foreach (int i in x)
            {
                if (i == temp) { return true; }
            }
            return false;
        }
    }
}
