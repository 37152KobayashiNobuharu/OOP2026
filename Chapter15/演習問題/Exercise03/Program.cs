using Exercise03;

var service = new Take20Processor();
var processor = new TextFileProcessor(service);
Console.Write("パス:");
 string fileName = Console.ReadLine();
processor.Run(fileName);