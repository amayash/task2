using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_1
{
    internal class nom5
    {
        int[] arr;

        public int this[int i]
        {
            set { arr[i] = value; }
            get { return arr[i]; }
        }

        public int Length
        {
            get { return arr.Length; }
        }

        public String Print()
        {
            String str="";
            for (int i = 0; i < arr.Length; i++)
                str += arr[i]+" ";
            return str;
        }
        public nom5(int size)
        {
            arr = new int[size];
        }

        public void work()
        {
            int mini = 0;
            int maxi = 0;
            int min = 101;
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    mini = i;
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxi = i;
                }
            }
            Console.WriteLine("maxi-" + maxi + " mini-" + mini);
            if (mini < maxi)
            {
                int left = mini + 1;
                int right = maxi - 1;
                while (left < right)
                {
                    int tmp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = tmp;
                    left++;
                    right--;
                }
            }
            if (mini > maxi)
            {
                int left = maxi + 1;
                int right = mini - 1;
                while (left < right)
                {
                    int tmp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = tmp;
                    left++;
                    right--;
                }
            }
            Console.WriteLine("\nВаш измененный массив:");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }

    }
}
