using System;
using System.Threading;

namespace SleepingBarber
{
    class Program
    {

        private static Barbershop<String> bshop;
        static CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
        static CancellationToken token = cancelTokenSource.Token;

        static void Main(string[] args)
        {
            CancellationToken token = cancelTokenSource.Token;
            bshop = Barbershop<String>.Create(4, token);

            Thread thBarber = new Thread(bshop.Barber);
            thBarber.Start();

            for (var i = 0; i < 3; i++)
            {
                Thread thr = new Thread(PutCustomer);
                thr.Name = (i + 1).ToString();
                thr.Start();
            }

            Console.ReadKey();

            // Cancel the task
            cancelTokenSource.Cancel();


        }
        private static void PutCustomer()
        {
            for (var i = 0; i < 100; i++)
            {
                bshop.CustomerComeIn($"Customer №{Thread.CurrentThread.Name}{i + 1}");
            }
        }
        

    }
}
