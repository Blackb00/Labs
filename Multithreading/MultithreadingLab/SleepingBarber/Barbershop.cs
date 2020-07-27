using System;
using System.Collections.Generic;

using System.Threading;


namespace SleepingBarber
{
    public class Barbershop<T> where T: class
    {
        private Int32 _sizeOfQueue;
        private SemaphoreSlim _barber;
        private SemaphoreSlim _queue;
        private Queue<T> _customers;
        private Object _locker = new Object();
        CancellationToken _cancellationToken;
        private Barbershop(Int32 size,CancellationToken cancellationToken)
        {
            _sizeOfQueue = size;
            _customers = new Queue<T>();
            _barber = new SemaphoreSlim(0);
            _queue = new SemaphoreSlim(0);
            _cancellationToken = cancellationToken;
        }

        public static Barbershop<T> Create(Int32 size, CancellationToken cancellationToken)
        {
            return new Barbershop<T>(size, cancellationToken);
        }

        public void CustomerComeIn(T customer)
        {
            _queue.Release();
            _barber.Release();
            lock (_locker)
            {
                if (_customers.Count < _sizeOfQueue)
                    _customers.Enqueue(customer);
            }
            
        }
        public void Barber()
        {
            while (true)
            {
                _queue.Wait(_cancellationToken);
                var customer =GetCustomer();
                if (customer != null)
                    Console.WriteLine($"Haircutting customer  {customer}");
                else
                    _barber.Wait(_cancellationToken);
            }
            
        }

        public T GetCustomer()
        {
            T customer =null;
            
            lock (_locker)
            {
                if(_customers.Count>0)
                    customer= _customers.Dequeue();
            }

            return customer;
        }
    }
}
