using System;
using System.Collections.Generic;

namespace task3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Мэйн принадлежит не мне, если необходимо напишу свой(но зачем лишняя рутина?)
            DynamicArray<int> array;
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8};
            List<int> list2 = new List<int> { 9, 10, 11, 12 };

            Console.WriteLine("1. Конструктор без параметров:");
            array = new DynamicArray<int>();
            array.Print();
            Console.WriteLine("\n\n2. Конструктор с 1 параметром");
            array = new DynamicArray<int>(10);
            array.Print();
            Console.WriteLine("\n\n3. Конструктор, который в качестве параметра принимает коллекцию");
            array = new DynamicArray<int>(list1);
            array.Print();
            Console.WriteLine("\n\n4. Метод Add, добавляющий в конец массива один элемент");
            array.Add(6);
            array.Print();
            Console.WriteLine("\n\n5. Метод AddRange, добавляющий в конец массива содержимое коллекции");
            array.AddRange(list2);
            array.Print();
            Console.WriteLine("\n\n6. Метод Remove, удаляющий из коллекции указанный элемент");
            array.Remove(0);
            array.Print();
            Console.WriteLine("\n\n7. Метод Insert, позволяющий добавить элемент в произвольную позицию массив");
            array.Insert(1, 1);
            array.Print();
            Console.WriteLine("\n\n8,9. Length, Capacity см. выше. \n\n10. Интерфейсы IEnumerable и IEnumerator.");
            Console.WriteLine("\n11.  Индексатор, позволяющий работать с элементом с указанным номером");
            Console.WriteLine("array[1]={0}", array[1]);
            Console.WriteLine("\nПрограмма завершена!");
            Console.ReadKey();
        }
    }
}