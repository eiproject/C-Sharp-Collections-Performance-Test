using System.Collections;

namespace CollectionsPerformanceTest.Business {
  class TweetsIEnum : TweetsIterator {
    IEnumerator _tweets;    
    internal TweetsIEnum(ArrayList tweets) 
      : base () {
      IEnumerable createEnumerableTweets = new TweetsEnumerable(tweets);
      _tweets = createEnumerableTweets.GetEnumerator();
    }
    internal IEnumerator GetTweets() {
      return _tweets;
    }
    internal override void DoLoop() {
      while (_tweets.MoveNext()) {
        // Do Nothing
      }
    }
  }
}
