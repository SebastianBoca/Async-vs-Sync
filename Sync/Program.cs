using System.Diagnostics;
using System.Text;

Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
using (var fileStream = File.OpenRead("AsyncVsSync.txt"))
using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
{
    List<string> lines = new List<string>();
    string line;
    while ((line = streamReader.ReadLine()) != null)
    {
        lines.Add(line);
    }
}
stopWatch.Stop();
Console.WriteLine($"{stopWatch.ElapsedMilliseconds}");