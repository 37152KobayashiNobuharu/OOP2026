

namespace Section04 {
    internal class Program {
        static void Main(string[] args) {

            #region nullの判定
            string? name = null;

            if (name is null) {
                Console.WriteLine("nameはnullです");
            }
            #endregion

            #region null合体演算子
            string code = "12345";

            //GetNessage()メソッドの戻り値がnullだったら、
            //Defaultmessage()メソッドが実行される
            var message = Getmessage(code)??DefaultMessage();
            Console.WriteLine(message);
            #endregion

            #region null合体代入演算子
            message = null;
            message ??= DefaultMessage();

            #endregion

            #region null条件演算子
            Sale? sale = new Sale { 
                ShopName = "新宿店",
                ProductCategory = "洋菓子",
                Amount =523100,
            };
            //sale = null;
            int? amount = sale?.Amount;
            Console.WriteLine("売上高:" + amount);
            #endregion

            #region 2つの要素を入れ替える
            int a = 10;
            int b = 20;
            Console.Write("入れ替え前:");
            Console.WriteLine(" a = " + a + " b = " + b);

            (b, a) = (a, b);      //入れ替え

            Console.Write("入れ替え後");
            Console.WriteLine(" a = " + a + " b = " + b);

            #endregion
        }

        private static string? DefaultMessage() {
            return "Defaultmesage";
        }

        private static string? Getmessage(string code) {
            return null;
        }
    }
    //売り上げクラス
    public class Sale {
        //店舗名
        public string ShopName { get; set; } = string.Empty;
        //商品カテゴリー
        public string ProductCategory { get; set; } = string.Empty;
        //売上高
        public int Amount { get; set; }
    }
}
