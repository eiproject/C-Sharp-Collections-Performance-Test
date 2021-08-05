using CollectionsPerformanceTest.Models;
using CsvHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPerformanceTest.Business {
  class LoopRepository {
    private StreamReader _csvStreamer;
    protected CsvReader _csvReader;

    private ArrayList _iteratorObjects = new ArrayList();
    private List<TimeSpan> _times;
    private int _numberOfIteration;
    private Stopwatch _stopwatch;

    internal LoopRepository(string filePath, int numberOfIteration) {
      _numberOfIteration = numberOfIteration;
      _stopwatch = new Stopwatch();
      ArrayList tweets = ReadFromCSV(filePath);

      _iteratorObjects.Add(new TweetsArray(tweets));
      _iteratorObjects.Add(new TweetsList(tweets));
      _iteratorObjects.Add(new TweetsArrayList(tweets));
      _iteratorObjects.Add(new TweetsIEnum(tweets));
      _iteratorObjects.Add(new TweetsIList(tweets));
      _iteratorObjects.Add(new TweetsICollection(tweets));
      _iteratorObjects.Add(new TweetsIDictionary(tweets));
    }

    internal void StartLoop() {
      foreach (dynamic iterator in _iteratorObjects) {
        PrintCurrentProcess(iterator);

        CreateNewElapsedTimeGroup();
        for (int i = 0; i < _numberOfIteration; i++) {
          _stopwatch.Start();
          iterator.DoLoop(); // Do iterator in the subclass
          _stopwatch.Stop();
          AddTimeElapsedToGroup(_stopwatch.Elapsed);
          _stopwatch.Reset();
        }
        PrintAverage();
      }

    }
    private void PrintCurrentProcess(object obj) {
      Console.WriteLine($"Current Processing: { obj.GetType().Name }");
    }

    private void PrintAverage() {
      double doubleAverageTicks = _times.Average(timeSpan => timeSpan.Ticks);
      long longAverageTicks = Convert.ToInt64(doubleAverageTicks);
      TimeSpan averageTime = new TimeSpan(longAverageTicks);
      Console.WriteLine($"\nAverage processing time {averageTime}");
      Console.WriteLine($"------------------------------------------");
    
    }
    private ArrayList ReadFromCSV(string filePath) {
      ArrayList tweets = new ArrayList();
      _csvStreamer = File.OpenText(filePath);
      _csvReader = new CsvReader(_csvStreamer, new CultureInfo("en-US", false));
      while (_csvReader.Read()) {
        Tweet tweet = _csvReader.GetRecord<Tweet>();
        tweets.Add(tweet);
      }
      return tweets;
    }
    private void CreateNewElapsedTimeGroup() {
      _times = new List<TimeSpan>();
    }
    private void AddTimeElapsedToGroup(TimeSpan time) {
      _times.Add(time);
    }
  }
}
