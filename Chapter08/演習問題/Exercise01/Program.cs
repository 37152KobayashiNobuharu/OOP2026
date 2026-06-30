
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";

            Exercise1(text);
            Console.WriteLine();
            Exercise2(text);
        }

        private static void Exercise1(string text) {
            //問題8.1.1完成
            var dict = new Dictionary<char, int>();
            foreach (var alpha  in text.ToUpper()) {
                if ('A' <= alpha&&alpha<='Z') {
                    if (dict.ContainsKey(alpha)) {

                        dict[alpha]++;
                    } else {

                        dict[alpha] = 1;
                    }
                }
                
            }
            foreach (var item in dict.OrderBy(alpha => alpha.Key)) {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
        }

        private static void Exercise2(string text) {
            //問題8.1.2完成

        }
    }
}
