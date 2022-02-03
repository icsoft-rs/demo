// See https://aka.ms/new-console-template for more information

using Demo.Backend;

Console.WriteLine("Starting app...");
CancellationTokenSource token = new CancellationTokenSource();
DemoRunner.Run(token);
Console.ReadKey();
token.Cancel();
Console.ReadKey();
