using System;

namespace Demo.Backend
{
    public class DemoRunner
    {
        public static void Run(CancellationTokenSource token) 
        {
            Task.Run(async () =>
            {

                try
                {
                    while (!token.IsCancellationRequested)
                    {
                        Console.WriteLine("Hello from app");
                        await Task.Delay(TimeSpan.FromSeconds(2));
                    }
                    token.Token.ThrowIfCancellationRequested();
                }
                catch (OperationCanceledException)
                {
                    Console.WriteLine("Stoping app...");
                }
                finally
                {
                    token.Dispose();
                }
            }, token.Token);
        }
    }
}
