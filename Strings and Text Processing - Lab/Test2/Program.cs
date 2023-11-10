using System.Diagnostics;
using System.Text;
for (int i = 0; i <= 5; i++)
{
        Stopwatch sw = new Stopwatch();
    sw.Start();
    StringBuilder text = new StringBuilder();
    for (int j = 0; j < 100000000; j++)
        text.Append(j);
    sw.Stop();
    Console.WriteLine(sw.ElapsedMilliseconds);

}