using CollectionsPerformanceTest.Models;
using CsvHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPerformanceTest.Business {
  class EnumerableTweets : IEnumerable {
    List<Tweet> _tweets =  new List<Tweet>();

    internal EnumerableTweets(CsvReader csvReader) {
      while (csvReader.Read()) {
        Tweet tweet = csvReader.GetRecord<Tweet>();
        _tweets.Add(tweet);
      }
      // Console.WriteLine($"There are {_tweets.Count} tweets");
    }

    IEnumerator IEnumerable.GetEnumerator() {
      return (IEnumerator)GetEnumeratorTweets();
    }

    internal EnumeratorTweets GetEnumeratorTweets() {
      return new EnumeratorTweets(_tweets);
    }
  }
}
