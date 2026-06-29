using System.Runtime.CompilerServices;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Section01 {
    internal class Program {
        static private Dictionary<string, string> prefOfficeDict = new Dictionary<string, string>();
        static private Dictionary<string, string> flowerDict = new Dictionary<string, string>();

        static void Main(string[] args) {
            string? pref, prefCaptlLocation;
            var dict = new Dictionary<string, string>();
            var flowerDict = new Dictionary<string, string>();
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

                if (flowerDict.ContainsKey(pref)) {
                    Console.WriteLine("上書きしますか？(y/n)");
                    string? answer = Console.ReadLine();
                    if (answer == "y") {
                        flowerDict[pref] = prefCaptlLocation;
                    }
                    flowerDict[pref] = prefCaptlLocation;
                }

                flowerDict[pref] = prefCaptlLocation;
            }
            //③県庁所在地登録処理
            while (true) {
                Console.WriteLine("メニュー");
                Console.WriteLine("1:一覧表示");
                Console.WriteLine("2:検索");
                Console.WriteLine("9:終了");
                string? input = Console.ReadLine();

                switch (input) {
                    case "1":
                        foreach (var item in flowerDict) {
                            Console.WriteLine($"{item.Key}の県庁所在地は{item.Value}です。");
                        }

                        break;
                    case "2":
                        Console.WriteLine("都道府県");
                        string? serch = Console.ReadLine();
                        if (flowerDict.ContainsKey(serch)) {
                            Console.WriteLine($"{serch}の県庁所在地は{flowerDict[serch]}です。");
                        }
                        break;
                    case "9":
                        return;
                    default:
                        break;
                }
            }
        }
    }
}


