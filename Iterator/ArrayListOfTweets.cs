using CollectionsPerformanceTest.Models;
using CsvHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPerformanceTest.Business {
  class ArrayListOfTweets {
    ArrayList _tweets = new ArrayList();
    internal ArrayListOfTweets(CsvReader csvReader) {
      while (csvReader.Read()) {
        Tweet tweet = csvReader.GetRecord<Tweet>();
        _tweets.Add(tweet);
      }
    }
    internal ArrayList GetTweets() {
      return _tweets;
    }
  }
}
