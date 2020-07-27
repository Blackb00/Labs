using System;
using System.Threading;

namespace HoneyPot
{
    class Program
    {
        private static HoneyPot<String> pot;

        static CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
        static CancellationToken token = cancelTokenSource.Token;
        static void Main(String[] args)
        {
            pot = HoneyPot<String>.Create(8, token);

            for (Int32 i = 0; i < 4; ++i)                   
            {
                Thread thr = new Thread(Bee);
                thr.Start((Object)(i + 1));
            }

            Thread bear = new Thread(Bear);
            bear.Start();

            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.End)
                cancelTokenSource.Cancel();
        }

        private static void Bee(Object args)
        {
            Int32 n = (Int32)args;
            
            for (Int32 i = 0; i < 10; ++i)
            {
                pot.Put("Bee " + n + ": Message " + i);
            }
        }

        private static void Bear()
        {
            while (true)
            {
                String[] messages = pot.GetAll();

                foreach (String message in messages)
                    Console.WriteLine(message);

                Console.WriteLine("--------------------------------");
            }
        }
    }
}
