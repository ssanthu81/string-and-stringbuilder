using System.Text;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string s = " ";
        Stopwatch ss = new Stopwatch();
        ss.Start();
        for (int i = 1; i <= 10000000; i++)
        {
            s = s + i;
        }
        ss.Stop();

        StringBuilder sb = new StringBuilder();
        Stopwatch ss1 = new Stopwatch();
        ss1.Start();
        for(int i=0; i <= 10000000; i++)
        {
            sb.Append(i);
        }
        ss1.Stop();
        Console.WriteLine("time taken for string:" + ss.ElapsedMilliseconds);
        Console.WriteLine("time taken for stringbuilder:" + ss1.ElapsedMilliseconds);
        Console.ReadLine();
    }
}

