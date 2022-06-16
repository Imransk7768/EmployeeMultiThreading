using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EmpServiceADO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("EmployeePayroll using threads");
            string[] words = CreateWordArray(@"http://www.gutenberg.org/files/54700/54700-0.txt");

            #region ParallelTasks
            Parallel.Invoke(() =>
            {

                Console.WriteLine("Begin First Task...");
                GetLongestWord(words);
            }, () =>
            {
                Console.WriteLine("Begin Second Task...");
                GetMostCommonWords(words);
            }, () =>
            {
                Console.WriteLine("Begin Third Task...");
                GetCountForWord(words, "sleep");
            });

            #endregion
        }
        private static void GetMostCommonWords(string[] words)
        {
            var frequencyOrder = from word in words
                                 where word.Length > 6
                                 group word by word into g
                                 orderby g.Count() descending
                                 select g.Key;

            var commonWords = frequencyOrder.Take(10);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Task 2--The most common words are:");
            foreach (var v in commonWords)
            {
                sb.AppendLine(" " + v);
            }
            Console.WriteLine(sb.ToString());
        }
        private static void GetCountForWord(string[] words,string term)
        {
            var findWord = from word in words
                           where word.ToUpper().Contains(term.ToUpper())
                           select word;
            Console.WriteLine($@"Task 3 -- The Word ""{ term}"" occurs {findWord.Count()} times.");
        }
        private static void GetLongestWord(string[] words)
        {
            var longestWord = (from word in words
                               orderby word.Length descending
                               select word).First();
            Console.WriteLine($"Task 1 -- The LongestWord is {longestWord}.");
        }

        static string[] CreateWordArray(string url)
        {
            Console.WriteLine($"Retrieving From {url}");
            string s = new WebClient().DownloadString(url);
            return s.Split(
                new char[] { ' ', '\u000A', ',', '.', ';', ':', '-', '_', '/' },
                StringSplitOptions.RemoveEmptyEntries);
        }
    }
}