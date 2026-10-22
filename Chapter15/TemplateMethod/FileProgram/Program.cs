using TextFileProcessor;
string path = @"C:\Users\infosys\source\repos\OOP2026\Chapter14\Section04\Program.cs";
Console.WriteLine("検索したい単語");
LineCounterProcessor.Word = Console.ReadLine();
TextProcessor.Run<LineCounterProcessor>(path);


   
public class LineCounterProcessor : TextProcessor {

    public static string? Word;

    private int _count = 0;

    

    protected override void Initialize(string fileName) =>
        _count = 0;

    protected override void Execute(string line) =>
        
        _count += line.Split(Word).Length -1;
    

    protected override void Terminate() =>
        Console.WriteLine($"{Word}は{_count}つ出現します ");
}