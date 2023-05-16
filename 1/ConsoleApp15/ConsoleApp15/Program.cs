using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            var myListOfItemsToWatch = new List<object> { "foo", "bar", "baz" };
            var listOfStopwatches = myListOfItemsToWatch.ToDictionary(watchItem =>
                    watchItem, i => new Stopwatch()
            );
        }
    }
}
