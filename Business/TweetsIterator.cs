using System;
using System.Collections.Generic;
using System.IO;
using CollectionsPerformanceTest.Models;
using CollectionsPerformanceTest.Business;
using CsvHelper;
using System.Globalization;
using System.Diagnostics;

namespace CollectionsPerformanceTest.Business {
  abstract class TweetsIterator {
    protected Stopwatch _timer;
    public Stopwatch Timer { get { return _timer; } }
    internal TweetsIterator() {
    }
    internal abstract void DoLoop();
  }
}
