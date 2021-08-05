using CollectionsPerformanceTest.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPerformanceTest.Business {
  class EnumeratorTweets : IEnumerator {
    internal EnumeratorTweets() { }

    object IEnumerator.Current => throw new NotImplementedException();

    bool IEnumerator.MoveNext() {
      throw new NotImplementedException();
    }

    void IEnumerator.Reset() {
      throw new NotImplementedException();
    }
  }
}
