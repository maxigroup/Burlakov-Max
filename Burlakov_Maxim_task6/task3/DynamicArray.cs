namespace task3
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class DynamicArray<T> : IEnumerable, IEnumerator
    {
        private T[] arr;
        private int index = -1;
        public int Length { get; private set; }
        public int Capacity { get; private set; }

        /// <summary>
        /// Возвращает перечислитель, который осуществляет итерацию по коллекции.
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        /// <summary>
        /// Перемещает перечислитель к следующему элементу коллекции
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            if(index == arr.Length - 1)
            {
                return false;
            }
            else
            {
                index++;
                return true;
            }
        }

        /// <summary>
        /// Устанавливает перечислитель в его начальное положение, т. е. перед первым элементом коллекции
        /// </summary>
        public void Reset()
        {
            index = -1;
        }

        /// <summary>
        /// Получает текущий элемент в коллекции
        /// </summary>
        public object Current
        {
            get
            {
                return arr[index];
            }
        }

        public DynamicArray()//todo конструкторы объявляются всегда в начале класса, после свойств и полей.
        {
            Capacity = 8;//todo первоначальную настройку лучше в константу
            arr = new T[Capacity];
        }

        public DynamicArray(List<T> list)//todo "коллекции .Net не использовать"
        {
            Capacity = 8;//todo для остальных конструкторов не было такого требования
            while(Capacity < list.Count)
            {
                Capacity = Capacity * 2;
            }

            arr = new T[Capacity];
            Length = list.Count;
            for (int i = 0; i < list.Count; i++)
            {
                arr[i] = list[i];
            }
        }

        public DynamicArray(int size)
        {
            Capacity = 8;
            while (Capacity < size)
            {
                Capacity = Capacity * 2;
            }

            arr = new T[Capacity];
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > Length - 1)
                    throw new ArgumentOutOfRangeException();
                return arr[index];
            }

            set
            {
                if (index < 0 || index > Length - 1)
                    throw new ArgumentOutOfRangeException();
                arr[index] = value;
            }
        }

        /// <summary>
        /// Удаляет из коллекции элемент с соответствующим индексом
        /// </summary>
        /// <param name="index">Индекс удаляемого элемента</param>
        /// <returns></returns>
        public bool Remove(int index)
        {
            try
            {
                if (index < 0 || index > Length - 1)
                {
                    throw new IndexOutOfRangeException();
                }
                for (int i = index; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                Length--;
                arr[Length] = default(T);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Добавляет элементы указанной коллекции в конец списка
        /// </summary>
        /// <param name="list"></param>
        public void AddRange(List<T> list)//todo "коллекции .Net не использовать"
        {
            if (Length + list.Count > Capacity)
            {
                while (Length + list.Count > Capacity)
                {
                    Capacity = Capacity * 2;
                }
                Array.Resize(ref arr, Capacity);
            }
            for (int i = 0; i < list.Count; i++)
            {
                arr[i + Length] = list[i];
            }
            Length += list.Count;
        }

        /// <summary>
        /// Вставляет элемент на указанный индекс
        /// </summary>
        /// <param name="index">Индекс, куда будет вставлен элемент</param>
        /// <param name="value">Вставляемый элемент</param>
        /// <returns></returns>
        public bool Insert(int index, T value)
        {
            if (index <= 0 || index > Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            try
            {
                if (Length.Equals(Capacity))    //Нужно ли расширить массив?
                {
                    Capacity = Capacity * 2;
                    Array.Resize(ref arr, Capacity);
                }

                for (int i = Length+1; i >= index; i--)
                {
                    arr[i] = arr[i - 1];
                }

                arr[index-1] = value;
                Length++;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Добавялет указанный элемент за последним элементом в коллекции
        /// </summary>
        /// <param name="element"></param>
        public void Add(T element)
        {
            if (Length.Equals(Capacity))
            {
                Capacity = Capacity * 2;
                Array.Resize(ref arr, Capacity);
            }

            arr[Length] = element;
            Length++;
        }

        /// <summary>
        /// Выводит Длинну, Реальную длинну и элементы коллекции
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Length = {0} Capacity = {1}", Length, Capacity);
            for (int i = 0; i < Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
