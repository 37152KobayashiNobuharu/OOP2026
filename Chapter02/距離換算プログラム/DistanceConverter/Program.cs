

namespace DistanceConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 1 && args[0] == "-tom")
            {
                PrintFeetToMeterList(1,10);     //メートルへの変換
            }
            if (args.Length >= 1 && args[0] == "-tof")
            {
                PrintMeterToFeetList(1, 10);     //フィートへの変換
            }
            else
            {
                Console.WriteLine("引数エラー");
            }
        }

        static void PrintFeetToMeterList(int start, int stop)
        {
            //フィートからメートルへの対応表を出力
            for (int feet = start; feet <= stop; feet++)
            {
                double meter = FeetToMeter(feet);
                Console.WriteLine($"{feet}ft = {meter:0.000}m");
            }
        }
        static void PrintMeterToFeetList(int start, int stop)
        {
            for (int meter = start; meter < stop; meter++)
            {
                double feet = MeterToFeet(meter);
                Console.WriteLine($"{meter}m = {feet:0.000}ft");
            }
        }



        //フィートからメートルを求める
        static double FeetToMeter(int feet)
        {
            return feet * 0.3048;
        }

        static double MeterToFeet(int meter)
        {
            return meter / 0.3048;
        }
    }
}
