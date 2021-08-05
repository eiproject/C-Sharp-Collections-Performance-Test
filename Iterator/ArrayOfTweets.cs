using CollectionsPerformanceTest.Models;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPerformanceTest.Business {
  class ArrayOfTweets {
    Tweet[] _tweets;
    int _position = 0;
    internal ArrayOfTweets(CsvReader csvReader) {
      _tweets = new Tweet[50000];

      while (csvReader.Read()) {
        Tweet tweet = csvReader.GetRecord<Tweet>();
        _tweets[_position] = tweet;
        _position++;
      }
    }
    internal Tweet[] GetTweets() {
      return _tweets;
    }
  }
}
