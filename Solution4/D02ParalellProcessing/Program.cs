// See https://aka.ms/new-console-template for more information
using D02ParalellProcessing;
using System.Diagnostics;

Console.WriteLine("Hello, World!");


// paralell processing and asynchronous processing

ParalellTesting pt = new ParalellTesting();
Stopwatch stopwatch = new Stopwatch();

stopwatch.Start();
pt.Task1();
pt.Task2(); 
stopwatch.Stop();

Console.WriteLine($"Sequential execution took {stopwatch.ElapsedMilliseconds} milliseconds");

// now with lambda counting at the same time, Parallel inside the same machine
stopwatch.Restart(); 
Parallel.Invoke(() => pt.Task1(), () => pt.Task2());
stopwatch.Stop();

Console.WriteLine($"Parallel execution took " +
    $"{stopwatch.ElapsedMilliseconds} milliseconds");



int numberOfCores = Environment.ProcessorCount;
Console.WriteLine($"there are {numberOfCores} logical pocessors to run things on this PC");