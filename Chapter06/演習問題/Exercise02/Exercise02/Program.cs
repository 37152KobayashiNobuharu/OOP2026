namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            int.TryParse(input, out int num);
            Console.WriteLine(num.ToString("N0"));
        }
    }
}
