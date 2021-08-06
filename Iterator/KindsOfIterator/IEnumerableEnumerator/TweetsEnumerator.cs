using CollectionsPerformanceTest.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPerformanceTest.Business {
  class TweetsEnumerator : IEnumerator {
    private List<Tweet> _tweets;
    private int _position = -1;
    internal TweetsEnumerator(List<Tweet> tweets) { _tweets = tweets; }

    object IEnumerator.Current => _tweets[_position];

    bool IEnumerator.MoveNext() {
      _position++;
      return (_position < _tweets.Count);
    }

    void IEnumerator.Reset() {
      _position = -1;
    }
  }
}
