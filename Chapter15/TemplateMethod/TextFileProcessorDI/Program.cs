using Exerise03;

var service = new LineCounterService();
var processor = new TextFileProcessor(service);
string fileName = Console.ReadLine();
processor.Run(fileName);