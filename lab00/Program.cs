using System;
class Program
{
    //return index of minimum element
    static int getMin(int[] m)
    {
        int minIndex = 0;
        for (int i = 1; i < m.Length; i++)
        {
            if(m[i]< m[minIndex]) 
                minIndex = i;
        }
        return minIndex;
    }
    static void Main(string[] args)
    {
        const int n = 4;
        const int m = 3;
        int[] a = new int[m];
        string[] b = Console.ReadLine().Split(' ');
        for(int i=0; i < n; ++i)
        {
            int t=int.Parse(b[i]);
            a[getMin(a)] += t;
        }

        int max = a.Max();
        Console.WriteLine(max);
    }
}

