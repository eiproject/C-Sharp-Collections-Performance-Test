using CollectionsPerformanceTest.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsPerformanceTest.Business {
  class TweetsStack : TweetsIterator {
    Stack<Tweet> _tweets;
    internal TweetsStack(ArrayList tweets)
      : base() {
      Console.WriteLine(this.GetType().Name);
      _tweets = new Stack<Tweet>();
      foreach (Tweet tweet in tweets) {
        _tweets.Push(tweet);
      }
    }

    internal Stack<Tweet> GetTweets() {
      return _tweets;
    }

    internal override void DoLoop() {
      for (int i = 0; i < _tweets.Count; i++) {
        // Do Nothing
      }
    }
  }
}
