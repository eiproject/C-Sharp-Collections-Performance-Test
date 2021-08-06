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
  class TweetsEnumerable : IEnumerable {
    List<Tweet> _tweets =  new List<Tweet>();

    internal TweetsEnumerable(ArrayList tweets) {
      foreach (Tweet tweet in tweets) {
        _tweets.Add(tweet);
      }
    }

    IEnumerator IEnumerable.GetEnumerator() {
      return (IEnumerator)GetEnumeratorTweets();
    }

    internal TweetsEnumerator GetEnumeratorTweets() {
      return new TweetsEnumerator(_tweets);
    }
  }
}
