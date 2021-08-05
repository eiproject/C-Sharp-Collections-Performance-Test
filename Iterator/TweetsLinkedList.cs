using CollectionsPerformanceTest.Models;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsPerformanceTest.Business {
  class TweetsLinkedList : TweetsIterator {
    LinkedList<Tweet> _tweets;
    internal TweetsLinkedList(ArrayList tweets)
      : base() {
      _tweets = new LinkedList<Tweet>();
      foreach (Tweet tweet in tweets) {
        _tweets.AddLast(tweet);
      }
    }

    internal LinkedList<Tweet> GetTweets() {
      return _tweets;
    }

    internal override void DoLoop() {
      for (int i = 0; i < _tweets.Count; i++) {
        // Do Nothing
      }
    }
  }
}
