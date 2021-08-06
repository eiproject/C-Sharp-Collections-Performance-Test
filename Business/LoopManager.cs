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
  class LoopManager {
    CSVManager _reader;
    private ArrayList _iteratorObjects = new ArrayList();
    private List<TimeSpan> _times;
    private int _numberOfIteration;
    private Stopwatch _stopwatch;

    internal LoopManager(string filePath, int numberOfIteration) {
      _numberOfIteration = numberOfIteration;
      _stopwatch = new Stopwatch();
      _reader = new CSVManager();

      // ArrayList tweets = _reader.ReadUsingCSVReader(filePath);
      ArrayList tweets = _reader.ReadUsingFileReadLines(filePath);
      _iteratorObjects.Add(new TweetsIEnum(tweets));
      _iteratorObjects.Add(new TweetsIList(tweets));

      _iteratorObjects.Add(new TweetsIReadOnlyList(tweets));
      _iteratorObjects.Add(new TweetsICollection(tweets));

      _iteratorObjects.Add(new TweetsArray(tweets));

      _iteratorObjects.Add(new TweetsList(tweets));
      _iteratorObjects.Add(new TweetsArrayList(tweets));
      _iteratorObjects.Add(new TweetsLinkedList(tweets));

      _iteratorObjects.Add(new TweetsQueue(tweets));
      _iteratorObjects.Add(new TweetsStack(tweets));

      _iteratorObjects.Add(new TweetsHashSet(tweets));

      _iteratorObjects.Add(new TweetsIDictionary(tweets));
      _iteratorObjects.Add(new TweetsHashtable(tweets));
      // _iteratorObjects.Add(new TweetsListDictionary(tweets));
      _iteratorObjects.Add(new TweetsOrderedDictionary(tweets));
      _iteratorObjects.Add(new TweetsSortedDictionary(tweets));
      // _iteratorObjects.Add(new TweetsSortedList(tweets));
      // _iteratorObjects.Add(new TweetsSortedListWithKeyValue(tweets));
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

    private void CreateNewElapsedTimeGroup() {
      _times = new List<TimeSpan>();
    }
    private void AddTimeElapsedToGroup(TimeSpan time) {
      _times.Add(time);
    }
  }
}
