
namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            PrintInchToMetorList(1, 10);
        }
        private static void PrintInchToMetorList(int start, int end) {
            for (int Inch = start; Inch <= end; Inch++) {
                double inch = InchConverter.ToMeter(Inch);
                Console.WriteLine($"{Inch}Inch = {inch:0.000}M");
            }
        }
    }
}
