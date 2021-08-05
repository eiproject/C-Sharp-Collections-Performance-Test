using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPerformanceTest.Business {
  class LoopTest {
    private List<TimeSpan> _times = new List<TimeSpan>();
    internal LoopTest() {

    }
    internal void StartLoop(string filePath, int numberOfIteration) {
      for (int i = 0; i < numberOfIteration; i++) {
        var timer = new Stopwatch();
        //timer.Start();

        TweetFilter app = new TweetFilter(filePath, "positive", timer);
        //app.RunSentimentFilterUsingIEnum();
        //app.RunSentimentFilterUsingArray("positive");
        //app.RunSentimentFilterUsingArrayList("positive");
        app.RunSentimentFilterUsingList("positive");

        //timer.Stop();
        _times.Add(timer.Elapsed);
        Console.WriteLine($"{i} \t Processing Time: { timer.Elapsed }");
      }
    }
    internal void PrintAverage() {
      double doubleAverageTicks = _times.Average(timeSpan => timeSpan.Ticks);
      long longAverageTicks = Convert.ToInt64(doubleAverageTicks);
      TimeSpan averageTime = new TimeSpan(longAverageTicks);
      Console.WriteLine($"------------------------------------------");
      Console.WriteLine($"Average processing time {averageTime}");
    }
  }
}
