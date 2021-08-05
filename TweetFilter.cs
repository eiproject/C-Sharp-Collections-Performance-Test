using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionsPerformanceTest.Models;
using CollectionsPerformanceTest.Business;
using CsvHelper;
using System.Threading;
using System.Globalization;
using System.Collections;

namespace CollectionsPerformanceTest {
  class TweetFilter {
    private string _filePath;
    private StreamReader _csvStreamer;
    CsvReader _csvReader;
    TweetSentimentFilter _sentimentFilter;
    List<Tweet> _filteredTweets;

    internal TweetFilter(string filePath) {
      _filePath = filePath;
      _csvStreamer = File.OpenText(_filePath);
      _csvReader = new CsvReader(_csvStreamer, new CultureInfo("en-US", false));
      _sentimentFilter = new TweetSentimentFilter();
      _filteredTweets = new List<Tweet>(); ;
    }

    internal void RunSentimentFilterUsingIEnum(string sentiment) {
      IEnumerable createEnumerableTweets = new EnumerableTweets(_csvReader);
      IEnumerator enumerableTweets = createEnumerableTweets.GetEnumerator();
      while (enumerableTweets.MoveNext()) {
        Tweet currentTweet = (Tweet)enumerableTweets.Current;
        if (_sentimentFilter.FilterBySentiment(currentTweet, sentiment)) {
          _filteredTweets.Add(currentTweet);
        }
      }

      Console.WriteLine($"There are {_filteredTweets.Count} {sentiment} tweets");
    }
  }
}
