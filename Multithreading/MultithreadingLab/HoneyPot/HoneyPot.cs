using System;
using System.Collections.Generic;
using System.Threading;

namespace HoneyPot
{
    public class HoneyPot<T> where T : class
    {
        private Int32 _size;
        private List<T> _items;

        CancellationToken _cancellationToken;

        private Object _putLock;
        private SemaphoreSlim _getAllEvent;
        private SemaphoreSlim _limit;

        private HoneyPot(Int32 size, CancellationToken cancellationToken)
        {
            _size = size;
            _items = new List<T>();

            _cancellationToken = cancellationToken;

            _putLock = new Object();
            _getAllEvent = new SemaphoreSlim(0);
            _limit = new SemaphoreSlim(_size);
        }

        public static HoneyPot<T> Create(Int32 size, CancellationToken cancellationToken)
        {
            if (size <= 0)
                throw new Exception("Incorrect size.");

            return new HoneyPot<T>(size, cancellationToken);
        }

        public void Put(T item)
        {
            _limit.Wait(_cancellationToken);

            lock (_putLock)
            {
                _items.Add(item);

                if (_items.Count == _size)
                    _getAllEvent.Release();
            }
        }

        public T[] GetAll()
        {
            _getAllEvent.Wait(_cancellationToken);

            T[] result = _items.ToArray();
            _items.Clear();

            _limit.Release(_size);

            return result;
        }
    }
}