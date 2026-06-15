
using System.ComponentModel;
using System.Formats.Tar;
using System.Linq;
using System.Text;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";
            #region
            Console.WriteLine("6.3.1");
            Exercise1(text);

            Console.WriteLine("6.3.2");
            Exercise2(text);

            Console.WriteLine("6.3.3");
            Exercise3(text);

            Console.WriteLine("6.3.4");
            Exercise4(text);

            Console.WriteLine("6.3.5");
            Exercise5(text);

            Console.WriteLine("6.3.99");
            Exercise6(text);
            #endregion
        }

        private static void Exercise1(string text) {
            int cnt = 0;
            foreach (var t in text) {
                if (t == ' ') {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }

        private static void Exercise2(string text) {
            string result = text.Replace("big", "small");
            Console.WriteLine(result);
        }

        private static void Exercise3(string text) {
            var array = text.Split(' ');
            var sb = new StringBuilder();
            //foreach (var word in array) {
            //    if (sb.Length > 0  ) {
            //        sb.Append(word + " ");
            //    }
            //}
            //var result = String.Join(" ", array);
            //Console.WriteLine(result+".");

            foreach (var word in array.Skip(1)) {
                sb.Append(' ');
                sb.Append(word);
            }
            Console.WriteLine(sb + ".");    
        }

        private static void Exercise4(string text) {
            string[] words = text.Split(' ');
            Console.WriteLine(words.Length);
        }

        private static void Exercise5(string text) {
            var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(words => words.Length <= 4);
            foreach (var w in words) {
                Console.WriteLine(w);
            }
        }

        private static void Exercise6(string text) {
            var str = text.ToLower().Replace(" ","");

            //辞書(ディクショナリ)を使った集計
            var alphaDicCount = Enumerable.Range('a', 26).
                ToDictionary(num => ((char)num), num => 0);
            //var dict = new SortedDictionary<char, int>();
            foreach (var c in str) {
                alphaDicCount[c]++;
            }
            foreach (var word in alphaDicCount) {
                Console.WriteLine(word.Key + ":" + word.Value);
            }
            //配列を用いた集計
            var array = Enumerable.Repeat(0, 26).ToArray();
            foreach (var alph in str) {
                array[alph - 'a']++;
            }
            for(char ch = 'a';ch <= 'z'; ch++) {
                Console.WriteLine($"{ch}:{array[ch - 'a']}");
            }
            //'a'から順にカウントして集計
            for (char ch = 'a'; ch <= 'z'; ch++) {
                Console.WriteLine($"{ch}:{text.Count(c=>c==(ch))}");
            }
        }
    }
}
