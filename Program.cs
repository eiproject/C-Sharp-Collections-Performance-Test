using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPerformanceTest {
  class Program {
    static string _filePath = @"C:\Lab Formulatrix\CollectionsPerformanceTest\CollectionsPerformanceTest\archive\Corona_NLP_train.csv";
    static void Main(string[] args) {
      TweetFilter app = new TweetFilter(_filePath);
      var timer = new Stopwatch();
      timer.Start();
      app.RunSentimentFilterUsingIEnum("positive");
      timer.Stop();
      TimeSpan timeTaken = timer.Elapsed;
      Console.WriteLine($"Processing Time: { timeTaken }");
      Console.ReadKey();
    }
  }
}
