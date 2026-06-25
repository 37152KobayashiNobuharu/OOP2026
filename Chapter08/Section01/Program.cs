using System.Runtime.CompilerServices;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Section01 {
    internal class Program {
        static private Dictionary<string, string> prefOfficeDict = new Dictionary<string, string>();

        static void Main(string[] args) {
            string? pref, prefCaptlLocation;
            var dict = new Dictionary<string, string>();
            Console.WriteLine("県庁所在地の登録【入力終了:Ctrl + 'Z'】");


            //①都道府県の入力
            while (true) {
                Console.Write("都道府県:");
                pref = Console.ReadLine();
                if (pref == null) break;

                //②県庁所在地の入力
                Console.Write("県庁所在地:");
                prefCaptlLocation = Console.ReadLine();
                if (prefCaptlLocation == null) break;
                dict[pref] = prefCaptlLocation;
            }
            //③県庁所在地登録処理
            while (true) {
                Console.WriteLine("1:一覧表示");
                Console.WriteLine("2:検索");
                Console.WriteLine("9:終了");
                string? input = Console.ReadLine();

                switch (input) {
                    case "1":
                        foreach (var item in dict) {
                            Console.WriteLine($"{item.Key}の県庁所在地は{item.Value}です。");
                        }

                        break;
                    case "2":
                        Console.WriteLine("都道府県");
                        string? serch = Console.ReadLine();
                        Console.WriteLine($"{serch}の県庁所在地は{dict[serch]}です。");
                        break;
                    case "9":
                        
                        return;
                }
            }
        }
    }
}


