

namespace DistanceConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 3 && int.TryParse(args[1], out int start)
                && int.TryParse(args[2], out int end))
            {
                if (args[0] == "-tom")
                {
                    PrintFeetToMeterList(start, end);     //メートルへの変換
                }

                else if (args[0] == "-tof")
                {
                    PrintMeterToFeetList(start, end);     //フィートへの変換
                }
                else
                {
                    Console.WriteLine("引数エラー");
                }
            }
        }
        static void PrintFeetToMeterList(int start, int stop)
        {
            //FeetConverter converter = new FeetConverter();

            //フィートからメートルへの対応表を出力
            for (int feet = start; feet <= stop; feet++)
            {
                double meter = FeetConverter.FromMeter(feet);
                Console.WriteLine($"{feet}ft = {meter:0.000}m");
            }
        }
        static void PrintMeterToFeetList(int start, int stop)
        {
            //FeetConverter converter = new FeetConverter();
            for (int meter = start; meter < stop; meter++)
            {
                double feet = FeetConverter.ToMeter(meter);
                Console.WriteLine($"{meter}m = {feet:0.000}ft");
            }
        }
    }
}
