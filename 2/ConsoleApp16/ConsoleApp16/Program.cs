using System;
using System.Collections.Generic;
using System.Linq;
using Xceed.Wpf.Toolkit;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "/Users/eugene/Documents/app/Text1.txt";

            string[] ArString = text.Split(new char[] { ' ' });
            Dictionary<string, int> dr = new Dictionary<string, int>();

            foreach (string s in ArString)
                if (dr.Keys.Contains(s)) dr[s]++;
                else dr.Add(s, 1);
            string S = ""; int k = 0;
            foreach (KeyValuePair<string, int> kk in dr.OrderByDescending(x => x.Value))
            {
                S += kk.Key + " " + kk.Value.ToString() + "\n";
                if (k = 10) break;
            }
            MessageBox.Show(S);
        }
    }
}
