using System.Text;

namespace Section05 {
    internal class Program {
        static void Main(string[] args) {
            var sb = new StringBuilder();
            foreach (var word in GetWords()) {
                sb.Append(word);
            }
            var separator = ",";
            var result = String.Join(separator,GetWords()); 
            Console.WriteLine(result);
        }

        private static IEnumerable<string> GetWords() {
            return ["Orange", "Lemon", "Strawberry"];
        }
    }
}
