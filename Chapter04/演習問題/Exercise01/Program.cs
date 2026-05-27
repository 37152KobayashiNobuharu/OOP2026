
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            List<string> langs = [
                "C#", "Java", "Ruby", "PHP", "Python", "TypeScript",
                "JavaScript", "Swift", "Go",
            ];

            Exercise1(langs);
            Console.WriteLine("---");
            Exercise2(langs);
            Console.WriteLine("---");
            Exercise3(langs);
        }

        private static void Exercise1(List<string> langs) {
            //foreach文
            Console.WriteLine("foreach文で出力");
            var names = langs.Where(s => s.Contains('S'));
            foreach (var item in names) {
                Console.WriteLine(item);
            }



            //for文
            Console.WriteLine("\nfor文で出力");
            var name = langs.Where(s => s.Contains('S')).ToList();
            for (var i = 0; i < name.Count(); i++) {
                Console.WriteLine(name[i]);
            }



            //while文
            Console.WriteLine("\nwhile文で出力");
            var name1 = langs.Where(s => s.Contains('S')).ToList();
            int l = 0;
            while (l< name1.Count()) {
                Console.WriteLine(name1[l]);
                l++;
            }



        }

        private static void Exercise2(List<string> langs) {
            //LINQを使用する(Where)
        }

        private static void Exercise3(List<string> langs) {
            
        }
    }
}
