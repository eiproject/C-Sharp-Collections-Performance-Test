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
using System.Diagnostics;

namespace CollectionsPerformanceTest.Business {
  class TweetFilter {
    private string _filePath;
    private StreamReader _csvStreamer;
    CsvReader _csvReader;
    TweetSentimentFilter _sentimentFilter;
    List<Tweet> _filteredTweets;
    string _sentiment;
    Stopwatch _timer;

    internal TweetFilter(string filePath, string sentiment, Stopwatch timer) {
      _filePath = filePath;
      _sentiment = sentiment;
      _csvStreamer = File.OpenText(_filePath);
      _csvReader = new CsvReader(_csvStreamer, new CultureInfo("en-US", false));
      _sentimentFilter = new TweetSentimentFilter();
      _filteredTweets = new List<Tweet>();
      _timer = timer;
    }

    internal void RunSentimentFilterUsingIEnum() {
      IEnumerable createEnumerableTweets = new EnumerableTweets(_csvReader);
      IEnumerator enumerableTweets = createEnumerableTweets.GetEnumerator();
      _timer.Start();
      while (enumerableTweets.MoveNext()) {
/*        Tweet tweet = (Tweet)enumerableTweets.Current;
        if (_sentimentFilter.FilterBySentiment(tweet, _sentiment)) {
          _filteredTweets.Add(tweet);
        }*/
      }
      _timer.Stop();
    }

    internal void RunSentimentFilterUsingArrayList(string sentiment) {
      ArrayListOfTweets tweetsArrayList = new ArrayListOfTweets(_csvReader);
      ArrayList tweets = tweetsArrayList.GetTweets();
      _timer.Start();
      foreach (Tweet tweet in tweets) {
/*        if (_sentimentFilter.FilterBySentiment(tweet, sentiment)) {
          _filteredTweets.Add(tweet);
        }*/
      }
      _timer.Stop();
    }

    internal void RunSentimentFilterUsingArray(string sentiment) {
      ArrayOfTweets tweetsArray = new ArrayOfTweets(_csvReader);
      Tweet[] tweets = tweetsArray.GetTweets();
      _timer.Start();
      for (int i = 0; i < tweets.Length; i++) {
        /*Tweet tweet = tweets[i];
        if (tweet != null) {
          if (_sentimentFilter.FilterBySentiment(tweet, sentiment)) {
            _filteredTweets.Add(tweet);
          }
        }*/
      }
      _timer.Stop();
    }
    internal void RunSentimentFilterUsingList(string sentiment) {
      ListOfTweets tweetsArray = new ListOfTweets(_csvReader);
      List<Tweet> tweets = tweetsArray.GetTweets();
      _timer.Start();
      for (int i = 0; i < tweets.Count; i++) {
        /*Tweet tweet = tweets[i];
        if (tweet != null) {
          if (_sentimentFilter.FilterBySentiment(tweet, sentiment)) {
            _filteredTweets.Add(tweet);
          }
        }*/
      }
      _timer.Stop();
    }
  }
}
