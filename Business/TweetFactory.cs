using CollectionsPerformanceTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPerformanceTest.Business {
  class TweetFactory {
    Tweet _tweet;
    string[] _parsedCsvRow;
    internal TweetFactory() { }
    internal Tweet CreateTweet(string csvRow) {
      _tweet = new Tweet();
      _parsedCsvRow = ParseThisRow(csvRow);
      SetCsvDataToTweet();
      return _tweet;
    }
    private string[] ParseThisRow(string csvRow) {
      return csvRow.Split(',');
    }
    private void SetCsvDataToTweet() {
      _tweet.SetScreenName(_parsedCsvRow[0]);
      _tweet.SetScreenName(_parsedCsvRow[1]);
      _tweet.SetLocation(_parsedCsvRow[2]);
      _tweet.SetTweetAt(_parsedCsvRow[3]);
      _tweet.SetScreenName(_parsedCsvRow[4]);
    }
  }
}
